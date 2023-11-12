namespace MovingOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int width = int.Parse(Console.ReadLine());
           int lenght = int.Parse(Console.ReadLine());
           int hight = int.Parse(Console.ReadLine());

           int apartvolume = width * lenght * hight;

           while (apartvolume >= 0)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                apartvolume -= int.Parse(input);
            }
           if (apartvolume >= 0)
            {
                Console.WriteLine($"{apartvolume} Cubic meters left.");
            }
           else
            {
                Console.WriteLine($"No more free space! You need {-apartvolume} Cubic meters more.");
            }
        }
    }
}