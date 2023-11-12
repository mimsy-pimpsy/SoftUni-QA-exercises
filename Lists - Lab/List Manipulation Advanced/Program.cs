List<int> numbers = Console.ReadLine() // 4 19 2 53 6 43
    .Split(" ")   // ["4", "19", "2", "53", "6", "43"]
    .Select(int.Parse) // {4, 19, 2, 53, 6, 43}
    .ToList();  //list with above mentioned int is created
List<int> evenNumbers = new List<int>();
List<int> oddNumbers = new List<int>();

string command = Console.ReadLine(); // input from the console 

while (command != "end") // loop will continue until it meets a command == "end"
{
    if (command.StartsWith("Contains"))
    {
        // command = "Contains {number}".Split -->["Contains", "number"]

        int numberConatined = int.Parse(command.Split(" ")[1]);
        if (numbers.Contains(numberConatined)) // check if the list contains the number and if so - print "Yes",otherwise print "No such number"
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (command == "PrintEven") //print all the even numbers, separated by a space
    {
        
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);

            }
        }
        Console.WriteLine(string.Join(" ", evenNumbers));
        
    }
    else if (command == "PrintOdd") //print all the odd numbers, separated by a space
    {
        //command == "PrintOdd"

        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                oddNumbers.Add(number);

            }
        }
        Console.WriteLine(string.Join(" ", oddNumbers));
    
    }
    else if (command == "GetSum")
    {
       Console.WriteLine(numbers.Sum());
    }
    else if (command.StartsWith("Filter"))
    {
        string commandOperator = command.Split(" ")[1]; // Filter >= 23 --.["Filter" , "<=", "23"]
        int numberToCheck = int.Parse(command.Split(" ")[2]);
        switch (commandOperator)
        {
            case "<":
                numbers.RemoveAll(number => number >= numberToCheck);
               
                break;
            case ">":
                numbers.RemoveAll(number => number <= numberToCheck);
                
                break;
            case ">=":
                numbers.RemoveAll(number => number < numberToCheck);
                
                break;
            case "<=":
                numbers.RemoveAll(number => number > numberToCheck);
                
                break;

        }
    }
    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));
