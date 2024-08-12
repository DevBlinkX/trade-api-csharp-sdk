using Newtonsoft.Json;

namespace TradeApi.Model.Brokerage
{
    public class BrokerageBody
    {
        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string Symbol { get; set; }

        [JsonProperty("exc", NullValueHandling = NullValueHandling.Ignore)]
        public string Exc { get; set; }

        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public string Product { get; set; }

        [JsonProperty("triggerPrice", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerPrice { get; set; }

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public string Price { get; set; }

        [JsonProperty("qty", NullValueHandling = NullValueHandling.Ignore)]
        public string Qty { get; set; }

        [JsonProperty("instrument", NullValueHandling = NullValueHandling.Ignore)]
        public string Instrument { get; set; }

        [JsonProperty("orderAction", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderAction { get; set; }

        [JsonProperty("excToken", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcToken { get; set; }
    }
}
