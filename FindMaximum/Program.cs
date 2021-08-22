using System;

namespace FindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Maximum<int> findMaxInt = new Maximum<int>(20, 30, 50);
            Console.WriteLine("Maximum Integer is " + findMaxInt.MaximumValue());
            Maximum<double> findMaxDouble = new Maximum<double>(30.12, 40.23, 50.12);
            Console.WriteLine("Maximum Float Value is :" + findMaxDouble.MaximumValue());
            Maximum<string> findMaxString = new Maximum<string>("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum String is " + findMaxString.MaximumValue());
        }
    }
}