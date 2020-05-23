using System;

namespace Lesson_12_ClassesAndObjects {
    public class Vehicle {

        //constructor
        //without parameters
        public Vehicle() {
            Console.WriteLine("I am initalized without parameters");
        }

        //with parameters
        public Vehicle(string _Make, string _Model, EngineType engineType, double _FuelLevel) {
            Make=_Make;
            Model=_Model;
            _EngineType=engineType;
            FuelLevel=_FuelLevel;
            Console.WriteLine("I am initalized with parameters and here are my details.");
            Console.WriteLine($"Make: {Make}\nModel: {Model}\nEngine: {_EngineType}\nFuel Level: {FuelLevel} litres");
        }

        //destructor
        ~Vehicle() {
            this.FuelLevel=0;
            Console.WriteLine("I'm self destructing now.");
        }

        //fields
        public EngineType _EngineType {
            get;
            set;
        }

        public string Make {
            get;
            set;
        }

        public double FuelLevel {
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

        //methods
        public void StartEngine(double FuelLevel) {
            if(FuelLevel<1) {
                Console.WriteLine("The fuel in the vehicle is not enough to start. Please add some fuel.");
            }
            else {
                Console.WriteLine($"{Make} {Model}'s fuel level is {FuelLevel}.");
                Console.WriteLine($"{Make} {Model}'s engine has started.");
                FuelLevel=FuelLevel-0.1;
                Console.WriteLine($"{Make} {Model}'s fuel level is now {FuelLevel}.");
            }
        }

    }

    //types of accessors
    //public accesible outside the program/assembly with a reference
    //private (Default, only acceible within the same scope/class)
    //internal (only accesible from class and methods of the same assembly/program)
    public enum EngineType {
        Petrol,
        Diesel,
        Electric,
        Hybrid
    }
}