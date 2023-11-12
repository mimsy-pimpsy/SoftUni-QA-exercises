namespace OnTimeforExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int examHour = int.Parse(Console.ReadLine());
          int examMinutes = int.Parse(Console.ReadLine());
          int arrivalHour = int.Parse(Console.ReadLine()); 
          int arrivalMinutes = int.Parse(Console.ReadLine());

            int totalArrivalMinutes = arrivalHour * 60 + arrivalMinutes; 
            int totalExamMinutes = examHour * 60 + examMinutes;

            int difference = totalArrivalMinutes - totalExamMinutes;

            if (difference < 30)
            {

            }

        }
    }
}