using System;

namespace _99._Demo8___Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment payment = Payment.Bank;
            Console.WriteLine(payment);
            DoPayment(Payment.Terminal);

            Console.WriteLine($"Cash: {(int)Payment.Cash}");
            Console.WriteLine($"GoToCanada: {(int)Payment.GoToCanada}");
            Console.WriteLine($"4: {(Payment)4}");

            for (int i = 51; i < 51+15; i++)
            {
                Console.WriteLine($"{i}: {(Payment)i}");
            }
        }

        static void DoPayment(Payment type)
        {
            if(type == Payment.Cash)
            {
                Console.WriteLine("Take all the money");
            }

            else if (type == Payment.GoToCanada)
            {
                Console.WriteLine("Forget the money");
            }
            else
            {
                Console.WriteLine(type);
            }
        }
    }
}
