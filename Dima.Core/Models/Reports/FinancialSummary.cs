namespace Dima.Core.Models.Reports;

//representa o sumário financeiro de um usuario (calcula a diferenca de entrada e saida para o mes)
public record FinancialSummary(string UserId, decimal Incomes, decimal Expenses)
{
    //calcula o resultado total da soma das entradas e despesas
    //força a despesa sempre vir com o intuito de subtrair
    public decimal Total => Incomes - (Expenses < 0 ? -Expenses : Expenses);
}
