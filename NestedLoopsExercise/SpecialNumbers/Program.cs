namespace SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            for (int digit = 1111; digit<= 9999; digit++ )
            {
                string digits = digit.ToString();
                bool isSpecial = true;
                for (int currentDigitIndex = 0; currentDigitIndex < digits.Length; currentDigitIndex++)
                {
                    int currentDigit = int.Parse(digits[currentDigitIndex].ToString());

                    if (currentDigit == 0 || number % currentDigit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    

                }
                if (isSpecial)
                {
                    Console.Write(digit + " ");
                }

            }











            //int firstNumber = int.Parse(Console.ReadLine());
            //int secondNumber = int.Parse(Console.ReadLine());

            //for (int i = firstNumber; i <= secondNumber; i++)
            //{
            //    string currentNumber = i.ToString();
            //    int oddSum = 0;
            //    int evenSum = 0;
            //    for (int j = 0; j < currentNumber.Length; j++)
            //    {
            //        int currentDigit = int.Parse(currentNumber[j].ToString());
            //        if (j % 2 == 0)
            //        {
            //            evenSum += currentDigit;
            //        }
            //        else
            //        {
            //            oddSum += currentDigit;
            //        }

            //    }
            //    if (oddSum == evenSum)
            //    {
            //        Console.Write(i + " ");
            //    }

            }
        }
}