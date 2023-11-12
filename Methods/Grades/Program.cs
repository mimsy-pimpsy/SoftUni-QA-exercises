namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void GradeInWords(double gradeParameter)
            {
                if (gradeParameter>= 2 && gradeParameter < 3) 
                {
                    Console.WriteLine("Fail");
                }
                else if (gradeParameter>= 3 && gradeParameter < 3.50)
                {
                    Console.WriteLine("Average");
                }
                else if (gradeParameter>= 3.50 && gradeParameter < 4.50)
                {
                    Console.WriteLine("Good");
                }
                else if (gradeParameter >= 4.50 && gradeParameter < 5.50)
                {
                    Console.WriteLine("Very good");
                }
                else
                {
                    Console.WriteLine("Excellent");
                }
            }   
            double grade = double.Parse(Console.ReadLine());
            GradeInWords(grade);
           
        }
    }
}