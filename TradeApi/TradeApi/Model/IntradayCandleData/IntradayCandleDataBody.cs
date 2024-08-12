using Newtonsoft.Json;

namespace TradeApi.Model.IntradayCandleData
{
    public class IntradayCandleDataBodyData
    {
        [JsonProperty("exchangeInstrumentID", NullValueHandling = NullValueHandling.Ignore)]
        public string ExchangeInstrumentID { get; set; }

        [JsonProperty("exchange", NullValueHandling = NullValueHandling.Ignore)]
        public string Exchange { get; set; }

        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }
    }

    public class IntradayCandleDataBody
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public IntradayCandleDataBodyData Data { get; set; }
    }
}
