namespace Division_to_2__3_and_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            int count2 = 0; // count of numbers divisable by 2
            int count3 = 0; // count of numbers divisable by 3
            int count4 = 0; // count of numbers divisable by 4

            for (int number = 1; number <= countNumbers; number++)
            {
                int value = int.Parse(Console.ReadLine()); // value of number
                // check if it is devisable by 2, 3 or 4
                if (value % 2 == 0) // devisable by 2
                {
                    count2++;
                }
                if (value % 3 == 0)// devisable by 3
                {
                    count3++;
                }
                if (value % 4 == 0)// devisable by 4
                {
                    {
                        count4++;
                    }
                }
            }
            double percent2 = count2 * 1.0 / countNumbers * 100;
            double percent3 = count3 * 1.0 / countNumbers * 100;
            double percent4 = count4 * 1.0 /countNumbers * 100;
            Console.WriteLine($"{percent2:F2}%");
            Console.WriteLine($"{percent3:F2}%");
            Console.WriteLine($"{percent4:F2}%");

        }
    }
}