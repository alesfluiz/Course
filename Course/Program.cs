using Course.Entities;
using Course.Entities.Enums;
using System;

namespace Course
{
    internal class Program
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