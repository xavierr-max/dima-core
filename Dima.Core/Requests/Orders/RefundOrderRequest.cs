namespace Dima.Core.Requests.Orders;

//serve quando o pedido já foi pago e o client deseja cancelar
public class RefundOrderRequest : Request
{
    public long Id { get; set; }
}