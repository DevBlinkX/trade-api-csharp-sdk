using Newtonsoft.Json;

namespace TradeApi.Model.Report
{
    public class ReportResponseData
    {
        [JsonProperty("clientId", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        [JsonProperty("plReport", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReportResponsePlReport> PlReport { get; set; }
    }

    public class ReportResponsePlReport
    {
        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public ReportResponseSymbol Symbol { get; set; }

        [JsonProperty("clientName", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientName { get; set; }

        [JsonProperty("buyDate", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyDate { get; set; }

        [JsonProperty("expiryDate", NullValueHandling = NullValueHandling.Ignore)]
        public object ExpiryDate { get; set; }

        [JsonProperty("intraDayPL", NullValueHandling = NullValueHandling.Ignore)]
        public string IntraDayPL { get; set; }

        [JsonProperty("openCost", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenCost { get; set; }

        [JsonProperty("sellValue", NullValueHandling = NullValueHandling.Ignore)]
        public string SellValue { get; set; }

        [JsonProperty("scripCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ScripCode { get; set; }

        [JsonProperty("buyValue", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyValue { get; set; }

        [JsonProperty("buyRate", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyRate { get; set; }

        [JsonProperty("scripName", NullValueHandling = NullValueHandling.Ignore)]
        public string ScripName { get; set; }

        [JsonProperty("openRate", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenRate { get; set; }

        [JsonProperty("realisedPLFutures", NullValueHandling = NullValueHandling.Ignore)]
        public string RealisedPLFutures { get; set; }

        [JsonProperty("longTermPL", NullValueHandling = NullValueHandling.Ignore)]
        public string LongTermPL { get; set; }

        [JsonProperty("callPut", NullValueHandling = NullValueHandling.Ignore)]
        public object CallPut { get; set; }

        [JsonProperty("realisedPLTotal", NullValueHandling = NullValueHandling.Ignore)]
        public string RealisedPLTotal { get; set; }

        [JsonProperty("unrealisedPLOptions", NullValueHandling = NullValueHandling.Ignore)]
        public string UnrealisedPLOptions { get; set; }

        [JsonProperty("realisedPLOptions", NullValueHandling = NullValueHandling.Ignore)]
        public string RealisedPLOptions { get; set; }

        [JsonProperty("unrealisedPLFutures", NullValueHandling = NullValueHandling.Ignore)]
        public string UnrealisedPLFutures { get; set; }

        [JsonProperty("segmentName", NullValueHandling = NullValueHandling.Ignore)]
        public string SegmentName { get; set; }

        [JsonProperty("sellQty", NullValueHandling = NullValueHandling.Ignore)]
        public string SellQty { get; set; }

        [JsonProperty("sellRate", NullValueHandling = NullValueHandling.Ignore)]
        public string SellRate { get; set; }

        [JsonProperty("buyQty", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyQty { get; set; }

        [JsonProperty("productCode", NullValueHandling = NullValueHandling.Ignore)]
        public object ProductCode { get; set; }

        [JsonProperty("productTypeShort", NullValueHandling = NullValueHandling.Ignore)]
        public object ProductTypeShort { get; set; }

        [JsonProperty("clientCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientCode { get; set; }

        [JsonProperty("shortTermPL", NullValueHandling = NullValueHandling.Ignore)]
        public string ShortTermPL { get; set; }

        [JsonProperty("openQty", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenQty { get; set; }

        [JsonProperty("sellDate", NullValueHandling = NullValueHandling.Ignore)]
        public string SellDate { get; set; }

        [JsonProperty("unrealisedPLTotal", NullValueHandling = NullValueHandling.Ignore)]
        public string UnrealisedPLTotal { get; set; }

        [JsonProperty("openDate", NullValueHandling = NullValueHandling.Ignore)]
        public object OpenDate { get; set; }

        [JsonProperty("strikePrice", NullValueHandling = NullValueHandling.Ignore)]
        public object StrikePrice { get; set; }

        [JsonProperty("isin", NullValueHandling = NullValueHandling.Ignore)]
        public string Isin { get; set; }
    }

    public class ReportResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int? Code { get; set; }

        [JsonProperty("infoID", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoID { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ReportResponseData Data { get; set; }

        [JsonProperty("infoMsg", NullValueHandling = NullValueHandling.Ignore)]
        public object InfoMsg { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }

    public class ReportResponseSymbol
    {
        [JsonProperty("symbol", NullValueHandling = NullValueHandling.Ignore)]
        public string Symbol { get; set; }

        [JsonProperty("dispSym", NullValueHandling = NullValueHandling.Ignore)]
        public string DispSym { get; set; }

        [JsonProperty("exc", NullValueHandling = NullValueHandling.Ignore)]
        public string Exc { get; set; }

        [JsonProperty("streamSym", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamSym { get; set; }

        [JsonProperty("baseSym", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseSym { get; set; }
    }


}
