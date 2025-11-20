namespace Dima.Core.Requests;

//faz com que os requests que herdam dessa classe precisem passar o usuario
public abstract class Request
{
    public string UserId { get; set; } = string.Empty;
}