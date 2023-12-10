Dictionary<string, string> registrars = new(); // key value pairs - Employee + Licence Palte Number

int input = int.Parse(Console.ReadLine()); // - number of commands
for (int i = 0; i < input; i++)
{
    string[] commandArray = Console.ReadLine().Split().ToArray(); //command Name plateNmber
    string command = commandArray[0];
    string employee = commandArray[1];

    if (command == "register")
    {
        string plateNum= commandArray[2];

        if (!registrars.ContainsKey(employee))
        {
            registrars.Add(employee, plateNum);
            Console.WriteLine($"{employee} registered {plateNum} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {registrars[employee]}");
        }
    }
    else if(command == "unregister")
    {
        
        if (registrars.ContainsKey(employee))
        {
            registrars.Remove(employee);
            Console.WriteLine($"{employee} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {employee} not found");
        }
    }

}
foreach(KeyValuePair<string, string> pair in registrars)
{
    Console.WriteLine($"{pair.Key} => {pair.Value}");
}

