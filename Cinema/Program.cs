namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string movieType = Console.ReadLine();
            int rowsCount = int.Parse(Console.ReadLine());
            int seatsCount = int.Parse(Console.ReadLine());
            int sumOfSeats = rowsCount * seatsCount;

            double totalPrice = 0;

            switch (movieType)
            {
                case "Premiere": totalPrice = sumOfSeats * 12.00; break;
                case "Normal": totalPrice = sumOfSeats * 7.50 ; break;
                case "Discount": totalPrice = sumOfSeats * 5.00; break;
            }
            Console.WriteLine($"{totalPrice:f2}");
                    
        }
    }
}