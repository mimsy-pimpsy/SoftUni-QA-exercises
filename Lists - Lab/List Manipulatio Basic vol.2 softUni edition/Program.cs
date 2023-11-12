List<int> numbers = Console.ReadLine() // 4 19 2 53 6 43
    .Split(" ")   // ["4", "19", "2", "53", "6", "43"]
    .Select(int.Parse) // {4, 19, 2, 53, 6, 43}
    .ToList();  //list with above mentioned int is created

string command = Console.ReadLine(); // input from the console 

while (command != "end") // loop will continue until it meets a command == "end"
{
    if (command.StartsWith("Add"))
    {
        //command == "Add {number}" .Split--> ["Add", "3"] we get an array with strings 

        int numberToAdd = int.Parse(command.Split(" ")[1]); // We take the number at [1] position
                                                            // "Add {number}.Split--> ["Add", "3"]--> [1] and parse it to int-->3

        //we should add this number to the end of the list 
        numbers.Add(numberToAdd); // 3 is added to the end of the list 
    }
    else if (command.StartsWith("RemoveAt"))
    {
        //command == "RemoveAt {index}.Split--> ["RemoveAt", "1"]

        int positionToBeRemovedFrom = int.Parse(command.Split(" ")[1]);// We should remove the number from the [1] position 
                                                                       // we take the number from the [1] position via the Split and we parse it to int --> 1
        numbers.RemoveAt(positionToBeRemovedFrom);
    }
    else if (command.StartsWith("Remove"))
    {
            //command == "Remove {number}.Split--> ["Remove", "4"]
            int numberToRemove = int.Parse(command.Split(" ")[1]); // "Remove {number}.Split--> ["Remove", "4"]--> [1] 0--> we take the number at [1]
            
            //to remove the number from the list                    // position and parse it to int and we get --> 4 --> numberToRemove == 4

            numbers.Remove(numberToRemove);
    }
    else if (command.StartsWith("Insert"))
    {
            //command = ["Insert", "element" , "index"]
            int numberToBeInserted = int.Parse(command.Split(" ")[1]);
            int indexoBeInsertedAt = int.Parse(command.Split(' ')[2]);

            numbers.Insert(indexoBeInsertedAt, numberToBeInserted);

    }
        command = Console.ReadLine();  
}
Console.WriteLine(string.Join(" ", numbers));
