using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyNetQ;
using Messages;

namespace RabbitMQConsoleSubscriber
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    using (var bus = RabbitHutch.CreateBus("host=localhost"))
        //    {
        //        bus.Subscribe<MyMessage>("Test", HandleTextMessage);
        //        Console.WriteLine("Listening for messages. Hit <return> to quit.");
        //        Console.ReadLine();
        //    }
        //}

        //static void HandleTextMessage(MyMessage textMessage)
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("Got message: {0}", textMessage.Text);
        //    Console.ResetColor();
        //}

        static void Main(string[] args)
        {
            using (var bus = RabbitHutch.CreateBus("host=spotted-monkey.rmq.cloudamqp.com;virtualHost=xswwhewh;username=xswwhewh;password="))
            {
                bus.Subscribe<string>("Test", HandleTextMessage);
                Console.WriteLine("Listening for messages. Hit <return> to quit.");
                Console.ReadLine();
            }
        }
        static void HandleTextMessage(string textMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Got message: {0}", textMessage);
            Console.ResetColor();
        }
    }
}
