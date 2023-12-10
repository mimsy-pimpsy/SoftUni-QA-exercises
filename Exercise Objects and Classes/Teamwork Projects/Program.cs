int teamsCount = int.Parse(Console.ReadLine());

for  (int i = 1; i <= teamsCount; i++)
{
    string teamData = Console.ReadLine();
    string creator = teamData.Split("-")[0];
    string teamName = teamData.Split("-")[1];

    Team team = new Team(creator, teamName);
    Console.WriteLine($"Team {teamName} has been created by {creator}!");
}

string command = Console.ReadLine();

while (command != "end of assignment")
{
    
    command = Console.ReadLine();
    string userToAdd = command.Split("->")[0];
    string teamToJoin = command.Split("->")[1];
}