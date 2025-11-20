namespace Dima.Core.Common.Extensions;

public static class DateTimeExtension
{
    //método de extensao que pode ou nao receber no parametro um ano e um mes. E retona o primeiro dia desse mes
    public static DateTime GetFirstDay(this DateTime date, int? year = null, int? month = null)
    //retorna o ano e o mes recebidos no parametro, ou, retorna nulo o que nao for preenchido
        => new (year ?? date.Year,  month ?? date.Month, 1);
    
    //método de extensao que pode ou nao receber no parametro um ano e um mes. E retona o ultimo dia desse mes
    public static DateTime GetLastDay(this DateTime date, int? year = null, int? month = null)
    => new DateTime (year ?? date.Year, month ?? date.Month, 1)
        .AddMonths(1)
        .AddDays(-1);
}