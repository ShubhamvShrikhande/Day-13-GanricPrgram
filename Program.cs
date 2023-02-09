using System.IO;
using System;

namespace Gnric
{
    internal class Program
    {
        static void Main(string[] args)
        {

           string output=  Number.MaximumStringNum("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum String Number is");
            Console.WriteLine(output);

        }
    }
}