namespace AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalAmount = 0;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "NoMoreMoney")
            {
               
                double deposit = double.Parse(command);

                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                totalAmount += deposit;
                Console.WriteLine($"Increase: {deposit:f2}");
            }
            Console.WriteLine($"Total: {totalAmount:f2}");
 
        }
    }
}