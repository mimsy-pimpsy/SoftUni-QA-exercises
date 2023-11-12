namespace Power_of_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
           int power = int.Parse(Console.ReadLine());

            //Console.WriteLine((Math.Pow(numX, numY)));

            int result = 1;
            for (int time = 1; time <= power; time++)
            {
                result *= number;
            }
            Console.WriteLine(result);
        }
    }
}