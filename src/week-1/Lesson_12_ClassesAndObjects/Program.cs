using System;

namespace Lesson_12_ClassesAndObjects {
    class Program {
        static void Main(string[] args) {
            Vehicle MyVehicle=new Vehicle();
            MyVehicle.FuelLevel=2.5;
            MyVehicle._EngineType=EngineType.Petrol;
            MyVehicle.Make="Nissan";
            MyVehicle.Model="Maxima";
            MyVehicle.Year=2008;
            MyVehicle.StartEngine(MyVehicle.FuelLevel);


            // Vehicle MyOtherVehicle=new Vehicle("Toyota", "CHR", EngineType.Hybrid, 45.7);

            // MyOtherVehicle.StartEngine(MyOtherVehicle.FuelLevel);


            //explaining string concatenation
            // string FirstName="Dara";
            // string LastName="Oladapo";
            //direct concatenation
            // string DirectFullName=FirstName + " "+ LastName;
            // Console.WriteLine(DirectFullName);
            //string.Concat
            // string ConcatFullName=string.Concat(FirstName," " ,LastName);
            // Console.WriteLine(ConcatFullName);
            //string literal
            // string LiteralFullName=$"{FirstName} {LastName}";
            // Console.WriteLine(LiteralFullName);

            //.ToString()
            // int MyNumber=234;
            // string MyStringNumber=MyNumber.ToString();
            // Console.WriteLine(MyStringNumber);

            //explaining inheritance
            Car MyCar=new Car();
            MyCar.FuelLevel=2.5;
            MyCar._EngineType=EngineType.Petrol;
            MyCar.Make="Nissan";
            MyCar.Model="Maxima";
            MyCar.Year=2008;
            MyCar.StartEngine(MyCar.FuelLevel);
        }
    }

}