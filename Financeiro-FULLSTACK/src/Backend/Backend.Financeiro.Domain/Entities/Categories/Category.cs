using Backend.Financeiro.Domain.Entities.Systems;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Financeiro.Domain.Entities.Categories
{
    public class Category : Base
    {
        [ForeignKey("FinanceSystem")]
        public int SystemId { get; set; }

        [Column(Order = 1)]
        public virtual required FinanceSystem FinanceSystems { get; set; }
    }
}
