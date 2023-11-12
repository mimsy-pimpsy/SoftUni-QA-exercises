int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());

PrintMultiplicationSign(number1, number2, number3);
//nachin 1
//static void PrintMultiplicationSign (int number1, int number2, int number3)
//{
//    int product = number1 * number2 * number3;

//    if (product <= 0)
//    {
//        Console.WriteLine("negative");
//    }
//    else if (product >0) 
//    {
//        Console.WriteLine("positive");
//    }
//    else 
//    { 
//        Console.WriteLine("zero");
//    }

//}
//nachin 2

static void PrintMultiplicationSign(int number1, int number2, int number3)
{
    if (number1 == 0 || number2 == 0 || number3 == 0)
    {
        Console.WriteLine("zero");
    }
    else if (number1 > 0 && number2 > 0 && number3 > 0)
    {
        Console.WriteLine("positive");
    }
    else if (number1 < 0 && number2 < 0 && number3 > 0)
    {
        Console.WriteLine("positive");
    }
    else if (number1 > 0 && number2 < 0 && number3 < 0)
    {
        Console.WriteLine("positive");
    }
    else if (number1 < 0 && number2 > 0 && number3 < 0)
    {
        Console.WriteLine("positive");
    }
    else
    {
        Console.WriteLine("negative");
    }
}
