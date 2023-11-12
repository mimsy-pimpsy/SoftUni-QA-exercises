namespace HotelRoomm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartPice= 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartPice = 65; break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartPice = 68.70; break;
                case "July":
                case "August":
                    studioPrice = 76;
                    apartPice = 77; break;
            }
            double totalPriceStudio = studioPrice * nights;
            double totalPriceApart = apartPice * nights;
            if (nights > 14)
            {
                if (month == "May" || month== "October")
                {
                    totalPriceStudio = totalPriceStudio * 0.70;
                }
                else if (month == "June" || month == "September")
                {
                    totalPriceStudio = totalPriceStudio * 0.80;
                }
                totalPriceApart = totalPriceApart * 0.90;


            }
            else if (nights >= 7 && (month == "May" || month == "October") )
            {
                totalPriceStudio = totalPriceStudio * 0.95;
            }
            Console.WriteLine($"Apartment: {totalPriceApart:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
        }
        
    }
}