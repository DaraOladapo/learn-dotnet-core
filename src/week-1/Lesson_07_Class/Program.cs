using System;

namespace Lesson_7_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass _MyClass=new MyClass();
            _MyClass.MyInteger=23;
            Console.WriteLine(_MyClass.MyInteger);
        }
    }
    class MyClass
    {
      public int MyInteger { get; set; }       
    }
}
