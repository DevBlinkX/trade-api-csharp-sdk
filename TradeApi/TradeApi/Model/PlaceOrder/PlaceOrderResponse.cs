using Newtonsoft.Json;

namespace TradeApi.Model.PlaceOrder
{
    public class PlaceOrderResponseData
    {
        [JsonProperty("ordStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdStatus { get; set; }

        [JsonProperty("ordId", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdId { get; set; }
    }

    public class PlaceOrderResponse
    {
        [JsonProperty("infoId", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoId { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public PlaceOrderResponseData Data { get; set; }

        [JsonProperty("infoMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoMsg { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public double? Timestamp { get; set; }
    }
}
