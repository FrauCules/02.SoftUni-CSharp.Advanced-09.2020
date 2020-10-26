using System;

namespace _99._Demo3_Students_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Student peshoStudent = new Student();
            peshoStudent.Name = "Pesho";
            peshoStudent.Age = 22;
            Console.WriteLine(peshoStudent.Name+"/"+peshoStudent.Age);
        }
    }
}
