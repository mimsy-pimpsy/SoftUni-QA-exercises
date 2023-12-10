namespace Students
{
    internal class Program
    {
        public class Students
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public Students(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }
        }
        static void Main(string[] args)
        {
            //{first name} {second name} {grade}
            int count = int.Parse(Console.ReadLine());


            List<Students> students = new List<Students>();

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string[] studentData = input.Split().ToArray();
                string firstName = studentData[0];
                string lastName = studentData[1];
                double grade = double.Parse(studentData[2]);

                Students student = new Students(firstName, lastName, grade);
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Grade = grade;

                students.Add(student);
            }

            students = students.OrderByDescending(s => s.Grade).ToList();
            foreach (Students student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }

}