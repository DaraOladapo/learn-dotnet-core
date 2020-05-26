using System;

namespace Lesson_15_MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
           var AddedValueFromMethodOverload1=Add(2,4);
           //Console.WriteLine(AddedValueFromMethodOverload1);

            var AddedValueFromMethodOverload2=Add(2,4.7);
           //Console.WriteLine(AddedValueFromMethodOverload2);

          var AddedValueFromMethodOverload3=Add(4.6,4);
           //Console.WriteLine(AddedValueFromMethodOverload2);
        }
        static double Add(int firstValue, int SecondValue){
            var AddedValue=firstValue+SecondValue;
            Console.WriteLine($"{firstValue}+{SecondValue}={AddedValue}");
              return AddedValue;
        }
         static double Add(int firstValue, double SecondValue){
            var AddedValue=firstValue+SecondValue;
            Console.WriteLine($"{firstValue}+{SecondValue}={AddedValue}");
              return AddedValue;
        }
        static double Add(double firstValue, int SecondValue){
            var AddedValue=firstValue+SecondValue;
            Console.WriteLine($"{firstValue}+{SecondValue}={AddedValue}");
              return AddedValue;
        }
          
    }
}
