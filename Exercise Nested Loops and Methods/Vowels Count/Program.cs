static string CheckVowelCount(string text)
{
    int counter = 0;
    for (int letter = 0; letter < text.Length; letter++)
    {
        string currentLetter = text[letter].ToString();
        switch (currentLetter)
        {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
            case "A":
            case "E":
            case "I":
            case "O":
            case "U": counter++; break;
            default: break;
        }
    }
    return counter.ToString();  
        
}
string text = Console.ReadLine();
int counter = int.Parse(CheckVowelCount (text));
Console.WriteLine(counter);
