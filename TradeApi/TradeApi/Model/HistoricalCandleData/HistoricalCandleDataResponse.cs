using Newtonsoft.Json;

namespace TradeApi.Model.HistoricalCandleData
{
    public class HistoricalCandleDataResponse
    {
        [JsonProperty("s", NullValueHandling = NullValueHandling.Ignore)]
        public string S { get; set; }

        [JsonProperty("c", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> C { get; set; }

        [JsonProperty("t", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> T { get; set; }

        [JsonProperty("v", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> V { get; set; }

        [JsonProperty("h", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> H { get; set; }

        [JsonProperty("l", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> L { get; set; }

        [JsonProperty("o", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> O { get; set; }
    }
}
