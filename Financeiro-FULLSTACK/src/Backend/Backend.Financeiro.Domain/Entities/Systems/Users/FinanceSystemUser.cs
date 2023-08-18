using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Financeiro.Domain.Entities.Systems.Users
{
    public class FinanceSystemUser
    {
        public int Id { get; set; }
        public required string UserEmail { get; set; }

        public bool Admin { get; set; }
        public bool ActualSystem { get; set; }

        [ForeignKey("FinanceSystem")]
        [Column(Order = 1)]
        public int SystemId { get; set; }
        public virtual required FinanceSystem System { get; set; }
    }
}
