namespace Decreasing_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
             while (number >= 1) 
            {
                Console.WriteLine(number);
                number--;
            }

        }
    }
}