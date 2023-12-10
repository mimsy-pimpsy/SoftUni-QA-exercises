﻿string command = Console.ReadLine();
List<Student> students = new List<Student>();


while (command != "end") //
{
    string[] studentData = command.Split(" ");
    string firstName = studentData[0];
    string lastName = studentData[1];
    int age = int.Parse(studentData[2]);
    string homeTown = studentData[3];

    Student currentStudent = new Student(
        firstName,
        lastName,
        age,
        homeTown);   

    students.Add(currentStudent);  //current student is added to the list witch opbjects type student 

    command = Console.ReadLine();
}

string lastCommand = Console.ReadLine();
List<Student>filteredStudents= students.Where(x => x.HomeTown == lastCommand).ToList();

foreach (Student student in filteredStudents)
{
    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
}
public class Student
{
    public Student(string firstName,string lastName, int age, string homeTown)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
        
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}

