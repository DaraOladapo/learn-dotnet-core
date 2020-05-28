using System;

namespace Lesson_20_Loopy {
    class Program {
        //conditional operators
        //less than <
        //less than or equal to <=
        //greater than >
        //greater than or equal to >=
        //eual to ==
        //not equal to !=

        static void Main(string[] args) {
            //output all even numbers between 1 and 10
            //   for (int i = 1; i <= 10; i++)
            //   {
            //       if(i%2==0){
            //        Console.WriteLine(i);
            //       }
            //   }
            //int[] MyNumbers={1,4,5,8,9};
            // foreach (var Number in MyNumbers)
            // {
            //     Console.WriteLine(Number);
            // }  
            //while loop
            int i=2;
            while (i<10) {
                Console.WriteLine(i);
                i+=2;
            }
            //do while loop
            int j=2;
            do
            {
                Console.WriteLine(j);
                j+=2;
            } while (j<10);
        }
    }
}