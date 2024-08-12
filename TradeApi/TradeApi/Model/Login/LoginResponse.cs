using Newtonsoft.Json;

namespace TradeApi.Model.Login
{
    public class LoginResponse
    {

        [JsonProperty("infoId", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoId { get; set; }

        [JsonProperty("infoMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoMsg { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public LoginResponseData Data { get; set; }

        public class LoginResponseData
        {
            [JsonProperty("accessToken", NullValueHandling = NullValueHandling.Ignore)]
            public string AccessToken { get; set; }

            [JsonProperty("refreshToken", NullValueHandling = NullValueHandling.Ignore)]
            public string RefreshToken { get; set; }

            [JsonProperty("expiryTime", NullValueHandling = NullValueHandling.Ignore)]
            public string ExpiryTime { get; set; }

            [JsonProperty("ddpi", NullValueHandling = NullValueHandling.Ignore)]
            public string Ddpi { get; set; }

            [JsonProperty("poaFlag", NullValueHandling = NullValueHandling.Ignore)]
            public string PoaFlag { get; set; }

            [JsonProperty("intellectJwtToken", NullValueHandling = NullValueHandling.Ignore)]
            public string IntellectJwtToken { get; set; }

            [JsonProperty("mobileNumber", NullValueHandling = NullValueHandling.Ignore)]
            public string MobileNumber { get; set; }

            [JsonProperty("mpinEnabled", NullValueHandling = NullValueHandling.Ignore)]
            public string MpinEnabled { get; set; }
        }

    }
}
