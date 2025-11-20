namespace Dima.Core.Requests.Transaction;

public class DeleteTransactionRequest : Request
{
    public long CategoryId { get; set; }
    public long Id { get; set; }
}