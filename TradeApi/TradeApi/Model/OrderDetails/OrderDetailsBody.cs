using Newtonsoft.Json;

namespace TradeApi.Model.OrderDetails
{
    public class OrderDetailsBody
    {
        [JsonProperty("ordId", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdId { get; set; }
    }
}
