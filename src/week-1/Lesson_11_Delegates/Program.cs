using System;

namespace Lesson_11_Delegates {
    public delegate int ComputeNumber(int a, int b);
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Input the first value: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second value: ");
            int b = int.Parse(Console.ReadLine());
            ComputeNumber _ComputeNumber = ComputeNumber;
            PerformCompute(a, b, _ComputeNumber);
        }
        static int ComputeNumber(int a, int b) {
            return a * b;
        }
        static void PerformCompute(int a, int b, ComputeNumber _ComputeNumber) {
            var ComputedValue = _ComputeNumber(a, b);
            Console.WriteLine($"Sum of {a} and {b}={a+b}");
            Console.WriteLine($"Product of {a} and {b}={ComputedValue}");
        }
    }
}