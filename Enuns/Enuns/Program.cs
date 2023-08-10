using System;
using Enuns.Entities;
using Enuns.Entities.Enumeracoers;

namespace Enuns
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { Id = 01, Moment = DateTime.Now, Status = OrderStatus.PendingPayment };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);

        }
    }
}