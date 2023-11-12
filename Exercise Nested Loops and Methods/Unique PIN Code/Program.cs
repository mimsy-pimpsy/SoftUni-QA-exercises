static bool CheckPrimeNumber(int number)
{
    int divisors = 0;
    for (int num = 1; num <= number; num++)
    {
        if (number % num == 0)
        {
            divisors++;
        }

    }
    return divisors == 2;

}


int max1 = int.Parse(Console.ReadLine());
int max2 = int.Parse(Console.ReadLine());
int max3 = int.Parse(Console.ReadLine());


for (int digit1 = 2; digit1 <= max1; digit1 += 2) //even number
{
    for (int digit2 = 1;digit2 <= max2; digit2++) // prime number [1, max2] --> 2,3,5,7
    {
        for (int digit3 =2; digit3 <= max3; digit3 += 2)
        {
            if (CheckPrimeNumber(digit2))
            { Console.WriteLine($"{digit1}{digit2}{digit3}"); }
        }
    }

}