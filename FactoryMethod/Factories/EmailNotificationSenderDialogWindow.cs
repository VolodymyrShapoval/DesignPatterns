using FactoryMethod.Interfaces;
using FactoryMethod.Services;

namespace FactoryMethod.Factories
{
    public class EmailNotificationSenderDialogWindow : NotificationSenderDialogWindow
    {
        public override INotificationSender CreateSender()
        {
            return new EmailNotificationSender();
        }
    }
}
