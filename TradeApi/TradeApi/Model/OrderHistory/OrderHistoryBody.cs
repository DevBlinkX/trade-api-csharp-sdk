using Newtonsoft.Json;

namespace TradeApi.Model.OrderHistory
{
    public class OrderHistoryBody
    {
        [JsonProperty("ordId", NullValueHandling = NullValueHandling.Ignore)]
        public string OrdId { get; set; }
    }
}




