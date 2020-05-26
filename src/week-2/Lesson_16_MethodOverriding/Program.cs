using System;

namespace Lesson_16_MethodOverriding {
    class Program {
        static void Main(string[] args) {
            Car MyCar=new Car() {
                Make="Tesla",
                Model="3",
                Year=2019
            };
            Console.WriteLine(MyCar.Make);
            MyCar.Start();
            MyCar.StartVehicle();
        }
    }
}