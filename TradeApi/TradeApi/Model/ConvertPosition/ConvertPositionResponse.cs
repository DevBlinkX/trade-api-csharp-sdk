using Newtonsoft.Json;

namespace TradeApi.Model.ConvertPosition
{
    public class ConvertPositionResponseData
    {
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }
    }
    public class ConvertPositionResponse
    {
        [JsonProperty("infoId", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoId { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ConvertPositionResponseData Data { get; set; }

        [JsonProperty("infoMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoMsg { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public double? Timestamp { get; set; }
    }
}
