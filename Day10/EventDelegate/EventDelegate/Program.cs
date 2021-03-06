using System;

namespace EventDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager();
            Message m1message = new Message
            {
                Address = "abc",
                Content = "this is great message"
            };
            Manager.sendMessageDelegate md = SendTypes.SendByCar;
            m1.RequestDelivery(m1message, md);
            Agent a = new Agent();

            //a.notificationChanged += new Agent.NotificationHandler((a, e) => {
            //    Console.WriteLine(e.status);
            //});
            a.notificationChanged += new Agent.NotificationHandler(ShowNotification);
        }
        public static void ShowNotification(object theClock, NotificationEventArgs e)
        {
            Console.WriteLine(e.status);
        }
    }
}
