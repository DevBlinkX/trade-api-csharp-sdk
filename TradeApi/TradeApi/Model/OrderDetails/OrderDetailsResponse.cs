using Newtonsoft.Json;

namespace TradeApi.Model.OrderDetails
{
    public class OrderDetailsResponseData
    {
        [JsonProperty("undAsset", NullValueHandling = NullValueHandling.Ignore)]
        public string UndAsset { get; set; }

        [JsonProperty("excOrdTime", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcOrdTime { get; set; }

        [JsonProperty("ordAction", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdAction { get; set; }

        [JsonProperty("cancelledQty", NullValueHandling = NullValueHandling.Ignore)]
        public string CancelledQty { get; set; }

        [JsonProperty("isAmo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAmo { get; set; }

        [JsonProperty("avgPrice", NullValueHandling = NullValueHandling.Ignore)]
        public string AvgPrice { get; set; }

        [JsonProperty("exitable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exitable { get; set; }

        [JsonProperty("companyName", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyName { get; set; }

        [JsonProperty("boOrdStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string BoOrdStatus { get; set; }

        [JsonProperty("ordId", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdId { get; set; }

        [JsonProperty("cancellable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cancellable { get; set; }

        [JsonProperty("excToken", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcToken { get; set; }

        [JsonProperty("optionType", NullValueHandling = NullValueHandling.Ignore)]
        public object OptionType { get; set; }

        [JsonProperty("exc", NullValueHandling = NullValueHandling.Ignore)]
        public string Exc { get; set; }

        [JsonProperty("ordDate", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdDate { get; set; }

        [JsonProperty("prdType", NullValueHandling = NullValueHandling.Ignore)]
        public string PrdType { get; set; }

        [JsonProperty("modifiedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedBy { get; set; }

        [JsonProperty("baseSym", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseSym { get; set; }

        [JsonProperty("expiry", NullValueHandling = NullValueHandling.Ignore)]
        public object Expiry { get; set; }

        [JsonProperty("modifiable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Modifiable { get; set; }

        [JsonProperty("ordStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdStatus { get; set; }

        [JsonProperty("dispSym", NullValueHandling = NullValueHandling.Ignore)]
        public string DispSym { get; set; }

        [JsonProperty("ordDuration", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdDuration { get; set; }

        [JsonProperty("childType", NullValueHandling = NullValueHandling.Ignore)]
        public string ChildType { get; set; }

        [JsonProperty("instrumentType", NullValueHandling = NullValueHandling.Ignore)]
        public string InstrumentType { get; set; }

        [JsonProperty("triggerPrice", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerPrice { get; set; }

        [JsonProperty("limitPrice", NullValueHandling = NullValueHandling.Ignore)]
        public string LimitPrice { get; set; }

        [JsonProperty("lotSize", NullValueHandling = NullValueHandling.Ignore)]
        public string LotSize { get; set; }

        [JsonProperty("multiplier", NullValueHandling = NullValueHandling.Ignore)]
        public object Multiplier { get; set; }

        [JsonProperty("strike", NullValueHandling = NullValueHandling.Ignore)]
        public object Strike { get; set; }

        [JsonProperty("disQty", NullValueHandling = NullValueHandling.Ignore)]
        public string DisQty { get; set; }

        [JsonProperty("parOrdId", NullValueHandling = NullValueHandling.Ignore)]
        public string ParOrdId { get; set; }

        [JsonProperty("mktPro", NullValueHandling = NullValueHandling.Ignore)]
        public string MktPro { get; set; }

        [JsonProperty("tradedQty", NullValueHandling = NullValueHandling.Ignore)]
        public string TradedQty { get; set; }

        [JsonProperty("remainQty", NullValueHandling = NullValueHandling.Ignore)]
        public string RemainQty { get; set; }

        [JsonProperty("rejReason", NullValueHandling = NullValueHandling.Ignore)]
        public string RejReason { get; set; }

        [JsonProperty("qty", NullValueHandling = NullValueHandling.Ignore)]
        public string Qty { get; set; }

        [JsonProperty("exchOrdId", NullValueHandling = NullValueHandling.Ignore)]
        public string ExchOrdId { get; set; }

        [JsonProperty("ordType", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdType { get; set; }

        [JsonProperty("remarks", NullValueHandling = NullValueHandling.Ignore)]
        public string Remarks { get; set; }

        [JsonProperty("trSym", NullValueHandling = NullValueHandling.Ignore)]
        public string TrSym { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }

    public class OrderDetailsResponse
    {
        [JsonProperty("infoid", NullValueHandling = NullValueHandling.Ignore)]
        public string Infoid { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrderDetailsResponseData> Data { get; set; }

        [JsonProperty("infomsg", NullValueHandling = NullValueHandling.Ignore)]
        public string Infomsg { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }
    }


}
