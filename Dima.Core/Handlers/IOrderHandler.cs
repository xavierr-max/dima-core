using Dima.Core.Models;
using Dima.Core.Requests.Orders;
using Dima.Core.Responses;

namespace Dima.Core.Handlers;

//operacoes com Order
public interface IOrderHandler
{
    Task<Response<Order?>> CancelAsync(CancelOrderRequest request);
    Task<Response<Order?>> CreateAsync(CreateOrderRequest request);
    Task<Response<Order?>> PaysAsync(PayOrderRequest request);
    Task<Response<Order?>> RefundAsync(RefundOrderRequest request);
    Task<PagedResponse<List<Order>?>> GetAllAsync(GetAllOrdersRequest request);
    Task<Response<Order?>> GetByNumberAsync(GetOrderByNumberRequest request);
}