namespace Dima.Core;

//Atua como um contêiner de constantes e configurações globais para a aplicação GERAL
public static class Configuration
{
    public const int DefaultStatusCode = 200;
    public const int DefaultPageNumber = 1;
    public const int DefaultPageSize = 25;

    public static string ConnectionString { get; set; } = String.Empty;
    
    public static string BackendUrl { get; set; } = String.Empty;
    
    public static string FrontEndUrl { get; set; } = String.Empty;
}