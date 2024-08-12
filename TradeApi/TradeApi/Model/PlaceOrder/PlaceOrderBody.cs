using Newtonsoft.Json;

namespace TradeApi.Model.PlaceOrder
{
    public class PlaceOrderBody
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

        [JsonProperty("boTgtPrice", NullValueHandling = NullValueHandling.Ignore)]
        public double? BoTgtPrice { get; set; }

        [JsonProperty("instrument", NullValueHandling = NullValueHandling.Ignore)]
        public string Instrument { get; set; }

        [JsonProperty("ordValidity", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdValidity { get; set; }

        [JsonProperty("excToken", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcToken { get; set; }

        [JsonProperty("exc", NullValueHandling = NullValueHandling.Ignore)]
        public string Exc { get; set; }

        [JsonProperty("trailingSL", NullValueHandling = NullValueHandling.Ignore)]
        public double? TrailingSL { get; set; }

        [JsonProperty("build", NullValueHandling = NullValueHandling.Ignore)]
        public string Build { get; set; }

        [JsonProperty("prdType", NullValueHandling = NullValueHandling.Ignore)]
        public string PrdType { get; set; }

        [JsonProperty("qty", NullValueHandling = NullValueHandling.Ignore)]
        public double? Qty { get; set; }

        [JsonProperty("ordType", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdType { get; set; }

        [JsonProperty("boStpLoss", NullValueHandling = NullValueHandling.Ignore)]
        public double? BoStpLoss { get; set; }
    }
}
