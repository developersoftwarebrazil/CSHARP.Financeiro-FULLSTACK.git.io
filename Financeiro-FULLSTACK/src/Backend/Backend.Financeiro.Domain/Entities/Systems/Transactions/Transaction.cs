using Backend.Financeiro.Domain.Entities.Categories;
using Backend.Financeiro.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Financeiro.Domain.Entities.Systems.Transactions
{
    public class Transaction : Base
    {
        public int Year { get; set; }
        public int Month { get; set; }

        public decimal Value { get; set; }

        public TransactioEnum TransactionType { get; set; }

        public DateTime RegistrationDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public DateTime PayDay { get; set; }
        public DateTime DueDate { get; set; }

        public bool Paid { get; set; }
        public bool LateExpense { get; set; }

        [ForeignKey("Category")]
        [Column(Order = 1)]
        public int CategoryId { get; set; }
        public virtual required Category Category { get; set; }
    }
}
