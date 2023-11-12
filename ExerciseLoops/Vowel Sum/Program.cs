namespace Vowel_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int count = int.Parse(Console.ReadLine());
            //int result = 0;
            //int value = 0;
            

            //for (int i = 1; i <= count; i++)
            //{
            //    char vowel = char.Parse(Console.ReadLine());
            //    if (vowel == 'a')
            //    {
            //        value = 1;
            //        result += value;
            //    }
            //    else if (vowel == 'e')
            //    {
            //        value = 2;
            //        result += value;
            //    }
            //    else if (vowel == 'i')
            //    {
            //        value = 3;
            //        result += value;
            //    }
            //    else if (vowel == 'o')
            //    {
            //        value = 4;
            //        result += value;
            //    }
            //    else if (vowel == 'u')
            //    {
            //        value = 5;
            //        result += value;
            //    }

            int countCharacters = int.Parse(Console.ReadLine());
            int sumOfValue = 0; //сума от стойностите на гласните бкви

            for ( int i  = 0; i <  countCharacters; i++ ) 
            {
                char symbol = char.Parse(Console.ReadLine()); // въведен символ
                // проверка дали е гласна буква --> a, e i, o ,u 
                // серия от проверки за точни стойности --> switch

                switch (symbol)
                {
                    case 'a': sumOfValue += 1; break;
                    case 'e': sumOfValue += 2; break;
                    case 'i': sumOfValue += 3; break;
                    case 'o': sumOfValue += 4; break;
                    case 'u': sumOfValue += 5; break;
                }
                

            }
            Console.WriteLine(sumOfValue);

        }
            
        }
    }
