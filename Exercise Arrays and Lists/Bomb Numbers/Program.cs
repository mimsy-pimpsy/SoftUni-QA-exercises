List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> bomb = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

int bombNum = bomb[0];
int bombPower = bomb[1];

for (int i = 0; i < input.Count; i++)
{
    if (input[i] == bombNum)
    {
        int startIndex = i - bombPower;
        int removeCount = bombPower + bombPower + 1;

        if (startIndex < 0 ) 
        {
            startIndex = 0;
        }

        if (startIndex + removeCount > input.Count )
        { 
            removeCount = input.Count - startIndex;
        }
        input.RemoveRange(startIndex, removeCount);
        i = startIndex - 1;
    }
}
int sum = input.Sum();
Console.WriteLine(sum);
