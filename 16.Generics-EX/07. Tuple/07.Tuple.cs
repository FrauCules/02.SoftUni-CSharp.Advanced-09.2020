using System;

namespace Tuple
{
    public class Program
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Split();
            string name = line[0] + " " + line[1];
            
            Tuple<string, string> personInfo = new Tuple<string, string>(name, line[2]);

            line = Console.ReadLine().Split();
            name = line[0];
            int beer = int.Parse(line[1]);
            Tuple<string, int> nameBeerInfo = new Tuple<string, int>(name, beer);

            line = Console.ReadLine().Split();
            int num1 = int.Parse(line[0]);
            double num2 = double.Parse(line[1]);
            Tuple<int, double> numbersInfo = new Tuple<int, double>(num1, num2);

            Console.WriteLine(personInfo);
            Console.WriteLine(nameBeerInfo);
            Console.WriteLine(numbersInfo);
        }
    }
}
