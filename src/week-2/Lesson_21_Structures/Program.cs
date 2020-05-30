using System;

namespace Lesson_21_Structures {
    class Program {
        static void Main(string[] args) {
            //StructShape MyShape=new StructShape(12,45); 
            // StructShape MyShape=new StructShape();
            // Console.WriteLine("Before");
            // Console.WriteLine(MyShape.Perimeter);
            // Console.WriteLine(MyShape.Area);
            //StructShape MyOtherShape=new StructShape(){Perimeter=47, Area=94};
            // Console.WriteLine("After");
            // MyShape.Perimeter=22;
            // MyShape.Area=47;
            // Console.WriteLine(MyShape.Perimeter);
            // Console.WriteLine(MyShape.Area);
            //     Console.WriteLine(MyOtherShape.Perimeter);
            //    Console.WriteLine(MyOtherShape.Area);
            // var _Length = double.Parse(Console.ReadLine());
            // var _Breadth = double.Parse(Console.ReadLine());

            // Rectangle MyRectangle = new Rectangle() {
            //     Length = _Length,
            //         Breadth = _Breadth
            // };
            // Console.WriteLine(MyRectangle.Area);

            // Rectangle MyOtherRectangle = new Rectangle() {};
            // MyOtherRectangle.Length = _Length;
            // MyOtherRectangle.Breadth = _Breadth;
            Person MyPerson=new Person(){
                FirstName="Dara",
                LastName="Oladapo",
            };
            //MyPerson.FullName=$"{MyPerson.FirstName} {MyPerson.LastName}";
            Console.WriteLine(MyPerson.FullName);

        }
    }
}