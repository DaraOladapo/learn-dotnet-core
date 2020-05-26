using System;

namespace Lesson_16_MethodOverriding
{
    public abstract class Vehicle {
        public string Make {
            get;
            set;
        }

        public string Model {
            get;
            set;
        }

        public int Year {
            get;
            set;
        }

        public void Start() {
            Console.WriteLine($"{this.Make} is starting.");
        }
        public virtual void StartVehicle() {
            Console.WriteLine($"{this.Make} {this.Model} is starting.");
        }
    }
}