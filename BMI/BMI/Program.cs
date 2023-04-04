namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter your weight ");
            double Weight = double.Parse(Console.ReadLine());
            Console.WriteLine("enter your height");
            float Height = float.Parse(Console.ReadLine());
            float metres = Height / 100;
            float kvadrat = metres * metres;
            Console.Write("BMI ==> ");
            Console.WriteLine(Weight / kvadrat);
            Main(args);
        }
    }
}