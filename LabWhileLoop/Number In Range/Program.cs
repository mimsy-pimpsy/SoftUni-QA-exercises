namespace Number_In_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            bool isValid = false;

            while (number < 1 || number > 100)
            {
                isValid = false;
                number = int.Parse(Console.ReadLine());
                if (number >= 1 && number <= 100)
                {
                    isValid = true;
                    break;
                }
            }
            Console.WriteLine(number);

            //int number = int.Parse(Console.ReadLine());
            //bool isValid = number >= 1 && number <= 100;

            //while (!isValid) 
            //{
            //    number = int.Parse(Console.ReadLine());
            //    isValid = number >= 1 && number <= 100;
            //}
            //Console.WriteLine(number);
        }
          
        }
    }
