namespace ElementThatEqualsToTheSumOfOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int greatestNumber = int.MinValue; 
            int sumOfAll = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > greatestNumber)
                {
                    greatestNumber = number;
                }
                sumOfAll += number;
            }
            sumOfAll -= greatestNumber;
            if (sumOfAll == greatestNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOfAll}");
            }
            else 
            {
                int diff = Math.Abs(sumOfAll - greatestNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }

        }
    }
}