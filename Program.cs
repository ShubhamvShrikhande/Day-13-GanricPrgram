using System.IO;
using System;

namespace Gnric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output = Number<int>.GetMaximum(15, 25, 5);
            Console.WriteLine($"max={output}");
            float output1 = Number<float>.GetMaximum(15.5f, 253.5f, 3.5f);
            Console.WriteLine($"max={output1}");
            string output2 = Number<string>.GetMaximum("abc", "pqr", "lmn");
            Console.WriteLine($"max={output2}");

        }
    }
}