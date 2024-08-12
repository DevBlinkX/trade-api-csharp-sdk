using Newtonsoft.Json;

namespace TradeApi.Model.Report
{
    public class ReportBodyData
    {
        [JsonProperty("fromDate", NullValueHandling = NullValueHandling.Ignore)]
        public string FromDate { get; set; }

        [JsonProperty("months", NullValueHandling = NullValueHandling.Ignore)]
        public string Months { get; set; }

        [JsonProperty("fy", NullValueHandling = NullValueHandling.Ignore)]
        public string Fy { get; set; }

        [JsonProperty("segment", NullValueHandling = NullValueHandling.Ignore)]
        public string Segment { get; set; }

        [JsonProperty("toDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ToDate { get; set; }

        [JsonProperty("days", NullValueHandling = NullValueHandling.Ignore)]
        public string Days { get; set; }
    }

    public class ReportBody
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ReportBodyData Data { get; set; }

        [JsonProperty("appID", NullValueHandling = NullValueHandling.Ignore)]
        public string AppID { get; set; }
    }

}
