using TradeApi.Constants;
using System.Net;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Net.Http.Headers;


namespace TradeApi.Api.Base
{

    /// <summary>
    /// Class <c>Communicator</c> handles the POST and GET http calls.
    /// </summary>
    internal class Communicator
    {
        /// <summary>
        /// <c>PostAsync</c> makes POST call, <paramref name="body"/> to the <paramref name="endPoint"/>.
        /// <typeparamref name="B"/> is the type of Request Body object.
        /// <typeparamref name="T"/> is the type of Response Body object.
        /// <paramref name="queryParams"/> is optional. Frame it properly, without query mark (?). Example: ut_src=abcd&ut_val=efgh
        /// <paramref name="ignoreAuthToken"/> is optional. It indicates whether to add AuthToken to headers or not. 
        /// Example: For Login Api, AuthToken should not be sent. So, for Login Api, ignoreAuthToken value should be sent as true.
        /// </summary>
        public static async Task<T> PostAsync<B, T>(string endPoint, B body, string? queryParams = null, bool ignoreAuthToken = false)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (!ignoreAuthToken)
            {
                client.DefaultRequestHeaders.Add("authorization", "Bearer " + Core.Configuration.AuthToken);
            }
            client.DefaultRequestHeaders.Add("api-key", Core.Configuration.ApiKey);

            string url = Core.Configuration.BaseUrl + endPoint;
            if (queryParams != null)
            {
                url += "?" + queryParams;
            }

            HttpResponseMessage response = await client.PostAsJsonAsync(url, body);

            if (response.IsSuccessStatusCode)
            {
                string resp = await response.Content.ReadAsStringAsync();
                try
                {
                    return JsonConvert.DeserializeObject<T>(resp);
                }
                catch (Exception ex)
                {
                    throw new Exception("Invalid Response received");
                }
            }
            else if (response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new Exception("Resource not found");
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new Exception("Unauthorized. Please check AuthToken and ApiKey.");
            }
            else if (response.StatusCode == HttpStatusCode.Forbidden)
            {
                throw new Exception("Forbidden. Please check AuthToken and ApiKey.");
            }
            else
            {
                throw new Exception("Server didn't respond with success status. Status Code: " + response.StatusCode + ".");
            }
        }
        
        /// <summary>
        /// <c>GetAsync</c> makes GET call, to the <paramref name="endPoint"/>.
        /// <typeparamref name="T"/> is the type of Response Body object.
        /// <paramref name="queryParams"/> is optional. Frame it properly, without query mark (?). Example: ut_src=abcd&ut_val=efgh
        /// <paramref name="ignoreAuthToken"/> is optional. It indicates whether to add AuthToken to headers or not. 
        /// Example: For Login Api, AuthToken should not be sent. So, for Login Api, ignoreAuthToken value should be sent as true.
        /// </summary>
        public static async Task<T> GetAsync<T>(string endPoint, string? queryParams = null, bool ignoreAuthToken = false)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (!ignoreAuthToken)
            {
                client.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", Core.Configuration.AuthToken);
            }
            client.DefaultRequestHeaders.Add("api-key", Core.Configuration.ApiKey);

            string url = Core.Configuration.BaseUrl + endPoint;
            if (queryParams != null)
            {
                url += "?" + queryParams;
            }

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string resp = await response.Content.ReadAsStringAsync();
                try
                {
                    return JsonConvert.DeserializeObject<T>(resp);
                }
                catch (Exception ex)
                {
                    throw new Exception("Invalid Response received");
                }
            }
            else if (response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new Exception("Resource not found");
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new Exception("Unauthorized. Please check AuthToken and ApiKey.");
            }
            else if (response.StatusCode == HttpStatusCode.Forbidden)
            {
                throw new Exception("Forbidden. Please check AuthToken and ApiKey.");
            }
            else
            {
                throw new Exception("Server didn't respond with success status. Status Code: " + response.StatusCode + ".");
            }
        }

    }
}
