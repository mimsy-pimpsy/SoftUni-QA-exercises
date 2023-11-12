List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    //1.command = Delete {element} 
   //2. command = Insert {element} {index}
    string[] commandParts = command.Split(" "); // ["Delete", "element"] || ["Insert", "element" , "index"] 
    string commandName = commandParts[0]; // name could be  Delete or Insert 
    int element = int.Parse(commandParts[1]);
    if (commandName == "Delete")
    {
        numbers.RemoveAll(number => number == element);
    }
    else if (commandName == "Insert")
    {
        int position = int.Parse(commandParts[2]); // ["Insert", "element" , "index"] 
        numbers.Insert(position, element);
    }

    command = Console.ReadLine();
} 
Console.WriteLine(string.Join(" ", numbers));
