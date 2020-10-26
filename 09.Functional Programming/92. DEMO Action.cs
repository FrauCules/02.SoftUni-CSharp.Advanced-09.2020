using System;

namespace _92._DEMO_Action
{
    class Program
    {
        static void Main(string[] args) // Предава функции като променливи без да връщат резултат
        {
            Action<string> name = LogInfo;
            Action noName = LogInfoNoParameters;

            name("Pesho");
            name("Ivan");
            noName();
        }

        static void LogInfoNoParameters()
        {
            Console.WriteLine($"No parameters");
        }

         static void LogInfo(string name)
        {
            Console.WriteLine($"My name is {name}");
        }
    }
}
