namespace Dima.Core.Enums;

//representa o status do pedido
public enum EOrderStatus
{
    WaitingPayment = 1,
    Paid = 2,
    Canceled = 3,
    Refunded = 4, //Extornado
}