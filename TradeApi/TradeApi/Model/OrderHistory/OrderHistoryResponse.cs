using Newtonsoft.Json;

namespace TradeApi.Model.OrderHistory
{
    public class OrderHistoryResponseData
    {
        [JsonProperty("trails", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrderHistoryResponseTrail> Trails { get; set; }
    }

    public class OrderHistoryResponse
    {
        [JsonProperty("infoID", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoID { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public OrderHistoryResponseData Data { get; set; }

        [JsonProperty("infoMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoMsg { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timestamp { get; set; }
    }

    public class OrderHistoryResponseSymbol
    {
        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string Symbol { get; set; }

        [JsonProperty("dispSym", NullValueHandling = NullValueHandling.Ignore)]
        public string DispSym { get; set; }

        [JsonProperty("excTkn", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExcTkn { get; set; }

        [JsonProperty("fno", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fno { get; set; }

        [JsonProperty("lotSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? LotSize { get; set; }

        [JsonProperty("companyName", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyName { get; set; }

        [JsonProperty("instrument", NullValueHandling = NullValueHandling.Ignore)]
        public string Instrument { get; set; }

        [JsonProperty("baseSym", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseSym { get; set; }

        [JsonProperty("mtf", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mtf { get; set; }

        [JsonProperty("strikePrice", NullValueHandling = NullValueHandling.Ignore)]
        public int? StrikePrice { get; set; }
    }

    public class OrderHistoryResponseTrail
    {
        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public OrderHistoryResponseSymbol Symbol { get; set; }

        [JsonProperty("ordAction", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdAction { get; set; }

        [JsonProperty("pendingQty", NullValueHandling = NullValueHandling.Ignore)]
        public int? PendingQty { get; set; }

        [JsonProperty("triggerPrice", NullValueHandling = NullValueHandling.Ignore)]
        public int? TriggerPrice { get; set; }

        [JsonProperty("limitPrice", NullValueHandling = NullValueHandling.Ignore)]
        public int? LimitPrice { get; set; }

        [JsonProperty("avgPrice", NullValueHandling = NullValueHandling.Ignore)]
        public int? AvgPrice { get; set; }

        [JsonProperty("disQty", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisQty { get; set; }

        [JsonProperty("ordId", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdId { get; set; }

        [JsonProperty("ordDesc", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdDesc { get; set; }

        [JsonProperty("ordValidity", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdValidity { get; set; }

        [JsonProperty("currentOrdStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentOrdStatus { get; set; }

        [JsonProperty("exc", NullValueHandling = NullValueHandling.Ignore)]
        public string Exc { get; set; }

        [JsonProperty("tradedQty", NullValueHandling = NullValueHandling.Ignore)]
        public int? TradedQty { get; set; }

        [JsonProperty("rejReason", NullValueHandling = NullValueHandling.Ignore)]
        public string RejReason { get; set; }

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public int? Price { get; set; }

        [JsonProperty("qty", NullValueHandling = NullValueHandling.Ignore)]
        public int? Qty { get; set; }

        [JsonProperty("prdType", NullValueHandling = NullValueHandling.Ignore)]
        public string PrdType { get; set; }

        [JsonProperty("exchOrdId", NullValueHandling = NullValueHandling.Ignore)]
        public string ExchOrdId { get; set; }

        [JsonProperty("lupdateDateTime", NullValueHandling = NullValueHandling.Ignore)]
        public string LupdateDateTime { get; set; }

        [JsonProperty("modifiedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedBy { get; set; }

        [JsonProperty("ordType", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdType { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }

}
