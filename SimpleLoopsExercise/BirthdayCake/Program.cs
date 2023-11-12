namespace BirthdayCake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int cakeSize = width * lenght;

            while (cakeSize >= 0) 
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                cakeSize -= int.Parse(input);
            } 
            if (cakeSize >= 0)
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {-cakeSize} pieces more.");
            }


        }
    }
}