namespace BoilingWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double tempertureCelsius = double.Parse(Console.ReadLine());
          if (tempertureCelsius > 100)
            {
                Console.WriteLine("The water is boiling");
            }
          else
            {
                Console.WriteLine("The water is not hot enough");
            }
        }
    }
}