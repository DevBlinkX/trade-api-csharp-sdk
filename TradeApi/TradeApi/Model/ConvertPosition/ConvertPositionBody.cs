using Newtonsoft.Json;

namespace TradeApi.Model.ConvertPosition
{
    public class ConvertPositionBody
    {
        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string Symbol { get; set; }

        [JsonProperty("exc", NullValueHandling = NullValueHandling.Ignore)]
        public string Exc { get; set; }

        [JsonProperty("ordAction", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdAction { get; set; }

        [JsonProperty("lotSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? LotSize { get; set; }

        [JsonProperty("prdType", NullValueHandling = NullValueHandling.Ignore)]
        public string PrdType { get; set; }

        [JsonProperty("qty", NullValueHandling = NullValueHandling.Ignore)]
        public double? Qty { get; set; }

        [JsonProperty("toPrdType", NullValueHandling = NullValueHandling.Ignore)]
        public string ToPrdType { get; set; }

        [JsonProperty("instrument", NullValueHandling = NullValueHandling.Ignore)]
        public string Instrument { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("excToken", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcToken { get; set; }
    }
}
