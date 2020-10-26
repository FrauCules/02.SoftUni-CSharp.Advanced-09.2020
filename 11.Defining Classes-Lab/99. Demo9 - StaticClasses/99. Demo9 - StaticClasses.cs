using System;

namespace _99._Demo9___StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            BankHelpers.Name = "Pesho Bank";
            BankHelpers.CalculateDebt(55);

            Math.Max(6, 9); // класа Math е статичен и се вика без инстанция
            
            Hello1(); // когато Методът Hello1 е статичен - можем да го викаме без инстанция

            Program program = new Program(); // когато Методът Hello2 не е статичен - първо му правим инстанция, после го викаме
            program.Hello2();

            Account accoint1 = new Account(); 
            accoint1.Balance = 5000;
            Account account2 = new Account();
            account2.Balance = 3500;
            Account.Tax = 300;                // сетваме колко е таксата за всички
            accoint1.PayTax();                // удържаме таксата от първата инстанция
            account2.PayTax();                // удържаме таксата от втората инстанция

            Console.WriteLine(BankHelpers.Name);
        }

        static void Hello1() {Console.WriteLine("Hello 1");}

        void Hello2() {Console.WriteLine("Hello 2");}
    }
}
