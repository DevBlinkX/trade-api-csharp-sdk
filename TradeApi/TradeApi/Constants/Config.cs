using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeApi.Constants
{
    internal class Config(string apiKey, string baseUrl, string? authToken)
    {
        private readonly string apiKey = apiKey;
        private readonly string baseUrl = baseUrl;
        private string? authToken = authToken;

        public string ApiKey { get => apiKey; }
        public string? AuthToken { get => authToken; internal set => authToken = value; }
        public string BaseUrl { get => baseUrl; }
    }
}
