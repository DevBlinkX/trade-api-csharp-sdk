using Newtonsoft.Json;

namespace TradeApi.Model.ModifyOrder
{
    public class ModifyOrderBody
    {
        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string Symbol { get; set; }

        [JsonProperty("ordAction", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdAction { get; set; }

        [JsonProperty("amo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Amo { get; set; }

        [JsonProperty("triggerPrice", NullValueHandling = NullValueHandling.Ignore)]
        public double? TriggerPrice { get; set; }

        [JsonProperty("limitPrice", NullValueHandling = NullValueHandling.Ignore)]
        public double? LimitPrice { get; set; }

        [JsonProperty("lotSize", NullValueHandling = NullValueHandling.Ignore)]
        public double? LotSize { get; set; }

        [JsonProperty("disQty", NullValueHandling = NullValueHandling.Ignore)]
        public double? DisQty { get; set; }

        [JsonProperty("instrument", NullValueHandling = NullValueHandling.Ignore)]
        public string Instrument { get; set; }

        [JsonProperty("exchangeToken", NullValueHandling = NullValueHandling.Ignore)]
        public string ExchangeToken { get; set; }

        [JsonProperty("ordId", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdId { get; set; }

        [JsonProperty("ordValidity", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdValidity { get; set; }

        [JsonProperty("exc", NullValueHandling = NullValueHandling.Ignore)]
        public string Exc { get; set; }

        [JsonProperty("tradedQty", NullValueHandling = NullValueHandling.Ignore)]
        public double? TradedQty { get; set; }

        [JsonProperty("prdType", NullValueHandling = NullValueHandling.Ignore)]
        public string PrdType { get; set; }

        [JsonProperty("qty", NullValueHandling = NullValueHandling.Ignore)]
        public double? Qty { get; set; }

        [JsonProperty("ordValidityDays", NullValueHandling = NullValueHandling.Ignore)]
        public double? OrdValidityDays { get; set; }

        [JsonProperty("ordType", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdType { get; set; }
    }
}
