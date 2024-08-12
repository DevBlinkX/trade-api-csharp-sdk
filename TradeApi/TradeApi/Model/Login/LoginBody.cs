using Newtonsoft.Json;

namespace TradeApi.Model.Login
{
    /// <summary>
    /// LoginBody
    /// </summary>
    public class LoginBody
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }

    }
}
