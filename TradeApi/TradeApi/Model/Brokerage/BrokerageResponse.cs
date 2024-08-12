using Newtonsoft.Json;

namespace TradeApi.Model.Brokerage
{
    public class BrokerageResponseBrokerage
    {
        [JsonProperty("brokerage", NullValueHandling = NullValueHandling.Ignore)]
        public string Brokerage { get; set; }
    }
    public class BrokerageResponseData
    {
        [JsonProperty("brokerage", NullValueHandling = NullValueHandling.Ignore)]
        public BrokerageResponseBrokerage Brokerage { get; set; }
    }
    public class BrokerageResponse
    {
        [JsonProperty("infoID", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoID { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public BrokerageResponseData Data { get; set; }

        [JsonProperty("infoMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoMsg { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public double? Timestamp { get; set; }
    }
}
