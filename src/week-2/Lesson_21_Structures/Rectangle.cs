namespace Lesson_21_Structures
{
    public struct Rectangle{
         public double Length { get; set; }
         public double Breadth { get; set; }
         public double Area => Length * Breadth;
    }
}