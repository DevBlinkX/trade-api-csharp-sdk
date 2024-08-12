using Newtonsoft.Json;

namespace TradeApi.Model.ExitOrder
{
    public class ExitOrderResponseData
    {
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }
    }

    public class ExitOrderResponse
    {
        [JsonProperty("infoId", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoId { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ExitOrderResponseData Data { get; set; }

        [JsonProperty("infoMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoMsg { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public double? Timestamp { get; set; }
    }
}
