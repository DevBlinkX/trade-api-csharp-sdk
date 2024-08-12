using TradeApi.Api;
using TradeApi.Model.GetFunds;
using TradeApi.Model.GetProfile;
using TradeApi.Model.Login;

namespace TradeApi.Example
{
    internal class LoginApisExample
    {
        public async Task placeLogin()
        {
            LoginBody body = new()
            {
                UserId = TestData.UserId,
                Password = TestData.Password,
                MobileNumber = TestData.Mobile
            };

            LoginResponse response = await UserApis.LoginUserAsync(body);

            Console.WriteLine("Message received: " + response.InfoId);

        }

        public async Task getProfile()
        {
            GetProfileBody body = new GetProfileBody
            {
                data = new GetProfileBodyData(), // Initialize with an empty object or populate as needed
                appID = "1"
            };
            GetProfileResponse response = await UserApis.GetProfileAsync(body);
            Console.WriteLine("Message received: " + response.ToString);


        }

        public async Task getFunds()
        {
            GetFundsResponse response = await UserApis.GetFundsAsync();

            Console.WriteLine("Message received PositionBookResponse: " + response.infoid);
        }

        /* public async Task placeHoldings()
        {
            HoldingsResponse response = await PortfolioApis.HoldingsAsync();

            Console.WriteLine("Message received placeHoldings: " + response.InfoMsg);
        }

        public async Task tradeDetails()
        {

            TradeDetailsBody body = new()
            {
                OrdId = "240703000000314"
            };


            TradeDetailsResponse response = await OrdersApis.TradeDetailsAsync(body);

            Console.WriteLine("Message received tradeDetails: " + response.Data);
        }*/

        /* public async Task positionBook()
         {
             PositionBookResponse response = await PortfolioApis.PositionBookAsync("net");

             Console.WriteLine("Message received PositionBookResponse: " + response.code);
         }*/

    }

}


