namespace Dima.Core.Models;

//cupom de desconto
public class Voucher
{
    public long Id { get; set; }
    
    //representa um identificacao do cupom
    public string Number { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;
    
    //define se está válido
    public bool IsActive { get; set; }
    public decimal Amount { get; set; }
}