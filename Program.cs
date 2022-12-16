namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float maxfloat = FindMax.FindFloatMax(3.1f, 2.1f, 1.1f);
            Console.WriteLine("The maximum number is : " + maxfloat);
        }
    }
}