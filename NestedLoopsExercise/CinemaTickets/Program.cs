namespace CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moviesNumber = 0;
            int totalStudentTickets = 0;
            int totalKidTickets = 0;
            int totalStandardTickets = 0;

            while (true)
            {
                string movieName = Console.ReadLine();
                
                if (movieName == "Finish")
                {
                    break;
                }
                int seatsCount = int.Parse(Console.ReadLine());
                int soldTicketsperMovieTotal = 0;

                while (soldTicketsperMovieTotal < seatsCount)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }
                    soldTicketsperMovieTotal++;
                    switch (ticketType)
                    {
                        case "kid":totalKidTickets++;break;
                        case "standard":totalStandardTickets++; break;
                        case "student": totalStudentTickets++;break;
                    }
                    
                }
                Console.WriteLine($"{movieName} - {soldTicketsperMovieTotal * 100.0 / seatsCount:f2}% full.");

            }
            int totaldSold = totalStandardTickets + totalKidTickets + totalStudentTickets;
            Console.WriteLine($"Total tickets: {totaldSold}");
            Console.WriteLine($"{totalStudentTickets *100.0 / totaldSold:f2}% student tickets.");
            Console.WriteLine($"{totalStandardTickets * 100.0 / totaldSold:f2}% standard tickets.");
            Console.WriteLine($"{totalKidTickets * 100.0 / totaldSold:f2}% kids tickets.");
        }
    }
}