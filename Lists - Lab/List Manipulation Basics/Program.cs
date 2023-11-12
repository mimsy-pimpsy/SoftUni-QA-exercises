List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    //1.command = Add {element} 
    //2. command = Remove {element}
    //3. command = RemoveAT {index}
    //4. command = insert {element} {index}
    string[] commandParts = command.Split(" "); // ["Add", "element"] || ["Remove", "element" ] || ["RemoveAt", "index"]["Insert", "element" , "index"] 
    string commandName = commandParts[0]; // name could be  Delete or Insert 
    int element = int.Parse(commandParts[1]);

    //if (commandName == "Add")
    //{
    //    numbers.Add(element);
    //}
    //else if (commandName == "Remove")
    //{
    //    numbers.Remove(element);
    //}
    //else if (commandName == "RemoveAt")
    //{
    //    int index = int.Parse(commandParts[1]);
    //    numbers.RemoveAt(index);
    //}
    //else if (commandName == "Insert")
    //{
    //    int position = int.Parse(commandParts[2]); // ["Insert", "element" , "index"] 
    //    numbers.Insert(position, element);
    //}

    switch (commandName)
    {
        case "Add": numbers.Add(element); break;
        case "Remove": numbers.Remove(element); break;
        case "RemoveAt": int index = int.Parse(commandParts[1]);
                         numbers.RemoveAt(index);break;
        case "Insert": int position = int.Parse(commandParts[2]);
                       numbers.Insert(position, element);break;
        
    }

    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));
