using System.Reflection.Metadata.Ecma335;

namespace SumOfPrimeAndNonPrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SumOfPrimes = 0;
            int sumOfNonPrimes = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                int divisors = 0;
                for (int i = 1; i <=number; i++)
                {
                    if (number % i == 0)
                    {
                        divisors++;
                    }
                } 
                if (divisors == 2)
                {
                    SumOfPrimes += number;
                }
                else
                {
                    sumOfNonPrimes += number;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {SumOfPrimes}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonPrimes}");

        }
    }
}