using TradeApi.Api.Base;
using TradeApi.Constants;
using TradeApi.Model.ConvertPosition;
using TradeApi.Model.Holdings;
using TradeApi.Model.PositionBook;
using TradeApi.Model.Report;

namespace TradeApi.Api
{
    public class PortfolioApis
    {

        public static async Task<ConvertPositionResponse> ConvertPositionAsync(ConvertPositionBody body)
        {
            ArgumentNullException.ThrowIfNull(body);

            return await Communicator.PostAsync<ConvertPositionBody, ConvertPositionResponse>(EndPoints.ConvertPosition, body);
        }

        public static async Task<HoldingsResponse> HoldingsAsync()
        {
            return await Communicator.GetAsync<HoldingsResponse>(EndPoints.Holdings);
        }

        public static async Task<ReportResponse> ReportAsync(ReportBody body)
        {
            ArgumentNullException.ThrowIfNull(body);

            return await Communicator.PostAsync<ReportBody, ReportResponse>(EndPoints.Report, body);
        }

        public static async Task<PositionBookResponse> PositionBookAsync(String type)
        {
            
            return await Communicator.GetAsync<PositionBookResponse>(EndPoints.PositionBook, type);
        }
    }
}
