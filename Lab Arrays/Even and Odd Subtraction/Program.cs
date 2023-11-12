int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int evenSum = 0;
int oddSum = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    int currentDigit = numbers[i];
//    if (currentDigit % 2 == 0)
//    {
//        evenSum += currentDigit;
//    }
//    else
//    {
//        oddSum += currentDigit;
//    }
//}
//Console.WriteLine(evenSum - oddSum);
foreach  (int number in numbers)
{
    if (number % 2 == 0)
    {
        evenSum += number;
    }
    else
    {
        oddSum += number;
    }
}
Console.WriteLine(evenSum - oddSum);