using System;

namespace Lesson_3_Scopes
{
    class Program
    {
        static int ClassValue=5;//class scope
        static void Main(string[] args)
        {
            Console.WriteLine($"{ClassValue} from main method");
            int MainMethodValue=53;//method scope
            Console.WriteLine($"{MainMethodValue} from main method");
            MyMethod();
        }
        static void MyMethod(){
             Console.WriteLine($"{ClassValue} from my method");
             int MyMethodValue=456;//method scope
             Console.WriteLine($"{MyMethodValue} from my method");
             {
                int BoundedScopeValue=874;//bounded scope
                Console.WriteLine($"{BoundedScopeValue} from bounded scope in my method");
             }
             //Console.WriteLine($"{BoundedScopeValue} from my method");//not accesible
             //Console.WriteLine(MainMethodValue);//not accessible
        }
    }
}
