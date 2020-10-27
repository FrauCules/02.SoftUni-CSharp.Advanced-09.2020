using System;

namespace Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = line[0] + " " + line[1];
            string adress = line[2];
            string town = line[3];
            for (int i = 4; i < line.Length; i++)
            {
                town = town + " "+ line[i]; 
            }
            
            Threeuple<string, string, string> personInfo = new Threeuple<string, string,string>(name, adress, town);

            line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            name = line[0];
            int beer = int.Parse(line[1]);
            bool isDrink = false;
            
            if (line[2] == "drunk")
            {
                isDrink = true;
            }

            Threeuple<string, int, bool> nameBeerInfo = new Threeuple<string, int, bool>(name, beer, isDrink);

            line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            name = line[0];
            double accountBalance = double.Parse(line[1]);
            string bankName = line[2];
            Threeuple<string, double, string> bankInfo = new Threeuple<string, double, string>(name, accountBalance, bankName);

            Console.WriteLine(personInfo.ToString());
            Console.WriteLine(nameBeerInfo);
            Console.WriteLine(bankInfo);
        }
    }
}
