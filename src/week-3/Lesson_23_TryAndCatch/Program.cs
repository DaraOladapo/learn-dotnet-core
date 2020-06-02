using System;

namespace Lesson_23_TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
         int MyNumber;
         Console.WriteLine("Enter a number");
         var UserInput=Console.ReadLine();
         try
         {
             MyNumber=int.Parse(UserInput);
             Console.WriteLine(MyNumber);
         }
         catch (System.Exception Exp)
         {
            Console.WriteLine("We don't understand your input. Try again");
            // Console.WriteLine("An exception was thrown. Here are the details.");
            // Console.WriteLine($"Message: {Exp.Message}");
            // Console.WriteLine($"Help Link: {Exp.HelpLink}");
            // Console.WriteLine($"Stack Trace: {Exp.StackTrace.ToString()}");
         }
         finally
         {
             Console.WriteLine("Thank you for banking with us.");
         }
        }
    }
}
