using FactoryMethod.Interfaces;

namespace FactoryMethod.Factories
{
    public abstract class NotificationSenderDialogWindow
    {
        public abstract INotificationSender CreateSender();
    }
}
