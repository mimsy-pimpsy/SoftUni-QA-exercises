namespace Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                double currentSum = double.Parse(command);
                if (currentSum >= 0)
                {
                    Console.WriteLine($"Increase: {currentSum:F2}");
                    balance += currentSum;
                }
                else
                {
                    Console.WriteLine($"Decrease: {Math.Abs(currentSum):F2}");
                    balance += currentSum;
                }
            }
            Console.WriteLine($"Balance: {balance:F2}");
        }
    }
}