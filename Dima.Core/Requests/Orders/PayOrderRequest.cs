namespace Dima.Core.Requests.Orders;

//realiza o pagamento do pedido
public class PayOrderRequest : Request
{
    public string Number { get; set; } = string.Empty;
    public string ExternalReference { get; set; } = string.Empty;
}