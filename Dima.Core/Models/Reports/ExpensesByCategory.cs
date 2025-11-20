namespace Dima.Core.Models.Reports;

//representa a view que soma as despesas de uma categoria durante 1 ano de um usuario logado
public record ExpensesByCategory(string UserId, string Category, int Year, decimal Expenses);
