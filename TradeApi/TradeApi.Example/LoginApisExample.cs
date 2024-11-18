using TradeApi.Api;
using TradeApi.Model.GetFunds;
using TradeApi.Model.GetProfile;
using TradeApi.Model.Login;
using TradeApi.Model.TradeDetails;

using Newtonsoft.Json;

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

            Console.WriteLine("Message received11111111: " + response.Data);

        }

        public async Task GetProfile()
        {
            GetProfileBody body = new GetProfileBody
            {
                data = new GetProfileBodyData(),
                appID = "acb372f3621e4c6ca6473b2b65a3d806"
            };

            // Assuming GetProfileAsync is the method making the API call
            GetProfileResponse response = await UserApis.GetProfileAsync(body);

            // Serialize the response to JSON string
            string jsonResponse = JsonConvert.SerializeObject(response, Formatting.Indented);

            // Print the formatted response
            Console.WriteLine("Profile Response: " + jsonResponse);
        }

        public async Task getFunds()
        {
            try
            {
                // Call the API to get the funds response
                GetFundsResponse response = await UserApis.GetFundsAsync();

                if (response != null)
                {
                    // Serialize the full response to JSON with indentation
                    string jsonResponse = JsonConvert.SerializeObject(response, Formatting.Indented);

                    // Print the entire response to the console
                    Console.WriteLine("Full Response:");
                    Console.WriteLine(jsonResponse);
                }
                else
                {
                    Console.WriteLine("Failed to retrieve funds information.");
                }
            }
            catch (Exception ex)
            {
                // Log or handle any errors
                Console.WriteLine("An error occurred while fetching funds data:");
                Console.WriteLine(ex.Message);
            }
        }


        /* public async Task placeHoldings()
        {
            HoldingsResponse response = await PortfolioApis.HoldingsAsync();

            Console.WriteLine("Message received placeHoldings: " + response.InfoMsg);
        }*/



        public async Task TradeDetails()
        {
            try
            {
                // Create the request body
                TradeDetailsBody body = new TradeDetailsBody
                {
                    OrdId = "240703000000314"
                };

                // Call the API to get the trade details response
                TradeDetailsResponse response = await OrdersApis.TradeDetailsAsync(body);

                if (response != null)
                {
                    // Serialize the full response to JSON with indentation
                    string jsonResponse = JsonConvert.SerializeObject(response, Formatting.Indented);

                    // Print the entire response to the console
                    Console.WriteLine("Full Response:");
                    Console.WriteLine(jsonResponse);
                }
                else
                {
                    Console.WriteLine("Failed to retrieve trade details.");
                }
            }
            catch (Exception ex)
            {
                // Log or handle any errors
                Console.WriteLine("An error occurred while fetching trade details:");
                Console.WriteLine(ex.Message);

                // Optionally, log the stack trace for deeper debugging
                Console.WriteLine(ex.StackTrace);
            }
        }


        /* public async Task positionBook()
         {
             PositionBookResponse response = await PortfolioApis.PositionBookAsync("net");

             Console.WriteLine("Message received PositionBookResponse: " + response.code);
         }*/

    }

}


