using System;

namespace Lesson_17_Interfaces {
    class Program {
        static void Main(string[] args) {
            Car MyCar=new Car() {
                Make="Tesla",
                Model="3",
                Year=2019,
                EngineType=EngineTypes.Electric
            };
            MyCar.Start();
            MyCar.Accelerate();
            MyCar.Stop();
        }
    }
}