using System;

namespace Lesson_17_Interfaces {

    public class Car: Vehicle, IVehicle {
            public EngineTypes EngineType {
                get;
                set;
            }
            public void Start() {
            Console.WriteLine($"{this.Make} {this.Model} {this.Year} is starting.");
        }

        public void Stop() {
            Console.WriteLine($"{this.Make} {this.Model} {this.Year} is stopping.");
        }

        public void Accelerate() {
            Console.WriteLine($"{this.Make} {this.Model} {this.Year} is accelerating.");
        }
        }

}