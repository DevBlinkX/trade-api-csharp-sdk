using Newtonsoft.Json;

namespace TradeApi.Model.OrderBook
{
    public class OrderBookResponseData
    {
        [JsonProperty("orders", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrderBookResponseOrder> Orders { get; set; }
    }

    public class OrderBookResponseOrder
    {
        [JsonProperty("undAsset", NullValueHandling = NullValueHandling.Ignore)]
        public string UndAsset { get; set; }

        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public OrderBookResponseSymbol Symbol { get; set; }

        [JsonProperty("excOrdTime", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcOrdTime { get; set; }

        [JsonProperty("ordAction", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdAction { get; set; }

        [JsonProperty("amo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Amo { get; set; }

        [JsonProperty("cancelledQty", NullValueHandling = NullValueHandling.Ignore)]
        public int? CancelledQty { get; set; }

        [JsonProperty("avgPrice", NullValueHandling = NullValueHandling.Ignore)]
        public int? AvgPrice { get; set; }

        [JsonProperty("exitable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exitable { get; set; }

        [JsonProperty("boOrdStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string BoOrdStatus { get; set; }

        [JsonProperty("ordId", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdId { get; set; }

        [JsonProperty("cancellable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cancellable { get; set; }

        [JsonProperty("ordValidity", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdValidity { get; set; }

        [JsonProperty("ordDate", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdDate { get; set; }

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public int? Price { get; set; }

        [JsonProperty("prdType", NullValueHandling = NullValueHandling.Ignore)]
        public string PrdType { get; set; }

        [JsonProperty("modifiedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Modifiable { get; set; }

        [JsonProperty("triggerPrice", NullValueHandling = NullValueHandling.Ignore)]
        public int? TriggerPrice { get; set; }

        [JsonProperty("disQty", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisQty { get; set; }

        [JsonProperty("parOrdId", NullValueHandling = NullValueHandling.Ignore)]
        public string ParOrdId { get; set; }

        [JsonProperty("mktPro", NullValueHandling = NullValueHandling.Ignore)]
        public string MktPro { get; set; }

        [JsonProperty("tradedQty", NullValueHandling = NullValueHandling.Ignore)]
        public int? TradedQty { get; set; }

        [JsonProperty("remainQty", NullValueHandling = NullValueHandling.Ignore)]
        public int? RemainQty { get; set; }

        [JsonProperty("rejReason", NullValueHandling = NullValueHandling.Ignore)]
        public string RejReason { get; set; }

        [JsonProperty("qty", NullValueHandling = NullValueHandling.Ignore)]
        public int? Qty { get; set; }

        [JsonProperty("exchOrdId", NullValueHandling = NullValueHandling.Ignore)]
        public string ExchOrdId { get; set; }

        [JsonProperty("ordType", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdType { get; set; }

        [JsonProperty("remarks", NullValueHandling = NullValueHandling.Ignore)]
        public string Remarks { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }

    public class OrderBookResponse
    {
        [JsonProperty("infoID", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoID { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public OrderBookResponseData Data { get; set; }

        [JsonProperty("infoMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoMsg { get; set; }
    }

    public class OrderBookResponseSymbol
    {
        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string Symbol { get; set; }

        [JsonProperty("dispSym", NullValueHandling = NullValueHandling.Ignore)]
        public string DispSym { get; set; }

        [JsonProperty("exc", NullValueHandling = NullValueHandling.Ignore)]
        public string Exc { get; set; }

        [JsonProperty("excTkn", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExcTkn { get; set; }

        [JsonProperty("lotSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? LotSize { get; set; }

        [JsonProperty("companyName", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyName { get; set; }

        [JsonProperty("segment", NullValueHandling = NullValueHandling.Ignore)]
        public string Segment { get; set; }

        [JsonProperty("instrument", NullValueHandling = NullValueHandling.Ignore)]
        public string Instrument { get; set; }

        [JsonProperty("baseSym", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseSym { get; set; }

        [JsonProperty("strikePrice", NullValueHandling = NullValueHandling.Ignore)]
        public int? StrikePrice { get; set; }
    }

}
