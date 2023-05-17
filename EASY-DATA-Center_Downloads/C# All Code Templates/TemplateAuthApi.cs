namespace EASYDATACenter.Templates {
    /// <summary>
    /// System Template of Authentication Basic / Bearer security Api communication
    /// </summary>
    [ApiController]
    [Route("TemplateAuthApi")]
    public class TemplateAuthApiService : ControllerBase {
        private static Encoding ISO_8859_1_ENCODING = Encoding.GetEncoding("ISO-8859-1");

        /// <summary>
        /// Server Basic Authentication API for login Via UserName and Password Returned is Token
        /// for next communication Token Can be limited by Time - Validating is via LifetimeValidator
        /// </summary>
        /// <param name="Authorization"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("/TemplateAuthApi")]
        public IActionResult Authenticate([FromHeader] string Authorization) {
            (string username, string password) = GetUsernameAndPasswordFromAuthorizeHeader(Authorization);

            var user = Authenticate(username, password);

            try {
                if (HttpContext.Connection.RemoteIpAddress != null && user != null) {
                    string clientIPAddr = System.Net.Dns.GetHostEntry(HttpContext.Connection.RemoteIpAddress).AddressList.First(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToString();
                    if (!string.IsNullOrWhiteSpace(clientIPAddr)) { DBOperations.WriteVisit(clientIPAddr, user.Id, username); }
                }
            } catch { }

            if (user == null)
                return BadRequest(new { message = DBOperations.DBTranslate("UsernameOrPasswordIncorrect", BackendServer.ServerSettings.ConfigServerLanguage) });

            if (!BackendServer.ServerSettings.ServerTimeTokenValidationEnabled) { user.Expiration = null; }

            RefreshUserToken(username, user);
            return Ok(JsonSerializer.Serialize(user));
        }

        private static (string?, string?) GetUsernameAndPasswordFromAuthorizeHeader(string authorizeHeader) {
            if (authorizeHeader == null || (!authorizeHeader.Contains("Basic ") && !authorizeHeader.Contains("Bearer "))) return (null, null);

            if (authorizeHeader.Contains("Basic ")) {
                string encodedUsernamePassword = authorizeHeader.Substring("Basic ".Length).Trim();
                string usernamePassword = ISO_8859_1_ENCODING.GetString(Convert.FromBase64String(encodedUsernamePassword));

                string username = usernamePassword.Split(':')[0];
                string password = usernamePassword.Split(':')[1];

                return (username, password);
            }

            return (null, null);
        }

        /// <summary>
        /// API Authenticated and Generate Token
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static AuthenticateResponse? Authenticate(string? username, string? password) {
            if (username == null)
                return null;

            var user = new EASYDATACenterContext()
                .UserLists.Include(a => a.Role).Where(a => a.Active == true && a.UserName == username && a.Password == password)
                .First();

            if (user == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(BackendServer.ServerSettings.ConfigJwtLocalKey);
            var tokenDescriptor = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.PrimarySid, user.Id.ToString()),
                    new Claim(ClaimTypes.NameIdentifier, user.UserName),
                    new Claim(ClaimTypes.Role, user.Role.SystemName),
                    new Claim(ClaimTypes.Dns, BackendServer.ServerSettings.ConfigCertificateDomain),
                }),
                Issuer = user.UserName,
                NotBefore = DateTimeOffset.Now.DateTime,
                Expires = DateTimeOffset.Now.AddMinutes(BackendServer.ServerSettings.ConfigApiTokenTimeoutMin).DateTime,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            AuthenticateResponse authResponse = new() { Id = user.Id, Name = user.Name, Surname = user.SurName, Token = tokenHandler.WriteToken(token), Expiration = token.ValidTo.ToLocalTime(), Role = user.Role.SystemName };
            return authResponse;
        }

        /// <summary>
        /// API Refresh User Token
        /// </summary>
        /// <param name="username"></param>
        /// <param name="token">   </param>
        /// <returns></returns>
        public static bool RefreshUserToken(string username, AuthenticateResponse token) {
            try {
                var dbUser = new EASYDATACenterContext()
                    .UserLists.Where(a => a.Active == true && a.UserName == username)
                    .First();
                if (dbUser == null || dbUser.Token == token.Token && dbUser.Expiration < DateTimeOffset.Now) return false;

                dbUser.Token = token.Token;
                dbUser.Expiration = token.Expiration;
                var data = new EASYDATACenterContext().UserLists.Update(dbUser);
                int result = data.Context.SaveChanges();

                if (result > 0) return true;
                return false;
            } catch (Exception ex) { }
            return false;
        }

        /// <summary>
        /// API Token LifeTime Validator
        /// </summary>
        /// <param name="notBefore"></param>
        /// <param name="expires">  </param>
        /// <param name="token">    </param>
        /// <param name="params">   </param>
        /// <returns></returns>
        internal static bool LifetimeValidator(DateTime? notBefore, DateTime? expires, SecurityToken token, TokenValidationParameters @params) {
            if (RefreshUserToken(token.Issuer, new AuthenticateResponse() { Token = ((JwtSecurityToken)token).RawData.ToString(), Expiration = DateTimeOffset.Now.AddMinutes(BackendServer.ServerSettings.ConfigApiTokenTimeoutMin).DateTime }))
                return true;
            else return false;
        }
    }
}