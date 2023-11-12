int number  = int.Parse(Console.ReadLine());
number = Math.Abs(number);
int output = GetMultipleOfEvenAndOdds(number);
Console.WriteLine(output);

static int GetMultipleOfEvenAndOdds(int number)
{
    int sumEven = GetSumOfEvenDigits(number);
    int sumOdd = GetSumOfOddDigits(number);
    int result = sumEven * sumOdd;
    return result;
}
static int GetSumOfEvenDigits(int number)
{
    int evenSum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        number /= 10;
        if (digit % 2 == 0) 
        {
            evenSum += digit;
        }
    }
    return evenSum;
}
static int GetSumOfOddDigits(int number)
{
    int oddSum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        number /= 10;
        if (digit % 2 != 0)
        {
            oddSum += digit;
        }
    }
    return oddSum;
}

