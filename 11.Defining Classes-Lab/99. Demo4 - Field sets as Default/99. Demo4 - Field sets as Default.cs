using System;

namespace _99._Demo4___Field_sets_as_Default
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //student.Name = "Ivan"; - ако го разкоментирам това име ще стане по подразбиране
            Console.WriteLine(student.Name);
        }
    }
}
