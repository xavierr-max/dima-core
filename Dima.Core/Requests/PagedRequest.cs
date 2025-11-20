namespace Dima.Core.Requests;

public abstract class PagedRequest : Request
{
    //número da página 
    public int PageNumber { get; set; } = Configuration.DefaultPageNumber; //1
    
    //número de elementos na página
    public int PageSize { get; set; } = Configuration.DefaultPageSize; //25
}