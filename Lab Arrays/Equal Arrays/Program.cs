int[] firstRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[] secondRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
bool isIdentical = true;

for (int index = 0; index < firstRow.Length; index++)
{
    if (firstRow[index] != secondRow[index])
    {
        isIdentical = false;
        Console.WriteLine("Arrays are not identical.");
        break;
    }
    else
    {
        isIdentical = true;
    }
    
}
if (isIdentical == true)
Console.WriteLine("Arrays are identical.");
