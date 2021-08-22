using System;

namespace FindMaximum
{
    public class Program
    {
        static void Main(string[] args)
        {
            MaximumNumber obj1 = new MaximumNumber();
            obj1.MaximumIntegerNumber(29,40,70);
            Console.WriteLine("Maximum Integer is "+obj1.MaximumIntegerNumber(29,40,70));
        }
    }
}
