using GlobalNET.Classes;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GlobalNET.Api
{
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
}
