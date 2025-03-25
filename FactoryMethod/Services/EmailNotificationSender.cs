using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Services
{
    public class EmailNotificationSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"[Email] Sent message: {message}");
        }
    }
}
