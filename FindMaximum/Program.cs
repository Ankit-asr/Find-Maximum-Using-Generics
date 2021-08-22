using System;

namespace FindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumNumber maximum = new MaximumNumber();
            Console.WriteLine("Maximum Float number is:" + maximum.MaximumFloatNumber(29.34, 40.34, 70.54));
        }
    }
}