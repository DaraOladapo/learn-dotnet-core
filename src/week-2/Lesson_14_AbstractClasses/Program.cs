using System;

namespace Lesson_14_AbstractClasses {
    class Program {
        static void Main(string[] args) {
            var MyCar=new Car();
            MyCar.Make="Tesla";
            MyCar.Model="3";
            MyCar.Year=2019;
            MyCar.EngineType=EngineTypes.Electric;

            var MyOtherCar=new Car(){
               Make="Toyota",
               Model="CH-R",
               Year=2020,
               EngineType=EngineTypes.Hybrid 
            };
        }
    }
}