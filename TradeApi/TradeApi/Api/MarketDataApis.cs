using TradeApi.Api.Base;
using TradeApi.Constants;
using TradeApi.Model.Brokerage;
using TradeApi.Model.GetOHLC;
using TradeApi.Model.HistoricalCandleData;
using TradeApi.Model.IntradayCandleData;
using TradeApi.Model.Quote;

namespace TradeApi.Api
{
    public class MarketDataApis
    {
        public static async Task<BrokerageResponse> BrokerageAsync(BrokerageBody body)
        {
            ArgumentNullException.ThrowIfNull(body);

            return await Communicator.PostAsync<BrokerageBody, BrokerageResponse>(EndPoints.Brokerage, body);
        }

        public static async Task<GetOHLCResponse> GetOHLCAsync(GetOHLCBody body)
        {
            ArgumentNullException.ThrowIfNull(body);

            return await Communicator.PostAsync<GetOHLCBody, GetOHLCResponse>(EndPoints.GetOHLC, body);
        }

        public static async Task<IntradayCandleDataResponse> IntradayCandleDataAsync(IntradayCandleDataBody body)
        {
            ArgumentNullException.ThrowIfNull(body);

            return await Communicator.PostAsync<IntradayCandleDataBody, IntradayCandleDataResponse>(EndPoints.IntradayCandleData, body);
        }

        public static async Task<HistoricalCandleDataResponse> HistoricalCandleDataAsync(string symbol, string resolution, string from, string to, string countback, string exc, string streamSymbol)
        {
            string queryString = $"symbol={Uri.EscapeDataString(symbol)}&resolution={Uri.EscapeDataString(resolution)}&from={Uri.EscapeDataString(from)}&to={Uri.EscapeDataString(to)}&countback={Uri.EscapeDataString(countback)}&exc={Uri.EscapeDataString(exc)}&streamSymbol={Uri.EscapeDataString(streamSymbol)}";

            return await Communicator.GetAsync< HistoricalCandleDataResponse>(EndPoints.HistoricalCandleData, queryString);
        }

        

        public static async Task<QuotesResponse> QuotesAsync(QuoteBody body)
        {
            ArgumentNullException.ThrowIfNull(body);

            return await Communicator.PostAsync<QuoteBody, QuotesResponse>(EndPoints.Quote, body);
        }
    }
}
