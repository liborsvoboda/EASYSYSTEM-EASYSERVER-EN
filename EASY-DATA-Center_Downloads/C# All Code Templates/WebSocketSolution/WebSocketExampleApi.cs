//WebSocket Example Definitions for Central Control
//By Connection List For Automatic Changes Detection
namespace EASYDATACenter.WebSocketDefinition {
    public class WebSocketExtension {
        public string? RecordId { get; set; }
        public DateTimeOffset? SocketTimeout { get; set; }
    }

    public class RecordResponse {
        public double Promised { get; set; }
        public bool Active { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class SubRecordList {
        public List<MainRecord> Item = new();
    }

    public class MainRecord {
        public uint Id { get; set; }
        public uint ClientId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public double Amount { get; set; }
        public bool Used { get; set; }
    }

    /// <summary>
    /// WEBSocket Template still not used Ideal for Terminal Panels, chat, controlling services
    /// </summary>
    [AllowAnonymous]
    [ApiController]
    [Route("[controller]")]
    public class WebSocketExampleApi : ControllerBase {
        private new const int BadRequest = ((int)HttpStatusCode.BadRequest);
        private static ILogger<WebSocketExampleApi> _logger;

        public WebSocketExampleApi(ILogger<WebSocketExampleApi> logger) {
            _logger = logger;
        }

        private static readonly List<Tuple<WebSocket, WebSocketExtension>> allSockets = new();

        /// <summary>
        /// WebSocket Registration Connection API
        /// </summary>
        /// <returns></returns>
        [HttpGet("/ws")]
        public async Task Get() {
            if (HttpContext.WebSockets.IsWebSocketRequest) {
                using var webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
                _logger.Log(LogLevel.Information, "WebSocket connection established");
                await Echo(HttpContext, webSocket);
            } else {
                HttpContext.Response.StatusCode = BadRequest;
            }
        }

        /// <summary>
        /// WebSocket API for Specific Information
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("/ws/{id}")]
        public async Task GetbyId(string id) {
            if (HttpContext.WebSockets.IsWebSocketRequest) {
                using var webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();

                string prislibeno = LoadRecordsStatus(id);
                await SendStatus(webSocket, prislibeno);

                allSockets.Add(new Tuple<WebSocket, WebSocketExtension>(webSocket, new WebSocketExtension() {
                    RecordId = id,
                    SocketTimeout = DateTimeOffset.UtcNow.AddMinutes(BackendServer.ServerSettings.ConfigWebSocketTimeoutMin)
                }
                ));

                await ListenMessages(webSocket, id);
            } else {
                HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }

        public static async Task Echo(HttpContext context, WebSocket webSocket) {
            var buffer = new byte[1024 * 4];
            WebSocketReceiveResult wsresult = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer),
            CancellationToken.None);
            while (!wsresult.CloseStatus.HasValue) {
                await webSocket.SendAsync(new ArraySegment<byte>(buffer, 0, wsresult.Count), wsresult.MessageType,
                wsresult.EndOfMessage, CancellationToken.None);
                wsresult = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
            }
            await webSocket.CloseAsync(wsresult.CloseStatus.Value, wsresult.CloseStatusDescription,
            CancellationToken.None);
        }

        //public static async Task Echo(WebSocket webSocket)
        //{
        //    var buffer = new byte[1024 * 4];
        //    var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
        //    _logger.Log(LogLevel.Information, "Message received from Client");

        // while (!result.CloseStatus.HasValue) { var serverMsg = Encoding.UTF8.GetBytes($"Server:
        // Hello. You said: {Encoding.UTF8.GetString(buffer)}"); await webSocket.SendAsync(new
        // ArraySegment<byte>(serverMsg, 0, serverMsg.Length), result.MessageType,
        // result.EndOfMessage, CancellationToken.None); _logger.Log(LogLevel.Information, "Message
        // sent to Client");

        // buffer = new byte[1024 * 4]; result = await webSocket.ReceiveAsync(new
        // ArraySegment<byte>(buffer), CancellationToken.None); _logger.Log(LogLevel.Information,
        // "Message received from Client"); }

        //    await webSocket.CloseAsync(result.CloseStatus.Value, result.CloseStatusDescription, CancellationToken.None);
        //    _logger.Log(LogLevel.Information, "WebSocket connection closed");
        //}

        /// <summary>
        /// Register new WebSocket Connection
        /// </summary>
        /// <param name="webSocket"></param>
        /// <param name="auctionId"></param>
        /// <returns></returns>
        private static async Task ListenMessages(WebSocket webSocket, string auctionId) {
            var buffer = new byte[1024 * BackendServer.ServerSettings.ConfigMaxWebSocketBufferSizeKb];
            var receiveResult = await webSocket.ReceiveAsync(
                new ArraySegment<byte>(buffer), CancellationToken.None);

            while (!receiveResult.CloseStatus.HasValue) {
                UpdateSocketsByAuctionIdInfo(auctionId);

                receiveResult = await webSocket.ReceiveAsync(
                    new ArraySegment<byte>(buffer), CancellationToken.None);
            }

            await webSocket.CloseAsync(
                receiveResult.CloseStatus.Value,
                receiveResult.CloseStatusDescription,
                CancellationToken.None);
        }

        private static async Task SendStatus(WebSocket webSocket, string value) {
            await webSocket.SendAsync(
                       new ArraySegment<byte>(Encoding.ASCII.GetBytes(value), 0, Encoding.ASCII.GetBytes(value).Length),
                       WebSocketMessageType.Text,
                       true,
                       CancellationToken.None);
        }

        /// <summary>
        /// After Change Detection is Sent Status to All Clients which are connected for Changed Information
        /// </summary>
        /// <param name="auctionId"></param>
        private static void UpdateSocketsByAuctionIdInfo(string auctionId) {
            CloseDisconnectedSocketConnections();

            string prislibeno = LoadRecordsStatus(auctionId);

            allSockets.ForEach(async socket => {
                if (socket.Item1.State == WebSocketState.Open && socket.Item2.RecordId == auctionId) {
                    await SendStatus(socket.Item1, prislibeno);
                    socket.Item2.SocketTimeout = DateTimeOffset.UtcNow.AddMinutes(BackendServer.ServerSettings.ConfigWebSocketTimeoutMin);
                }
            });
        }

        /// <summary>
        /// WebSocket Disconnection Service for All connected Clients
        /// </summary>
        private static void CloseDisconnectedSocketConnections() {
            allSockets.ForEach(socket => {
                if (socket.Item2.SocketTimeout < DateTimeOffset.UtcNow)
                    socket.Item1.CloseAsync(WebSocketCloseStatus.NormalClosure, null, CancellationToken.None);
            });

            allSockets.RemoveAll(socket => socket.Item1.State != WebSocketState.Open);
        }

        private static string LoadRecordsStatus(string auctionId) {
            RecordResponse response = new();
            response.Active = true;
            response.EndDate = DateTime.Now;
            response.Promised = 20;

            return JsonSerializer.Serialize(response);
        }
    }
}