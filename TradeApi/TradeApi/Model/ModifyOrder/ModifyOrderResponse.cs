using Newtonsoft.Json;

namespace TradeApi.Model.ModifyOrder
{
    public class ModifyOrderResponseData
    {
        [JsonProperty("ordStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdStatus { get; set; }

        [JsonProperty("rejReason", NullValueHandling = NullValueHandling.Ignore)]
        public string RejReason { get; set; }

        [JsonProperty("ordId", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdId { get; set; }
    }

    public class ModifyOrderResponse
    {
        [JsonProperty("infoId", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoId { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ModifyOrderResponseData Data { get; set; }

        [JsonProperty("infoMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoMsg { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public double? Timestamp { get; set; }
    }
}
