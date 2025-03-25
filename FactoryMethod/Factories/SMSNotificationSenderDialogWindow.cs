using FactoryMethod.Interfaces;
using FactoryMethod.Services;

namespace FactoryMethod.Factories
{
    public class SMSNotificationSenderDialogWindow : NotificationSenderDialogWindow
    {
        public override INotificationSender CreateSender()
        {
            return new SMSNotificationSender();
        }
    }
}
