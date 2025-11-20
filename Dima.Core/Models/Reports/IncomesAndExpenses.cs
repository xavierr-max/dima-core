namespace Dima.Core.Models.Reports;

//representa view que obtem a soma dos valores das despesas e entradas mensalmente, durante o periódo de 1 ano, de um usuario logado
public record IncomesAndExpenses(string UserId, int Month, int Year, decimal Incomes, decimal Expenses);
