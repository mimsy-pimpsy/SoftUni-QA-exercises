namespace Travel_Savings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End") 
            {
                
                double neededMoney = double.Parse(Console.ReadLine());
                double totalCollected = 0;
                while (totalCollected < neededMoney)
                {

                   double collectedMoney = double.Parse(Console.ReadLine());
                    totalCollected += collectedMoney;
                    Console.WriteLine($"Collected: {totalCollected:F2}");

                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
            
    }
}