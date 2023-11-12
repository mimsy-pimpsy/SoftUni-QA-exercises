List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();


while (numbers.Count > 1)
{
    List<int> output = new List<int>();
    for (int input = 0; input < numbers.Count - 1; input++)
    {
        

        int num1 = numbers[input];
        int num2 = numbers[input + 1];
        int sum = num1 + num2;

        output.Add(sum);
        
    }
    numbers = output;
}
Console.WriteLine(numbers[0]);