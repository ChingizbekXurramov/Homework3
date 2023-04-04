namespace FIBANACCI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = 0, secondnumber = 1, threenumber = 3, i, number1;
            Console.WriteLine(" enter your number ");
            int number = int.Parse(Console.ReadLine());
            Console.Write(firstnumber + " " + secondnumber);
            for (i = 3; i <= number; i++)
            {
                threenumber = firstnumber + secondnumber;
                Console.Write(threenumber + " ");
                firstnumber = secondnumber;
                secondnumber = threenumber;
            }


            Main(args);
        }
    }
}