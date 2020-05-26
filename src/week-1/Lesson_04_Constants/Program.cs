using System;

namespace Lesson_4_Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MyConstantInteger=45;
            Console.WriteLine($"{MyConstantInteger} is a constant value");
            //MyConstantInteger=45;would not work
        }
    }
}
