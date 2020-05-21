using System;

namespace Lesson_10_Interfaces
{
    class Program:IMyInterface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public void MyInterfaceMethod(){

        }
    }
    public interface IMyInterface
    {
        public void MyInterfaceMethod();
    }
}
