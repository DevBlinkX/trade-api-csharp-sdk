using Newtonsoft.Json;

namespace TradeApi.Model.TradeDetails
{
    public class TradeDetailsBody
        {
            [JsonProperty("ordId", NullValueHandling = NullValueHandling.Ignore)]
            public string OrdId { get; set; }
        }
    
}
