using Newtonsoft.Json;

namespace TradeApi.Model.TradeBook
{
    public class TradeBookResponseData
    {
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }
    }
    public class TradeBookResponse
    {
        [JsonProperty("infoId", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoId { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public TradeBookResponseData Data { get; set; }

        [JsonProperty("infoMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoMsg { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public double? Timestamp { get; set; }
    }


}
