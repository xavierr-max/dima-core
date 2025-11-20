using System.ComponentModel.DataAnnotations;

//modelo de como os dados serao aceitos pela API
namespace Dima.Core.Requests.Account;

public class LoginRequest : Request
{
    [Required(ErrorMessage = "E-mail")]
    [EmailAddress(ErrorMessage = "E-mail inválido")]
    public string Email { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Senha inválida")]
    public string Password { get; set; } = string.Empty;
}