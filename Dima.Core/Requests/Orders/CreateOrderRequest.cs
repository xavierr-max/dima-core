namespace Dima.Core.Requests.Orders;

//cria um pedido
public class CreateOrderRequest :  Request
{
    public long ProductId { get; set; }
    public long? VoucherId { get; set; }
}