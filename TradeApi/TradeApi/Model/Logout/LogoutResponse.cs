using Newtonsoft.Json;

namespace TradeApi.Model.Logout
{
    public class LogoutResponseData
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp3 { get; set; }
    }

    public class LogoutResponse
    {
        [JsonProperty("infoID", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoID { get; set; }

        [JsonProperty("infoMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoMsg { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timestamp { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public LogoutResponseData Data { get; set; }
    }
}
