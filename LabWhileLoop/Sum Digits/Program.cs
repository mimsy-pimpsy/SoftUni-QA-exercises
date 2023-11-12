namespace Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());
            //string numberAsText = number.ToString();
            //int sum = 0;

            //for (int index = 0; index < numberAsText.Length; index++)
            //{
            //    int currentDigit = int.Parse(numberAsText[index].ToString());
            //    sum += currentDigit;
            //}
            //Console.WriteLine(sum);

            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            Console.WriteLine(sum);

        }
    }
}