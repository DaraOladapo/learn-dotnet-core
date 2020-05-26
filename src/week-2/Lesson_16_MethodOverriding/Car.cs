using System;
namespace Lesson_16_MethodOverriding
{
    public class  Car:Vehicle
    {
        public EngineTypes EngineType{get;set;}

        //method 1
        public new void Start(){
             Console.WriteLine($"{this.Make} {this.Model} is starting.");
        }
        //method 2
        public override void StartVehicle(){
             Console.WriteLine($"{this.Make} {this.Model} {this.Year} is starting.");
        }
    }
}