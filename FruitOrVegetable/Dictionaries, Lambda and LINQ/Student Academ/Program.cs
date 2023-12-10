Dictionary<string, List <double>> students = new(); // list 0-gradesum, 1 count

int n = int.Parse(Console.ReadLine()); // pair of rows 

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double currentGrade = double.Parse(Console.ReadLine());


    if (students.ContainsKey(name))
    {
        students[name][0] += currentGrade;
        students[name][1]++;
    }
    else
    {
        students.Add(name, new() { currentGrade, 1});
    }
}
var excellent = students.Where(x => x.Value.Average() >= 4.50);

foreach(var student in excellent)
{
    Console.WriteLine($"{student.Key} -> {student.Value.Average()}");
}

