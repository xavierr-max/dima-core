namespace Dima.Core.Models.Reports;

//representa a view que soma as entradas de uma categoria durante 1 ano de um usuario logado
public record IncomesByCategory(string UserId, string Category, int Year, decimal Incomes);
