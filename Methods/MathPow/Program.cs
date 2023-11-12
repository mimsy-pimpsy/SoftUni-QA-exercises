// See https://aka.ms/new-console-template for more information
 int MathPower(int baseNum , int power)
{
    int output = 1;
    for (int i = 1;i <= power; i++)
    {
        output *= baseNum;
    }
    return output;
}

int baseNum = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

int result = MathPower(baseNum, power);
Console.WriteLine(result);

