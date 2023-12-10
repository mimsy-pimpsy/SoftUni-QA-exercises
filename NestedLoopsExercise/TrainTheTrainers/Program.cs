using System.Threading.Channels;

namespace TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
          int juryCount = int.Parse(Console.ReadLine());
          int presentationCount = 0;
          double totalGrade = 0;



           while (true)
           {
                string presentationName = Console.ReadLine();
                
                if (presentationName == "Finish")
                {
                    break;
                }
                presentationCount++;
                double gradesSum = 0;

                for (int juryMember = 1;juryMember <= juryCount; juryMember++)
                {
                    double currentGrade = double.Parse(Console.ReadLine());
                    gradesSum += currentGrade;
                    totalGrade += currentGrade;
                }
                Console.WriteLine($"{presentationName} - {gradesSum / juryCount:f2}.");
            
            }
            Console.WriteLine($"Student's final assessment is {totalGrade/ (presentationCount* juryCount):f2}.");

        } 
    }
}