using System;
using System.Collections.Generic;
using System.Text;

namespace _99._Demo9___StaticClasses
{
    static class BankHelpers
    {
        public static string Name { get; set; }

        public static void CalculateDebt(double income)
        {
            Console.WriteLine("Mnogo");
        }

        public static void GetBankName()
        {
            Console.WriteLine(Name);
        }
    }
}
