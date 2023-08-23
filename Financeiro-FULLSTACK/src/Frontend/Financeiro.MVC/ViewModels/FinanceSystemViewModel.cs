using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Financeiro.MVC.ViewModels
{
    public class FinanceSystemViewModel
    {
        [Required(ErrorMessage ="Este campo precisa ser preenchido")]
        [DisplayName("Ano")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        [DisplayName("Ano Cópia")]
        public int YearCopy { get; set; }

        [Required(ErrorMessage = "Este campo precisa ser preenchido")]
        [DisplayName("Mês")]
        public int Month { get; set; }

        
        [Required(ErrorMessage ="Este campo precisa ser preenchido")]
        [DisplayName("Mês Cópia")]
        public int MonthCopy { get; set; }

        [Required(ErrorMessage ="Este campo precisa ser preenchido")]
        [DisplayName("Dia de fechamento")]
        public int MonthlyClosingDay { get; set; }

        [DisplayName("Gerar Cópia")]
        public bool GenerateTransactionCopy { get; set; }
    }
}
