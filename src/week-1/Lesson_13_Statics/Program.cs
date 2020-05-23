using System;

namespace Lesson_13_Statics {
    class Program {
        static void Main(string[] args) {
            Vehicle.Run();
            Vehicle.Model="Micra";

            var MyVehicle=new Vehicle();
            MyVehicle.Name="Toyota";
            MyVehicle.Stop();
        }
    }

    public class Vehicle {
        public string Name {
            get;
            set;
        }
        public static string Model{get;set;}
        public static void Run() {
            Console.WriteLine("I'm running static");
        }

        public void Stop() {
            Console.WriteLine("I'm running initialized");
        }

    }
}