string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

double result = CheckPrice(product, quantity);

Console.WriteLine($"{result:F2}");


static double CheckPrice(string product, int quantity)
{
    double result = 0;
    if (product == "coffee")
    {
        result = quantity * 1.50;
    }
    else if (product == "water")
    {
        result = quantity * 1.00;
    }
    else if (product == "coke")
    {
        result = quantity * 1.40;
    }
    else if (product == "snacks")
    {
        result = quantity * 2.00;
    }

    return result;
}