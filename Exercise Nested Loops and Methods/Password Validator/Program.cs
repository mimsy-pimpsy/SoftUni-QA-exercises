string password = Console.ReadLine();
//1. валидна дължина -> [6-10]
bool isValidLength = password.Length >= 6 && password.Length <= 10;


//2. валидно съдържание --> само букви и цифри
bool isValidInput = CheckInput(password);



//3. валиден брой цифри >=2
bool isValidDigitsCount = CheckDigitCount(password);

//валидна парола --> изълнени са трите условия
if (isValidLength == true && isValidInput == true  && isValidDigitsCount == true)
{
    Console.WriteLine("Password is valid");
}
else
{   // invalid lenght
    if (isValidLength == false) 
    { 
        Console.WriteLine("Password must be between 6 and 10 characters"); 
    }
    //invalid input
    if (isValidInput == false)
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }
    // invalid digit count >=2
    if (isValidDigitsCount == false)
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
    
}
//method,which checks if  password's input is valid
//true--> valid input
//false--> invalid input 
static bool CheckInput(string password)
{
    //only letters ansd digits
    for (int position = 0; position <= password.Length - 1; position++)
    {
        char symbol = password[position]; 
        if (char.IsLetterOrDigit(symbol) == false)// if different from a letter or digit
        {
            return false; // breaks the method and does not continue
        }
    }
    //if we have checked all symbols and none of them were != letter/digit
    return true; //--> password's input is Valid 
}
//method,which checks if  password's  digits count is valid --> >=2
static bool CheckDigitCount (string password)
{
    int counter = 0; // digit count 
    for (int position = 0; position <= password.Length - 1; position++)
    {
        char symbol = password[position]; // check if symbols is a digit 
        if (char.IsDigit(symbol) == true)
        {
            counter++;
        }
     }
    // when the for-cycle is finished we know the final count of the digits and can check if is valid
    return counter >= 2;
}