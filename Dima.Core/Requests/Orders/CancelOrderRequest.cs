namespace Dima.Core.Requests.Orders;

//cancela um pedido
public class CancelOrderRequest : Request
{
    public long Id { get; set; }
}