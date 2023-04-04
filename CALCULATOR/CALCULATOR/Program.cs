namespace CALCULATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Firstnumber = 0;
            double Secondnumber = 0;
            double result = 0;


            Console.WriteLine("Enter first number: ");
            Firstnumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            Secondnumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an option: ");
            Console.WriteLine("\t   + ");
            Console.WriteLine("\t   - ");
            Console.WriteLine("\t   * ");
            Console.WriteLine("\t   / ");
            Console.Write("Enter an option: ");
            switch (Console.ReadLine())
            {
                case "+":
                    result = Firstnumber + Secondnumber;
                    Console.WriteLine($" Result: {Firstnumber} + {Secondnumber} = " + result);
                    break;
                case "-":
                    result = Firstnumber - Secondnumber;
                    Console.WriteLine($" Result: {Firstnumber} - {Secondnumber} = " + result);
                    break;
                case "*":
                    result = Firstnumber * Secondnumber;
                    Console.WriteLine($" Result: {Firstnumber} * {Secondnumber} = " + result);
                    break;
                case "/":
                    result = Firstnumber / Secondnumber;
                    Console.WriteLine($" Result: {Firstnumber} / {Secondnumber} = " + result);
                    break;
            }
            Main(args);
        }
    }
}