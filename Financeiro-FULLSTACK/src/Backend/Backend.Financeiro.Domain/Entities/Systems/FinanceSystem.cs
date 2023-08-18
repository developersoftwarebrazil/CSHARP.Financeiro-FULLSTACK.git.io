namespace Backend.Financeiro.Domain.Entities.Systems
{
    public class FinanceSystem : Base
    {
        public int Year { get; set; }
        public int YearCopy { get; set; }
        public int Month { get; set; }
        public int MonthCopy { get; set; }
        public int MonthlyClosingDay { get; set; }
        public bool GenerateTransactionCopy { get; set; }
    }
}
