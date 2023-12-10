using Articles;
using System.ComponentModel.DataAnnotations;

string input = Console.ReadLine();

string[] articleData = input.Split(", ");
string title = articleData[0];
string content = articleData[1];
string author = articleData[2];

Article article = new Article(title, content, author);

int commandCount = int.Parse(Console.ReadLine());

for (int i = 1; i <= commandCount; i++)
{
    string command = Console.ReadLine();
    string[] commandParts = command.Split(": ");
    string commandName = commandParts[0];
    string commandParameter = commandParts[1];

    switch (commandName)
    {
        case "Edit":

            article.Edit(commandParameter);
            break;
        case "ChangeAuthor":
            
            article.ChangeAuthor(commandParameter);
            break;

        case "Rename":
            
            article.Rename(commandParameter);
            break;

    }
}
Console.WriteLine(article.ToString());



