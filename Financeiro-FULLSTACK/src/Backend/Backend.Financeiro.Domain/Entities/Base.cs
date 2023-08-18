using Backend.Finaceiro.Domain.Entities.Identities.Notifications;

namespace Backend.Financeiro.Domain.Entities
{
    public class Base : Notifier
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
