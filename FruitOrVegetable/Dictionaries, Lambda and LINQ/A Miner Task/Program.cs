Dictionary<string, int> resources = new();

string input = Console.ReadLine();

while (input != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

    if (!resources.ContainsKey(input))
    {
        resources.Add(input, quantity);
    }
    else
    {
        resources[input] += quantity;
    }

    input = Console.ReadLine();
}
foreach (KeyValuePair<string, int> pair in resources)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}




//Gold
//155
//Silver
//10
//Copper
//17
//stop