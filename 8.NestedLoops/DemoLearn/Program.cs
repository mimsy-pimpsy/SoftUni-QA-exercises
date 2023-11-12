namespace DemoLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NumbersPyramid
            //int n = int.Parse(Console.ReadLine());
            // int current = 1;
            // bool isBigger = false;

            // for (int rows = 1; rows <= n; rows++)
            // {
            //     for (int cols = 1; cols <= rows; cols++) 
            //     {
            //         if (current > n)
            //         {
            //             isBigger = true;
            //             break;
            //         }
            //         Console.Write(current + " ");
            //         current++;

            //     }
            //     if (isBigger)
            //     {
            //         break;
            //     }
            //     Console.WriteLine();


            //OddandEvensums
            //int firstNumber = int.Parse(Console.ReadLine());
            //int secondNumber = int.Parse(Console.ReadLine());

            //for ( int i = firstNumber; i <= secondNumber; i++ )
            //{
            //    string currentNumber = i.ToString();
            //    int oddSum = 0;
            //    int evenSum = 0;

            //    for (int digit = 0; digit < currentNumber.Length;digit++)
            //    {
            //        int currentDigit = int.Parse(currentNumber[digit].ToString());
            //        if (digit % 2 == 0)
            //        {
            //            evenSum += currentDigit;
            //        }
            //        else
            //        {
            //            oddSum += currentDigit;
            //        }

            //    }
            //    if (evenSum == oddSum)
            //    {
            //        Console.Write(i + " ");
            //    }

            //SumOfPrimesAndNonPrimes


            //int primesSum = 0;
            //int nonPrimesSum = 0;
            //while (true)
            //{
            //    string input = Console.ReadLine(); 
            //    if (input == "stop")
            //    {
            //        break;
            //    }
            //    int number = int.Parse(input);
            //    if (number < 0)
            //    {
            //        Console.WriteLine("Number is negative.");
            //        continue;
            //    }
            //    int divisors = 0;
            //    for (int i = 1; i <= number; i++)
            //    {
            //        if (number % i== 0)
            //        {
            //            divisors++;
            //        }
            //    }
            //    if (divisors == 2)
            //    {
            //        primesSum += number;
            //    }
            //    else
            //    {
            //        nonPrimesSum += number;
            //    }

            //}
            //Console.WriteLine($"Sum of all prime numbers is: {primesSum}");
            //Console.WriteLine($"Sum of all non prime numbers is: {nonPrimesSum}");

            //4. Train the Trainers

            //int juryCount = int.Parse(Console.ReadLine());
            //int presentationCount = 0;
            //double totalGrade = 0;

            //while (true)
            //{
            //    string presentationName = Console.ReadLine();
            //    if ( presentationName == "Finish")
            //    {
            //        break;
            //    }
            //    presentationCount++;
            //    double averagePresGrade = 0;

            //    for (int juryMember = 1;juryMember <= juryCount; juryMember++)
            //    {
            //        double currentGrade = double.Parse(Console.ReadLine());
            //        averagePresGrade += currentGrade;
            //        totalGrade += currentGrade;
            //    }
            //    Console.WriteLine($"{presentationName} - {averagePresGrade / juryCount:f2}.");

            //}
            //Console.WriteLine($"Student's final assessment is {totalGrade / (presentationCount * juryCount):f2}.");

            //Special Numbers



        }

    }
}
    