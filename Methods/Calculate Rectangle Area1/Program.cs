// See https://aka.ms/new-console-template for more information
static int CalculateRetArea (int width, int lenght)
{
    return width * lenght;
} 

int width = int.Parse(Console.ReadLine());
int lenght = int.Parse(Console.ReadLine());

int area = CalculateRetArea(width, lenght);

Console.WriteLine(area);


