int number = int.Parse(Console.ReadLine());
Console.WriteLine(CheckPrimeNumber(number));

static bool CheckPrimeNumber (int number)
{
    int divisors = 0;
    for (int num = 1; num <= number; num++)
    {
        if(number % num == 0)
        {
            divisors++;
        }
        
    }
    return divisors == 2;
    
}
