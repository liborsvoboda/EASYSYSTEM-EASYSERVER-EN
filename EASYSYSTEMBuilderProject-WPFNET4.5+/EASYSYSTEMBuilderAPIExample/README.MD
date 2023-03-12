## API communication - 4 TYPES is enough
<sup>**For thinking, the development of tools and work with them worthy in the 21st century**</sup>

It is so. INSERT/UPDATE/DETETE/SELECT are the mentioned types which are enough
ensure the communication of any system.
And top it all off with a single list of APIaddress calls and communication is resolved
set up for this as a standardized automatic part of the kernel.

System kernel code dump, Where you just always add the address and don't care about anything else

**System APIAddresList - all calls in one place**

```cs
    /// <summary>
    /// ALL standard View AND Form API Call must end with "List" - These will automatic added for reports Definitions
    /// </summary>
    public enum ApiUrls
    {
        GlobalNETAttachmentList,
        GlobalNETAddressList,
        Authentication,
        BackendCheck,
        GlobalNETBranchList,
        GlobalNETCalendar,
        GlobalNETCreditNoteList,
        GlobalNETCreditNoteItemList,
        GlobalNETCurrencyList,
        GlobalNETDocumentAdviceList,
        GlobalNETExchangeRateList,
        GlobalNETIncomingInvoiceList,
        GlobalNETIncomingInvoiceItemList,
        GlobalNETIncomingOrderList,
        GlobalNETIncomingOrderItemList,

        GlobalNETTemplateClassList
    }
```

**4 API Calls - SYSTEM Core module**

```cs
    class ApiCommunication
    {
        public static async Task<Authentification> Authentification(ApiUrls apiUrl, string userName = null, string password = null)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(userName + ":" + password)));
                    StringContent test = new StringContent("", Encoding.UTF8, "application/json");
                    HttpResponseMessage json = await httpClient.PostAsync(App.Setting.ApiAddress + "/" + apiUrl, test);
                    return JsonConvert.DeserializeObject<Authentification>(await json.Content.ReadAsStringAsync());
                }
                catch { return new Authentification() { Token = null, Expiration = null }; }
            }
        }

        public static async Task<T> GetApiRequest<T>(ApiUrls apiUrl, string key = null, string token = null) where T : new()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try {
                    if (token != null) { httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); }
                    string json = await httpClient.GetStringAsync(App.Setting.ApiAddress + "/" + apiUrl + (!string.IsNullOrWhiteSpace(key) ? "/" + key : ""));
                    return JsonConvert.DeserializeObject<T>(json);
                } catch { return new T(); }
            }
        }

        public static async Task<DBResultMessage> PostApiRequest(ApiUrls apiUrl, HttpContent body, string key = null, string token = null)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    if (token != null) { httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); }
                    HttpResponseMessage json = await httpClient.PostAsync(App.Setting.ApiAddress + "/" + apiUrl + (!string.IsNullOrWhiteSpace(key) ? "/" + key : ""), body);
                    DBResultMessage result = JsonConvert.DeserializeObject<DBResultMessage>(await json.Content.ReadAsStringAsync());
                    if (result.ErrorMessage == null) { result.ErrorMessage = await json.Content.ReadAsStringAsync(); }
                    return result;
                }
                catch (Exception ex)
                { return new DBResultMessage() { recordCount = 0, ErrorMessage = ex.Message + Environment.NewLine + ex.StackTrace, status = "error" }; }
            }
        }

        public static async Task<DBResultMessage> PutApiRequest(ApiUrls apiUrl, HttpContent body, string key = null, string token = null)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    if (token != null) { httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); }
                    HttpResponseMessage json = await httpClient.PutAsync(App.Setting.ApiAddress + "/" + apiUrl + (!string.IsNullOrWhiteSpace(key) ? "/" + key : ""), body);
                    DBResultMessage result = JsonConvert.DeserializeObject<DBResultMessage>(await json.Content.ReadAsStringAsync());
                    if (result.ErrorMessage == null) { result.ErrorMessage = await json.Content.ReadAsStringAsync(); }
                    return result;
                }
                catch (Exception ex)
                { return new DBResultMessage() { recordCount = 0, ErrorMessage = ex.Message + Environment.NewLine + ex.StackTrace, status = "error" }; }
            }
        }

        public static async Task<DBResultMessage> DeleteApiRequest(ApiUrls apiUrl, string key = null, string token = null)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    if (token != null) { httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); }
                    HttpResponseMessage json = await httpClient.DeleteAsync(App.Setting.ApiAddress + "/" + apiUrl + (!string.IsNullOrWhiteSpace(key) ? "/" + key : ""));
                    return JsonConvert.DeserializeObject<DBResultMessage>(await json.Content.ReadAsStringAsync());
                }
                catch (Exception ex)
                { return new DBResultMessage() { recordCount = 0, ErrorMessage = ex.Message + Environment.NewLine + ex.StackTrace, status = "error" }; }
            }
        }

        public static async Task<bool> CheckApiConnection()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string json = await httpClient.GetStringAsync(App.Setting.ApiAddress + "/" + ApiUrls.BackendCheck);
                    return true;
                }
                catch
                { return false; }
            }
        }

    }
```