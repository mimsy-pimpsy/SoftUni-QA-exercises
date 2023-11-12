// letter combination{letter1}{letter2}{letter3}

char startLetter = char.Parse(Console.ReadLine()); // start letter 
char endtLetter = char.Parse(Console.ReadLine()); // end letter
char excludedLetter = char.Parse(Console.ReadLine()); // LETTER TO BE EXCLUDED
int combinationCounter = 0;

// letter1 [startLetter; endLetter]
// letter2 [startLetter; endLetter]
// letter3 [startLetter; endLetter]
for (char letter1 = startLetter; letter1 <= endtLetter; letter1++)
{                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
    for (char letter2 = startLetter; letter2 <= endtLetter; letter2++)
    {
        for (char letter3 = startLetter; letter3 <= endtLetter; letter3++)
        {
            //// letter combination{letter1}{letter2}{letter3}
            ///print only if excludedLetter is excluded
            if(letter1 != excludedLetter &&  letter2 != excludedLetter && letter3 != excludedLetter) {
                Console.Write($"{letter1}{letter2}{letter3} ");
                combinationCounter++;
            }

        }
    }
    
}
Console.WriteLine();
Console.WriteLine(combinationCounter);


