using Backend.Financeiro.Domain.Entities.Categories;
using Backend.Financeiro.Domain.Entities.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financeiro.MVC.ViewModels
{
    public class TransactionViewModel
    {
        [DisplayName("Ano")]
        public int Year { get; set; }

        [DisplayName("Mês")]
        public int Month { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0", "999999999999")]
        [Required(ErrorMessage ="Preencha este campo com um valor válido!")]
        [DisplayName("Valor")]
        public decimal Value { get; set; }

        [DisplayName("Tipo de Transação")]
        public TransactioEnum TransactionType { get; set; }

        [DisplayName("Data Cadastro")]
        public DateTime RegistrationDate { get; set; }

        [DisplayName("Data Alteração")]
        public DateTime ChangeDate { get; set; }

        [DisplayName("Data Pagamento")]
        public DateTime PayDay { get; set; }

        [DisplayName("Data do vencimento")]
        public DateTime DueDate { get; set; }

        [DisplayName("Pago?")]
        public bool Paid { get; set; }

        [DisplayName("Em Atrazo")]
        public bool LateExpense { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
