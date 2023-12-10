using System.Data;

string command = Console.ReadLine(); 
List <Student> students = new List<Student>();
while (command != "end")
{
    string[] studentInfo = command.Split(" ");
    string firstName = studentInfo[0];
    string lastName = studentInfo[1];
    int age = int.Parse(studentInfo[2]);
    string homeTown = studentInfo[3];

    Student student = new Student()
    { FirstName = firstName,
    LastName = lastName,
    Age = age,
    HomeTown = homeTown};

    students.Add(student);
    
    command = Console.ReadLine();
}
 
string town = Console.ReadLine();
List<Student> filteredStudents = students.Where(x => x.HomeTown == town).ToList();
foreach (Student student  in filteredStudents)
{
    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
}


class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age{ get; set; }
    public string HomeTown { get; set; }
}