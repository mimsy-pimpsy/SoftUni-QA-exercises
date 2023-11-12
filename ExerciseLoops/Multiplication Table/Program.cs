namespace Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //int result = 0;

            //for ( int i = 1; i <= 10; i++ )
            //{
            //    result = 0;
            //    result = number * i;
            //    Console.WriteLine($"{number} x {i} = {result}");

            //}
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");

            }

        }
    }
}