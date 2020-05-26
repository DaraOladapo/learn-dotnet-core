using System;

namespace Lesson_8_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStuct _MyStruct=new MyStuct();
            _MyStruct.MyStuctInt=233;
            Console.WriteLine(_MyStruct.MyStuctInt);
        }
    }
    struct MyStuct
    {
        public int MyStuctInt { get; set; }
    }
}
