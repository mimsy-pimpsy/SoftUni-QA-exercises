namespace Sorted_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (product == "Banana")
            {
                if (day == "Weekend")
                { price = 2.70; }
                else
                {
                    price = 2.50;
                }

            }
            else if (product == "Apple")
            {
                if (day == "Weekend")
                { price = 1.60; }
                else
                {
                    price = 1.30;
                }
            }
            else if (product == "Kiwi")
            {
                if (day == "Weekend")
                { price = 3.00; }
                else
                {
                    price = 2.20;
                }

            }
            Console.WriteLine($"{price:f2}");
        }
    }
}