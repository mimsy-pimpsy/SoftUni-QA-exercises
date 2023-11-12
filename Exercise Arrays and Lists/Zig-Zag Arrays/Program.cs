int count = int.Parse(Console.ReadLine());

List<int> firstRow = new List<int>();
List<int> secondRow = new List<int>();

for  (int i = 0; i < count; i++)
{
    List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
     if ( i % 2 == 0)
    {
        firstRow.Add(numbers[0]);
        secondRow.Add(numbers[1]);
    }
    else
    {
        firstRow.Add(numbers[1]); 
        secondRow.Add(numbers[0]);
    }
}
Console.WriteLine(string.Join (" ", firstRow));
Console.WriteLine(string.Join (" ", secondRow));