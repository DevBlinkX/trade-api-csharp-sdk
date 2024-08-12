using Newtonsoft.Json;

namespace TradeApi.Model.Holdings
{
    public class HoldingsResponseData
    {
    }
    public class HoldingsResponse
    {
        [JsonProperty("infoId", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoId { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public HoldingsResponseData Data { get; set; }

        [JsonProperty("infoMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoMsg { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public double? Timestamp { get; set; }
    }
}
