using System.Xml.Linq;

namespace ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int maxPoorGrades = int.Parse(Console.ReadLine());

            int numberOfPoorGrades = 0;
            double gradesTotalSum = 0;
            int gradesCount = 0;
            string lastProblem = string.Empty;

            while (numberOfPoorGrades < maxPoorGrades)
            {
                string currentProblem = Console.ReadLine();
                if (currentProblem == "Enough") 
                {
                    break;
                }
                lastProblem = currentProblem;
                int currentGrade = int.Parse(Console.ReadLine());

                gradesTotalSum += currentGrade;
                gradesCount++;

                if (currentGrade <= 4)
                {
                    numberOfPoorGrades++;
                }
            }
            if (numberOfPoorGrades == maxPoorGrades)
            {
                Console.WriteLine($"You need a break, {numberOfPoorGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesTotalSum/gradesCount:f2}");
                Console.WriteLine($"Number of problems: {gradesCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            
        }
    }
}