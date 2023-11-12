namespace Biggest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;// най-голямото число до момента

            for (int i = 1; i <= numberCount; i++) 
            {   // променлива, в която съхранявам стойността на сегашното число
                int value = int.Parse(Console.ReadLine());
                // проверка дали е най-голямото
                if (value > maxNumber)
                    maxNumber = value ;
            }
            Console.WriteLine(maxNumber);
        }
    }
}