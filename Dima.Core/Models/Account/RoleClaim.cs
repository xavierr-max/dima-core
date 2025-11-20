namespace Dima.Core.Models.Account;

//modelo é usado para estruturar informações de autorização e identidade (Claim).
public class RoleClaim
{
    public string? Issuer { get; set; }
    public string? OriginalIssuer { get; set; }
    public string? Type { get; set; }
    public string? Value { get; set; }
    public string? ValueType { get; set; }
}