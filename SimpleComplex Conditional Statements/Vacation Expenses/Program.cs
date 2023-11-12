namespace Vacation_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string accomType = Console.ReadLine();
            int daysCount = int.Parse(Console.ReadLine());
            double price = 0;
            

            if (season == "Spring")
            {
                if (accomType == "Hotel")
                {
                    price = 30 * 0.80;
                }
                else if (accomType == "Camping")
                {
                    price = 10 * 0.80;
                }
            }
            else if (season == "Summer")
            {
                if (accomType == "Hotel")
                {
                    price = 50;
                }
                else if (accomType == "Camping")
                {
                    price = 30;
                }
            }
            else if (season == "Autumn")
            {
                if (accomType == "Hotel")
                {
                    price = 20 * 0.70;
                }
                else if (accomType == "Camping")
                {
                    price = 15 * 0.70;
                }
            }
            else if (season == "Winter")
            {
                if (accomType == "Hotel")
                {
                    price = 40 * 0.90;
                }
                else if (accomType == "Camping")
                {
                    price = 10 * 0.90;
                }
            }
            double totalExpenses = daysCount * price;
            Console.WriteLine($"{totalExpenses:f2}");



        }
    }
}