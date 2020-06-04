using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_24_GenericsAndCollections {
    class Program {
        static void Main(string[] args) {
            //arrays
            //    int[] MyIntArray=new int[5];
            //    MyIntArray[0]=54;
            //    MyIntArray[1]=58;
            //    MyIntArray[2]=8;
            //    MyIntArray[3]=5;
            //    MyIntArray[4]=578;
            //Console.WriteLine(MyIntArray[3]);
            //     for (int i = 0; i < MyIntArray.Length; i++)
            //     {
            //         Console.WriteLine(MyIntArray[i]);
            //     }
            //    int[] MyOtherArray={2,8,6,4,4};
            //     foreach (var element in MyOtherArray)
            //     {
            //         Console.WriteLine(element);
            //     }

            var InitialStudent = new Student() {
                FirstName = "Jonah",
                    LastName = "Smith"
            };
            var FirstStudent = new Student() {
                FirstName = "Jack",
                    LastName = "Bauer"
            };
            var SecondStudent = new Student() {
                FirstName = "James",
                    LastName = "Ikimi"
            };

            List <Student> Students = new List <Student>();
            Students.Add(InitialStudent);
            Console.WriteLine($"We have {Students.Count} students.");
            Students.Add(FirstStudent);
            Console.WriteLine($"We have {Students.Count} students.");
            Students.Add(SecondStudent);
            Console.WriteLine($"We have {Students.Count} students.");
           

            // foreach(var _Student in Students) {
            //     Console.WriteLine($"{_Student.FullName} has index of {Students.IndexOf(_Student)}");
            // }

            //var StudentToRemove = Students.Find(option => option.FullName == "James Orger");
            //using LINQ
            // var Search1=Students.FirstOrDefault(searchOption=>searchOption.FullName=="Dara Oladapo");
            // Console.WriteLine($"{Search1.FullName} has index {Students.IndexOf(Search1)}");
            var StudentswithJa=Students.Where(option=>option.FirstName.Contains("Ja")).ToList();
            Console.WriteLine(StudentswithJa.Count);
            // var Search2=Students.LastOrDefault(searchOption=>searchOption.FullName=="Dara Oladapo");
            // Console.WriteLine($"{Search2} has index {Students.IndexOf(Search2)}");

            // Students.Remove(StudentToRemove);
            // if (StudentToRemove != null) {
            //     Console.WriteLine($"Student found and removed.");
            //     Console.WriteLine($"We now have {Students.Count} students.");
            // }
            // else
            // {
            //     Console.WriteLine("We could not find someone to remove.");
            // }
            // string SomePerson="Dara Oladapo";
            // Console.WriteLine(SomePerson[7]);
        }
    }
}