using Newtonsoft.Json;

namespace TradeApi.Model.CancelOrder
{
    public class CancelOrderResponseData
    {
        [JsonProperty("ordId", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdId { get; set; }
    }

    public class CancelOrderResponse
    {
        [JsonProperty("infoID", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoID { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public CancelOrderResponseData Data { get; set; }

        [JsonProperty("infoMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoMsg { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public double? Timestamp { get; set; }
    }
}
