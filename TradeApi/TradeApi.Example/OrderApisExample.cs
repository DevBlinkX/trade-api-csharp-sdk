using TradeApi.Api;
using TradeApi.Model.Brokerage;
using TradeApi.Model.OrderBook;
using TradeApi.Model.OrderDetails;
using TradeApi.Model.OrderHistory;

namespace TradeApi.Example
{
    internal class OrderApisExample
    {
        /*public async Task placeOrder()
        {
            PlaceOrderBody body = new PlaceOrderBody()
            {
                ExcToken = "6364",
                OrdAction = "Buy",
                OrdValidity = "DAY",
                OrdType = "MARKET",
                PrdType = "NORMAL",
                Qty = 5,
                TriggerPrice = 0,
                LimitPrice = 192.55,
                DisQty = 0,
                Instrument = "STK",
                Exc = "NSE",
                LotSize = 0,
                Amo = false,
                Build = "MOB",
                BoStpLoss = 0,
                BoTgtPrice = 0,
                TrailingSL = 0
            };

            PlaceOrderResponse response = await OrdersApis.PlaceOrderAsync(body);
            Console.WriteLine("Message received: " + response.ToString());
*/
        /*public async Task modifyOrder()
        {
            ModifyOrderBody body = new ModifyOrderBody()
           
            {
                TriggerPrice = 0,
                OrdType = "MARKET",
                PrdType = "CASH",
                Instrument = "STK",
                Exc = "NSE",
                Qty = 1,
                LotSize = 0,
                Symbol = "NATIONALUM-EQ",
                OrdId = "240710000000030",
                OrdAction = "BUY",
                LimitPrice = 192.55,
                DisQty = 0,
                OrdValidity = "DAY",
                TradedQty = 0,
                OrdValidityDays = 0,
                ExchangeToken = "13528",
                Amo = true
            };

            ModifyOrderResponse response = await OrdersApis.ModifyOrderAsync(body);
            Console.WriteLine("Message received: " + response.ToString());



    }*/

        /*public async Task cancelOrder()
        {
            CancelOrderBody body = new CancelOrderBody()

            {
                
                Symbol = "NATIONALUM-EQ",
                OrdId = "240710000000030",
                Exc = "NSE",
               
            };

            CancelOrderResponse response = await OrdersApis.CancelOrderAsync(body);
            Console.WriteLine("Message received: " + response.ToString());



        }*/

        /*public async Task exitOrder()
        {
            ExitOrderBody body = new ExitOrderBody()

            {

                Symbol = "HDFCBANK-EQ",
                Exc = "NSE",
                PrdType = "NRML",
                BoOrdStatus = "Trade Confirmed",
                ParOrdId = "240703000000313",
                OrdId = "240703000000313"

            };

            ExitOrderResponse response = await OrdersApis.ExitOrderAsync(body);
            Console.WriteLine("Message received: " + response.ToString());



        }*/

        /*public async Task tradeOrder()
        {
            TradeBookResponse response = new TradeBookResponse();
            Console.WriteLine("Message received: " + response.ToString());
        }*/

        public async Task orderBook()
        {
            OrderBookResponse response = new OrderBookResponse();
            Console.WriteLine("Message received: " + response.ToString());
        }

        public async Task orderDetails()
        {
            OrderDetailsBody body = new OrderDetailsBody()

            {
                OrdId = "240710000000030"

            };

            OrderDetailsResponse response = await OrdersApis.OrderDetailsAsync(body);
            Console.WriteLine("Message received: " + response.Message);

        }

        public async Task orderHistory()
        {
            OrderHistoryBody body = new OrderHistoryBody()

            {

                OrdId = "240703000000313"

            };

            OrderHistoryResponse response = await OrdersApis.OrderHistoryAsync(body);
            Console.WriteLine("Message received: " + response.ToString());

        }

        public async Task brokerage()
        {
            BrokerageBody body = new BrokerageBody()

            {

                Symbol = "ACC-EQ",
                Exc = "NSE",
                Product = "NRML",
                TriggerPrice = "",  // Assuming this is allowed to be an empty string
                Price = "3000",
                Qty = "100",
                Instrument = "",  // Assuming this is allowed to be an empty string
                OrderAction = "BUY",
                ExcToken = "25"

            };

            BrokerageResponse response = await MarketDataApis.BrokerageAsync(body);
            Console.WriteLine("Message received: " + response.InfoMsg);

        }

    }
}
