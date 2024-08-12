
using TradeApi;
using TradeApi.Example;

// Core.Initialize should be done only once in the app lifecycle. 
// No need to initialize everytime an api is called.
Core.Initialize(TestData.ApiKey, TestData.Baseurl);

Console.WriteLine("Placing Login Api");

await (new LoginApisExample()).placeLogin();

/*Console.WriteLine("Placing convertposition Api");

await (new PortfolioExampleApis()).convertPosition();

Console.WriteLine("Placing report Api");

await (new PortfolioExampleApis()).report();

Console.WriteLine("Placing ohlc Api");

await (new PortfolioExampleApis()).getOhlc();

Console.WriteLine("Placing intraday Api");

await (new PortfolioExampleApis()).intraday();

Console.WriteLine("Placing historical Api");

await (new PortfolioExampleApis()).historical();

Console.WriteLine("Placing quote Api");

await (new PortfolioExampleApis()).quote();
*/
Console.WriteLine("Placing orderbook Api");

await (new OrderApisExample()).orderBook();

Console.WriteLine("Placing orderdetails Api");

await (new OrderApisExample()).orderDetails();

/*Console.WriteLine("Placing orderhistory Api");

await (new OrderApisExample()).orderHistory();*/

Console.WriteLine("Placing brokerage Api");

await (new OrderApisExample()).brokerage();

/*Console.WriteLine("Placing cancelorder Api");

await (new OrderApisExample()).cancelOrder();*/

/*Console.WriteLine("Placing exitorder Api");

await (new OrderApisExample()).exitOrder();*/

/*Console.WriteLine("Placing tradeorder Api");

await (new OrderApisExample()).tradeOrder();
*/
/*Console.WriteLine("Placing modifyorder Api");

await (new OrderApisExample()).modifyOrder();*/

/*Console.WriteLine("Placing placeorder Api");

await (new OrderApisExample()).placeOrder();*/

Console.WriteLine("Placing GetFunds Api");

await (new LoginApisExample()).getFunds();

/*Console.WriteLine("Get Profile Api");
await (new LoginApisExample()).getProfile();*/

/*await (new HoldingsApisExample()).tradeDetails();

Console.WriteLine("Placing Holdings Api");*/

/*await (new HoldingsApisExample()).placeHoldings();

Console.WriteLine("TradeDetails Api");

await (new HoldingsApisExample()).tradeDetails();

Console.WriteLine("position book Api");

await (new HoldingsApisExample()).tradeDetails();

*/

