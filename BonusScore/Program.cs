namespace BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finalPoints = int.Parse(Console.ReadLine());
            if (finalPoints >= 0 && finalPoints <= 3)
            {
                finalPoints += 5;
            }
            else if (finalPoints >= 4 && finalPoints < 6)
            {
                finalPoints += 15;
            }
            else if (finalPoints >= 7 && finalPoints <= 9)
            {
                finalPoints += 20;
            }
            Console.WriteLine(finalPoints);
        }
    }
}