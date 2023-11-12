int[] firstRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

foreach  (int number in firstRow)
{
    foreach (int digit in secondRow)
    {
        if (number == digit)
        {
            Console.Write(number + " ");
        }
    }
}