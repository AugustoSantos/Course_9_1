using System;
using Course_9_1.Entities;
using Course_9_1.Entities.Enums;

namespace Course_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

        }
    }
}
