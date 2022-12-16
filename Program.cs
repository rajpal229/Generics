namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string maxstring = FindMax.FindStringMax("Peach", "Apple" , "Banana");
            Console.WriteLine("The maximum number is : " + maxstring);
        }
    }
}