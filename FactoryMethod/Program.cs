using FactoryMethod.Factories;
using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            NotificationSenderDialogWindow dialogWindow = new EmailNotificationSenderDialogWindow();
            INotificationSender sender = dialogWindow.CreateSender();
            sender.Send("Hello World!");
        }
    }
}
