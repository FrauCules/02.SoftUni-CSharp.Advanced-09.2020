using System;

namespace _99._Demo2_Students_Field
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "Pesho";
            student.age = 50;
            Console.WriteLine(student.name +"=>" +student.age);
        }
    }
}
