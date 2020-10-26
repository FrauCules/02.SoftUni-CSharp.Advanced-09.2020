using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> listVip = new HashSet<string>();
            HashSet<string> listReg = new HashSet<string>();
            HashSet<string> gestVip = new HashSet<string>();
            HashSet<string> gestReg = new HashSet<string>();
            string input;

            while ((input = Console.ReadLine()) != "PARTY")
            {
                char ch = input[0];
                if (char.IsDigit(ch))
                {
                    listVip.Add(input);
                }
                else
                {
                    listReg.Add(input);
                }
            }

            while ((input = Console.ReadLine()) != "END")
            {
                char ch = input[0];
                if (char.IsDigit(ch))
                {
                    listVip.Remove(input);
                }
                else
                {
                    listReg.Remove(input);
                }
            }

            int sum = 0;
            if (listVip.Count > 0)
            {
                sum += listVip.Count;
            }

            if(listReg.Count>0)
            { 
                sum += listReg.Count;
            }
            Console.WriteLine(sum);

            if (listVip.Count > 0)
            {
                foreach (var item in listVip)
                {
                    Console.WriteLine(item);
                }
            }

            if (listReg.Count > 0)
            {
                foreach (var item in listReg)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
