namespace Even_Powers_of
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double  result;
            for (int i = 0; i <= number; i++) 
            {
                if (i % 2 == 0)
                {
                    result = Math.Pow(2, i);
                    Console.WriteLine(result);
                }
               
            }
        }
    }
}