using TradeApi.Api;
using TradeApi.Model.Brokerage;
using TradeApi.Model.OrderBook;
using TradeApi.Model.OrderDetails;
using TradeApi.Model.OrderHistory;
using TradeApi.Model.TradeBook;
using Newtonsoft.Json;

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



        }
*/
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

        public async Task tradeOrder()
        {
            TradeBookResponse response = new TradeBookResponse();
            string formattedResponse = JsonConvert.SerializeObject(response, Formatting.Indented);

            Console.WriteLine("Message received: " + formattedResponse);
        }

        public async Task orderBook()
        {
            try
            {
                // Call the API to get the order book
                OrderBookResponse response = await OrdersApis.OrderBookAsync();

                if (response != null)
                {
                    // Serialize the full response to JSON with indentation
                    string jsonResponse = JsonConvert.SerializeObject(response, Formatting.Indented);
                    Console.WriteLine("Full Response:");
                    Console.WriteLine(jsonResponse);
                }
                else
                {
                    Console.WriteLine("Failed to retrieve order book.");
                }
            }
            catch (Exception ex)
            {
                // Log or handle errors gracefully
                Console.WriteLine("An error occurred while fetching the order book:");
                Console.WriteLine(ex.Message);
            }
        }




        public async Task OrderDetails()
        {
            try
            {
                // Create the request body
                OrderDetailsBody body = new OrderDetailsBody
                {
                    OrdId = "240710000000030"
                };

                // Fetch the response from the API
                OrderDetailsResponse response = await OrdersApis.OrderDetailsAsync(body);

                if (response != null)
                {
                    // Serialize the response to a JSON string with indentation
                    string jsonResponse = JsonConvert.SerializeObject(response, Formatting.Indented);

                    // Print the entire JSON response to the console
                    Console.WriteLine("Order Details Response:");
                    Console.WriteLine(jsonResponse);
                }
                else
                {
                    Console.WriteLine("Failed to retrieve order details.");
                }
            }
            catch (Exception ex)
            {
                // Handle and log any errors
                Console.WriteLine("An error occurred while fetching order details:");
                Console.WriteLine(ex.Message);
            }
        }


     
    public async Task OrderHistory()
    {
        OrderHistoryBody body = new OrderHistoryBody
        {
            OrdId = "240703000000313"
        };

        // Call the API and get the response
        OrderHistoryResponse response = await OrdersApis.OrderHistoryAsync(body);

        // Convert the response object to a formatted JSON string
        string formattedResponse = JsonConvert.SerializeObject(response, Formatting.Indented);

        // Print the formatted JSON string to the console
        Console.WriteLine("Message received: " + formattedResponse);
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
            string formattedResponse = JsonConvert.SerializeObject(response, Formatting.Indented);

            Console.WriteLine("Message received: " + formattedResponse);

        }

    }
}
