namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxInt = FindMax<int>.FindMaxNumber(3, 2, 1);
            Console.WriteLine("The maximum number in TC1 is : " + maxInt);

            int maxInt1 = FindMax<int>.FindMaxNumber(2, 3, 1);
            Console.WriteLine("The maximum number in TC2 is : " + maxInt1);

            int maxInt2 = FindMax<int>.FindMaxNumber(1, 2, 3);
            Console.WriteLine("The maximum number in TC3 is : " + maxInt2);


        }
    }
}