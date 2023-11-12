namespace Special_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int initialNumber = number; // initial number, which will not be amended 
            bool isSpecial = true;

            //bool isSpecial = true;числото е специално
            //bool isSpecial = false;числото не специално
            //1.Взимаме цифрите на числото : 515 --> взимам 5 и проверявам дали дели 515 без остатък и я премахвам
            //обхождане на цифрите на числа
            //1.първо взимаме последната цифра
            //2.проверка дали дели числото 
            //3. премахвам последната цифра 
            // стоп: когато нямамe повече цифри-> number <=0;
            //продължаваме: имаме налични цифри -> number > 0 ;

            while (number > 0)
            {
                //1.първо взимаме последната цифра
                int lastDigit = number % 10;
                //2.проверка дали дели числото без остатък
                if (initialNumber % lastDigit != 0)
                {
                    isSpecial = false;
                    break;
                }
                number = number / 10; // get rid of the last digit 
            }
            //.СТОП на цикъла, когато:
            //1. преминали сме през всички цифри -> вс. цифри делят числото isSpecial = true;
            //2. имам ецифрам която не дели числото без остатък ->isSpecial = false;
            if (isSpecial)
            {
                Console.WriteLine($"{initialNumber} is special");
            }
            else
            {
                Console.WriteLine($"{initialNumber} is not special");
            }

        }
    }
}