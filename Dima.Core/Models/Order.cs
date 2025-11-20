using Dima.Core.Enums;

namespace Dima.Core.Models;

//representa a ordem de compra 
public class Order
{
    public long Id { get; set; }
    
    //recebe um Guid no formato string com os 8 primeiros caracteres
    public string Number { get; set; } = Guid.NewGuid().ToString("N")[..8];

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } =  DateTime.Now;
    
    //numero/id do pedido no gateway(stripe)
    public string? ExternalReference { get; set; }
    
    //salva a url do gateway
    public EPaymentGateway Gateway { get; set; } =  EPaymentGateway.Stripe;

    //pago, cancelado, estornado, aguardando pagamento
    //quando criado um pedido, vem definido como aguardando pagamento
    public EOrderStatus Status { get; set; } = EOrderStatus.WaitingPayment;
    
    //serve para identificacao no banco do Product inserido no pedido
    public long ProductId { get; set; }
    
    //é objeto C# que está contido no pedido
    public Product Product { get; set; } = null!;

    public long? VoucherId { get; set; }
    public Voucher? Voucher { get; set; }
    
    public string UserId { get; set; } =  string.Empty;

    //valor total da ordem
    public decimal Total => Product.Price - (Voucher?.Amount ?? 0);
}