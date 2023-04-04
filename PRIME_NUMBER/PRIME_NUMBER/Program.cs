namespace PRIME_NUMBER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool prime = true;
            Console.WriteLine(" enter your number ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine("IS A PRIME NUMBER");
            }
            else
            {
                Console.WriteLine("IS NOT A PRIME NUMBER");
            }

            Main(args);
        }
    }
}