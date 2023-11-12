namespace Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperture = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();
            string clothing = string.Empty;
            string shoes = string.Empty;

            if (timeOfTheDay == "Morning")
            {
                if (temperture >= 10 && temperture <= 18)
                {
                    clothing = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (temperture > 18 && temperture <= 24)
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temperture >= 25)
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (timeOfTheDay == "Afternoon")
            {
                if (temperture >= 10 && temperture <= 18)
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temperture > 18 && temperture <= 24)
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (temperture >= 25)
                {
                    clothing = "Swim Suit";
                    shoes = "Barefoot";
                }

            }
            else if (timeOfTheDay == "Evening")
            {
                clothing = "Shirt";
                shoes = "Moccasins";
            }
            Console.WriteLine($"It's {temperture} degrees, get your {clothing} and {shoes}.");
        }
    }
}