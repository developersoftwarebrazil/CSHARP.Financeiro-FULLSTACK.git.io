using Backend.Financeiro.Domain.Entities.Systems;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financeiro.MVC.ViewModels
{
    public class FinanceSystemUserViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Este campo precisa ser preenchido!")]
        [EmailAddress(ErrorMessage = "Preencha com um e-mail válido!")]
        [DisplayName("E-mail")]
        public required string UserEmail { get; set; }

        public bool Admin { get; set; }
        public bool ActualSystem { get; set; }

      
        public int SystemId { get; set; }
        public virtual FinanceSystemViewModel System { get; set; }
    }
}
