using Newtonsoft.Json;

namespace TradeApi.Model.ExitOrder
{
    public class ExitOrderBody
    {
        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string Symbol { get; set; }

        [JsonProperty("exc", NullValueHandling = NullValueHandling.Ignore)]
        public string Exc { get; set; }

        [JsonProperty("prdType", NullValueHandling = NullValueHandling.Ignore)]
        public string PrdType { get; set; }

        [JsonProperty("boOrdStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string BoOrdStatus { get; set; }

        [JsonProperty("parOrdId", NullValueHandling = NullValueHandling.Ignore)]
        public string ParOrdId { get; set; }

        [JsonProperty("ordId", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdId { get; set; }
    }
}
