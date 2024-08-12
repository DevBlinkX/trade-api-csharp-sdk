using TradeApi.Api.Base;
using TradeApi.Constants;
using TradeApi.Model.CancelOrder;
using TradeApi.Model.ExitOrder;
using TradeApi.Model.ModifyOrder;
using TradeApi.Model.OrderBook;
using TradeApi.Model.OrderDetails;
using TradeApi.Model.OrderHistory;
using TradeApi.Model.PlaceOrder;
using TradeApi.Model.TradeBook;
using TradeApi.Model.TradeDetails;

namespace TradeApi.Api
{
    public class OrdersApis
    {
        public static async Task<PlaceOrderResponse> PlaceOrderAsync(PlaceOrderBody body)
        {
            ArgumentNullException.ThrowIfNull(body);

            return await Communicator.PostAsync<PlaceOrderBody, PlaceOrderResponse>(EndPoints.PlaceOrder, body);
        }

        public static async Task<ModifyOrderResponse> ModifyOrderAsync(ModifyOrderBody body)
        {
            ArgumentNullException.ThrowIfNull(body);

            return await Communicator.PostAsync<ModifyOrderBody, ModifyOrderResponse>(EndPoints.ModifyOrder, body);
        }

        public static async Task<ExitOrderResponse> ExitOrderAsync(ExitOrderBody body)
        {
            ArgumentNullException.ThrowIfNull(body);

            return await Communicator.PostAsync<ExitOrderBody, ExitOrderResponse>(EndPoints.ExitOrder, body);
        }

        public static async Task<CancelOrderResponse> CancelOrderAsync(CancelOrderBody body)
        {
            ArgumentNullException.ThrowIfNull(body);

            return await Communicator.PostAsync<CancelOrderBody, CancelOrderResponse>(EndPoints.CancelOrder, body);
        }

       

        public static async Task<TradeDetailsResponse> TradeDetailsAsync(TradeDetailsBody body)
        {
            ArgumentNullException.ThrowIfNull(body);

            return await Communicator.PostAsync<TradeDetailsBody, TradeDetailsResponse>(EndPoints.TradeDetails, body);
        }

        public static async Task<OrderHistoryResponse> OrderHistoryAsync(OrderHistoryBody body)
        {
            ArgumentNullException.ThrowIfNull(body);

            return await Communicator.PostAsync<OrderHistoryBody, OrderHistoryResponse>(EndPoints.orderHistory, body);
        }

        public static async Task<OrderDetailsResponse> OrderDetailsAsync(OrderDetailsBody body)
        {
            ArgumentNullException.ThrowIfNull(body);

            return await Communicator.PostAsync<OrderDetailsBody, OrderDetailsResponse>(EndPoints.OrderDetails, body);
        }

        public static async Task<TradeBookResponse> TradeBookAsync()
        {

            return await Communicator.GetAsync<TradeBookResponse>(EndPoints.TradeBook);
        }

        public static async Task<OrderBookResponse> OrderBookAsync()
        {
            return await Communicator.GetAsync<OrderBookResponse>(EndPoints.OrderBook);
        }
    }
}

