using Newtonsoft.Json;

namespace TradeApi.Model.Login
{
    public class LoginResponse
    {
        [JsonProperty("infoID", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoId { get; set; }

        [JsonProperty("infoMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoMsg { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long Timestamp { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public LoginResponseData Data { get; set; }

        public override string ToString()
        {
            return $"InfoId: {InfoId}, InfoMsg: {InfoMsg}, Timestamp: {Timestamp}, Data: {Data?.ToString() ?? "null"}";
        }

        public class LoginResponseData
        {
            [JsonProperty("accessToken", NullValueHandling = NullValueHandling.Ignore)]
            public string AccessToken { get; set; }

            [JsonProperty("refreshToken", NullValueHandling = NullValueHandling.Ignore)]
            public string RefreshToken { get; set; }

            [JsonProperty("tokenExpiry", NullValueHandling = NullValueHandling.Ignore)]
            public string TokenExpiry { get; set; }

            [JsonProperty("userName", NullValueHandling = NullValueHandling.Ignore)]
            public string UserName { get; set; }

            [JsonProperty("appId", NullValueHandling = NullValueHandling.Ignore)]
            public string AppId { get; set; }

            public override string ToString()
            {
                return $"AccessToken: {AccessToken}, RefreshToken: {RefreshToken}, TokenExpiry: {TokenExpiry}, " +
                       $"UserName: {UserName}, AppId: {AppId}";
            }
        }
    }
}
