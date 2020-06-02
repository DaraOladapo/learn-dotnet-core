using System;

namespace Lesson_22_TryParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            int MyNumber;
            Console.WriteLine("Enter a number");
            string UserInput=Console.ReadLine();
            var GetInput=int.TryParse(UserInput, out MyNumber);
            if(GetInput==true)
            {
                Console.WriteLine($"Successfully parsed {UserInput} from {UserInput.GetType()} to {MyNumber} of type {MyNumber.GetType()}");
            }
            else
            {
                Console.WriteLine("Parsing failed");
            }
        }
    }
}
