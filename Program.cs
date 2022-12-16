namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string maxstring = FindMax.FindStringMax("Apple", "Banana", "Peach");
            Console.WriteLine("The maximum number is : " + maxstring);
        }
    }
}