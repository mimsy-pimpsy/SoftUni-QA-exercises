namespace Sequence_2k___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currentNumber = 1;
            while (currentNumber <= number)
            {
                Console.WriteLine(currentNumber); 
                currentNumber = (2 * currentNumber + 1);
            }
        }
    }
}