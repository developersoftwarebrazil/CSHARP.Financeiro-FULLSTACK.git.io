using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Finaceiro.Domain.Entities.Identities.Notifications
{
    public class Notifier
    {
        public Notifier()
        {
            Notification = new List<Notifier>();
        }

        [NotMapped]
        public String PropertyName { get; set; }

        [NotMapped]
        public String Message { get; set; }

        [NotMapped]
        public List<Notifier> Notification { get; set; }

        public bool ValidatePropertyString(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propertyName))
            {
                Notification.Add(new Notifier()
                {
                    Message = "Campo obrigátório",
                    PropertyName = propertyName
                }
                );
                return false;
            }
            return true;
        }

        public bool ValidatePropertyInt(int value, string propertyName)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(propertyName))
            {
                Notification.Add(new Notifier()
                {
                    Message = "Campo obrigátório",
                    PropertyName = propertyName
                }
                );
                return false;
            }
            return true;
        }

        public bool ValidatePropertyDecimal(decimal value, string propertyName)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(propertyName))
            {
                Notification.Add(new Notifier()
                {
                    Message = "Campo obrigátório",
                    PropertyName = propertyName
                }
                );
                return false;
            }
            return true;
        }
    }
}
