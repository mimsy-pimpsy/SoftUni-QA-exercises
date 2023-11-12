namespace Special_Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int stopNumber = int.Parse(Console.ReadLine());
            //int numbers;
            //int previousNum = 0;
            //while ((numbers = int.Parse(Console.ReadLine())) != stopNumber)
            // {

            //    previousNum = numbers;

            //}
            //Console.WriteLine(previousNum = previousNum + (previousNum * 20/100));
            int stopNumber = int.Parse(Console.ReadLine());
            int numbers = int.Parse(Console.ReadLine());

            while (numbers != stopNumber)
            {
                int previousNumber = numbers;
                numbers = int.Parse(Console.ReadLine());
                if (numbers == stopNumber)
                {
                    previousNumber += (previousNumber * 20 / 100);
                    Console.WriteLine(previousNumber);
                    break;

                }

            }
        } 
    }
}