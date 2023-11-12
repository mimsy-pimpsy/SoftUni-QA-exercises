namespace Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double value = double.Parse(Console.ReadLine());
            int coins = 0;
            double currentStotinkaValue = 2.00;

            while (value != 0)
            {
                if (value>= currentStotinkaValue)
                {
                    coins++;
                    value = Math.Round(value - currentStotinkaValue, 2);
                }
                else
                {
                    switch (currentStotinkaValue)
                    {
                        case 2.00: currentStotinkaValue = 1.00; break;
                        case 1.00: currentStotinkaValue = 0.50; break;
                        case 0.50: currentStotinkaValue = 0.20; break;
                        case 0.20: currentStotinkaValue = 0.10; break;
                        case 0.10: currentStotinkaValue = 0.05; break;
                        case 0.05: currentStotinkaValue = 0.02; break;
                        case 0.02: currentStotinkaValue = 0.01; break;
                        case 0.01: currentStotinkaValue = 0;    break;
                    }
                }
            }
            Console.WriteLine(coins);
        }
    }
}