using Newtonsoft.Json;

namespace TradeApi.Model.GetOHLC
{
    public class GetOHLCResponseData
    {
        [JsonProperty("presentData", NullValueHandling = NullValueHandling.Ignore)]
        public List<GetOHLCResponsePresentDatum> PresentData { get; set; }
    }
    public class GetOHLCResponsePresentDatum
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        [JsonProperty("exchangeInstrumentID", NullValueHandling = NullValueHandling.Ignore)]
        public string ExchangeInstrumentID { get; set; }

        [JsonProperty("exchange", NullValueHandling = NullValueHandling.Ignore)]
        public string Exchange { get; set; }
    }
    public class GetOHLCResponse
    {
        [JsonProperty("infoID", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoID { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public GetOHLCResponseData Data { get; set; }

        [JsonProperty("infoMsg", NullValueHandling = NullValueHandling.Ignore)]
        public object InfoMsg { get; set; }
    }
}
