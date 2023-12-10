string command = Console.ReadLine();

while (command != "end")
{
    string reversedWord = string.Empty;
    for (int i = command.Length - 1; i >= 0; i--)
    {
        reversedWord += command[i];
    }
    Console.WriteLine($"{command} = {reversedWord}");

    command = Console.ReadLine();


}
//char[] wordsAsArray = command.ToCharArray();
//Array.Reverse(wordsAsArray);
//string reversed = string.Join("", wordsAsArray);
//Console.WriteLine(reversed);

//    string reversed = string.Join("", command.ToCharArray().Reverse());
//    Console.WriteLine($"{command} = {reversed}");
//}

