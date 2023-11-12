namespace ProductOfThreeNumbers2ndVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            int negativeNumberCount = 0;


            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                if (firstNumber < 0)
                {
                    negativeNumberCount++;
                }
                if (secondNumber < 0)
                {
                    negativeNumberCount++;
                }
                if (thirdNumber < 0)
                {
                    negativeNumberCount++;
                }
                if (negativeNumberCount == 0 || negativeNumberCount == 2)
                {
                    Console.WriteLine("positive");
                }
                else
                {
                    Console.WriteLine("negative");
                }


            }
        }
    }
}