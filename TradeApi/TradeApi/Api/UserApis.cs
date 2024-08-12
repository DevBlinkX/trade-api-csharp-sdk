using TradeApi.Api.Base;
using TradeApi.Constants;
using TradeApi.Model.GetFunds;
using TradeApi.Model.GetProfile;
using TradeApi.Model.Login;
using TradeApi.Model.Logout;

namespace TradeApi.Api
{
    public class UserApis
    {

        public static async Task<LoginResponse> LoginUserAsync(LoginBody body)
        {
            ArgumentNullException.ThrowIfNull(body);

            LoginResponse response = await Communicator.PostAsync<LoginBody, LoginResponse>(EndPoints.Login, body, ignoreAuthToken: true);
            if (response.InfoId == "0")
            {
                Core.Configuration.AuthToken = response.Data.AccessToken;
            }

            return response;
        }

        public static async Task<LogoutResponse> LogoutUserAsync()
        {
            return await Communicator.GetAsync<LogoutResponse>(EndPoints.Logout);
        }

        public static async Task<GetProfileResponse> GetProfileAsync(GetProfileBody body)
        {
            ArgumentNullException.ThrowIfNull(body);

            return await Communicator.PostAsync<GetProfileBody, GetProfileResponse>(EndPoints.GetProfile, body);
        }

        public static async Task<GetFundsResponse> GetFundsAsync()
        {
           
            return await Communicator.GetAsync<GetFundsResponse>(EndPoints.GetFunds);
        }

    }
}
