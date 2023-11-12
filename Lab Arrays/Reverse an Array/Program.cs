int lenght = int.Parse(Console.ReadLine());

int[] numbers = new int[lenght];
for (int i = 0; i < lenght ; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}
for (int i=lenght - 1 ; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}