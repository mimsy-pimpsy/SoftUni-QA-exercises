namespace t01.demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int row = 1;
            for (int current = 1; current <= n;) 
            { 
                for (int print = 0; print < row && current <= n; print++)
                {
                    Console.Write($"{current++} ");
                }
                Console.WriteLine();
                row++;
            }
        }
    }
}