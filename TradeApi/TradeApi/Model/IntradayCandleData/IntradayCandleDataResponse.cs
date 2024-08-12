using Newtonsoft.Json;

namespace TradeApi.Model.IntradayCandleData
{
    public class IntradayCandleDataResponseData
    {
        [JsonProperty("exchangeInstrumentID", NullValueHandling = NullValueHandling.Ignore)]
        public string ExchangeInstrumentID { get; set; }

        [JsonProperty("prevDataAvailableTime", NullValueHandling = NullValueHandling.Ignore)]
        public object PrevDataAvailableTime { get; set; }

        [JsonProperty("optionChainDetails", NullValueHandling = NullValueHandling.Ignore)]
        public object OptionChainDetails { get; set; }

        [JsonProperty("exchange", NullValueHandling = NullValueHandling.Ignore)]
        public string Exchange { get; set; }

        [JsonProperty("intradayData", NullValueHandling = NullValueHandling.Ignore)]
        public string IntradayData { get; set; }
    }
    public class IntradayCandleDataResponse
    {
        [JsonProperty("infoID", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoID { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public IntradayCandleDataResponseData Data { get; set; }

        [JsonProperty("infoMsg", NullValueHandling = NullValueHandling.Ignore)]
        public object InfoMsg { get; set; }
    }

}
