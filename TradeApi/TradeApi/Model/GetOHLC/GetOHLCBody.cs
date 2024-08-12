using Newtonsoft.Json;

namespace TradeApi.Model.GetOHLC
{
    public class GetOHLCBodyData
    {
        [JsonProperty("instruments", NullValueHandling = NullValueHandling.Ignore)]
        public List<GetOHLCBodyInstrument> Instruments { get; set; }
    }
    public class GetOHLCBodyInstrument
    {
        [JsonProperty("exchange", NullValueHandling = NullValueHandling.Ignore)]
        public string Exchange { get; set; }

        [JsonProperty("exchangeInstrumentID", NullValueHandling = NullValueHandling.Ignore)]
        public string ExchangeInstrumentID { get; set; }
    }
    public class GetOHLCBody
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public GetOHLCBodyData Data { get; set; }
    }
}
