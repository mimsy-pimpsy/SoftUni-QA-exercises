using System.Threading.Channels;

namespace Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int classNumber = 1;
            double totalGrade = 0;
            int expelledCounter = 0;

            while (classNumber <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    expelledCounter++;
                }
                if (expelledCounter > 1)
                {
                    Console.WriteLine($"{studentName} has been excluded at {classNumber - 1} grade");
                    break;
                }
                totalGrade += grade;
                classNumber++;
                continue;
            }
            double averageGrade = totalGrade / 12;
            if (expelledCounter <=1)
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
            }
            
        }
        
    }
}