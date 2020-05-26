namespace Lesson_14_AbstractClasses
{
    //can be inherited
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
    //cannot be inherited
    public sealed class OtherVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
