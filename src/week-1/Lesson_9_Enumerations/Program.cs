using System;

namespace Lesson_9_Enumerations
{
    class Program
    {
        static void Main(string[] args)
        { 
            var _MyEnum=MyEnum.Glad;
            Console.WriteLine(_MyEnum);
        }
    }
    enum MyEnum
    {
        Happy,
        Sad,
        Joyous,
        Glad
    }
}
