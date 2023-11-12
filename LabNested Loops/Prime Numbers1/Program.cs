namespace Prime_Numbers1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());    

            for (int currentNumber = start; currentNumber <= end; currentNumber++)
            {
                bool isPrime = true;
                int divisor = 2;
                while (divisor <= end )
                {
                    if(currentNumber % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }

                    divisor++;
                }


            }
        }
    }
}