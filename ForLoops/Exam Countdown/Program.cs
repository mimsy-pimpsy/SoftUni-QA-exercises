namespace Exam_Countdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());

            for (int i = 0; i < d; i++)
            {
                int currentDay = d - i;
                Console.WriteLine($"{currentDay} days before the exam");
            }
            Console.WriteLine("The exam has come");
        }
    }
}