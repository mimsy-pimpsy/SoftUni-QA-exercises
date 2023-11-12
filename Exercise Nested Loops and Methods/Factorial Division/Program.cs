int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

int result = GetFactorial(number1) / GetFactorial(number2);
Console.WriteLine(result);

static int GetFactorial (int number)
{
    int factorial = 1;
    for(int i =1; i <= number; i++)
    {
        factorial *= i;
    }
    return factorial;
}
