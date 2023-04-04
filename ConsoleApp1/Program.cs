namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInput first number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input third number:");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInput fourth number:");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y, Math.Max(z, w))));
            Console.WriteLine("Lowest of three: " + Math.Min(x, Math.Min(y, Math.Min(z, w))));

            Main(args);
        }
    }
}