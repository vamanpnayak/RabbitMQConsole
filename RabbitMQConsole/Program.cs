using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyNetQ;
using Messages;

namespace RabbitMQConsole
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    using (var bus = RabbitHutch.CreateBus("host=localhost"))
        //    {
        //        var input = "";
        //        Console.WriteLine("Enter a message 'quit' to close");
        //        while ((input = Console.ReadLine()) != "quit")
        //        {
        //            bus.Publish(new MyMessage{ Text = input});
        //        }
        //    }
        //}

        static void Main(string[] args)
        {
            
            using (var bus = RabbitHutch.CreateBus("host=spotted-monkey.rmq.cloudamqp.com;virtualHost=xswwhewh;username=xswwhewh;password="))
            {
                var input = "";
                Console.WriteLine("Enter a message 'quit' to close");
                
                while ((input = Console.ReadLine()) != "quit")
                {
                    bus.Publish(input);
                }
            }
        }
    }
}
