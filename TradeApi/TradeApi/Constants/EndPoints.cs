using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeApi.Constants
{
    internal class EndPoints
    {
        //userapis
        public const string Login = "/auth-services/api/auth/v1/login";
        public const string Logout = "/auth-services/api/auth/v1/logout";
        public const string GetProfile = "/wrapper-details-service/api/user/v1/getProfile";
        public const string GetFunds = "/wrapper-details-service/api/funds/v1/get-funds";

        //orderapis
        public const string PlaceOrder = "/wrapper-order-service/api/order/v1/place-order";
        public const string ModifyOrder = "/wrapper-order-service/api/order/v1/modify-order";
        public const string ExitOrder = "/wrapper-order-service/api/order/v1/exit-order";
        public const string CancelOrder = "/wrapper-order-service/api/order/v1/cancel-order";
        public const string TradeDetails = "/wrapper-details-service/api/order/v1/trade-details";
        public const string orderHistory = "/wrapper-details-service/api/order/v1/order-history";
        public const string OrderDetails = "/wrapper-details-service/api/order/v1/order-details";
        public const string TradeBook = "/wrapper-details-service/api/order/v1/trade-book";
        public const string OrderBook = "/wrapper-details-service/api/order/v1/order-book";
        public const string Brokerage = "/wrapper-details-service/api/trade/v1/brokerage";

        //portfolioapis
        public const string Holdings = "/wrapper-details-service/api/portfolio/v1/holdings";
        public const string Report = "/wrapper-details-service/api/trade/v1/profit-loss-report";
        public const string ConvertPosition = "/wrapper-order-service/api/portfolio/v1/convert-positions";
        public const string PositionBook = "/wrapper-details-service/api/portfolio/v1/position-book";

        //MarketDataapis

        public const string GetOHLC = "/wrapper-details-service/api/quote/v1/get-ohlc";
        public const string IntradayCandleData = "/wrapper-details-service/api/chart/v1/intraday-candle-data";
        public const string HistoricalCandleData = "/wrapper-details-service/api/chart/v1/historical-candle-data";
        public const string Quote = "/wrapper-details-service/api/market/v1/quote";




    }
}
