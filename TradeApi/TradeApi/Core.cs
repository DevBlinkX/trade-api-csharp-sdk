using TradeApi.Constants;

namespace TradeApi
{
    public class Core
    {

        internal static Config Configuration { get; private set; }

        public static void Initialize(string apiKey, string baseUrl)
        {
            Configuration = new(apiKey, baseUrl, null);
        }
    }
}
