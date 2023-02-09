namespace Gnric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The First Value");
            float firstValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Second Value");
            float secondValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Third Value");
            float thirdValue = Convert.ToInt32(Console.ReadLine());

            float output = Number.MaximumFloatNum(firstValue, secondValue, thirdValue);
            Console.WriteLine("Maximum Float Number is");
            Console.WriteLine(output);

        }
    }
}