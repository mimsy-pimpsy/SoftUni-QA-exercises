﻿Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

string input = Console.ReadLine();

while (input != "End")
{
    string[] inputArray = input.Split(" -> ");
    string company = inputArray[0];
    string empoloyeeID = inputArray[1];

    if (!companies.ContainsKey(company))
    {
        companies.Add(company, new() { empoloyeeID});
    }

    if (!companies[company].Contains(empoloyeeID))
    {
        companies[company].Add(empoloyeeID);
    }

    input = Console.ReadLine();
}
foreach (KeyValuePair<string, List<string>> currentCompany in companies)
{
    Console.WriteLine(currentCompany.Key);
    foreach(string currentEmployeeID in currentCompany.Value)
    {
        Console.WriteLine($"-- {currentEmployeeID}");
    }
}