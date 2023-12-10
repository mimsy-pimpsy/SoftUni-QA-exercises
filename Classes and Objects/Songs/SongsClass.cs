int songsCount = int.Parse(Console.ReadLine());
List<Song> songs = new List<Song>();

for (int i = 0; i < songsCount; i++) //{typeList}_{name}_{time}
{
    string[] songComponents = Console.ReadLine().Split("_");
    string typeList = songComponents[0];
    string name = songComponents[1];
    string time = songComponents[2];

    Song currentSong = new Song()
    {
        TypeList = typeList,
        Name = name,
        Time = time
    };

    songs.Add(currentSong);
}

string commandType = Console.ReadLine();
if (commandType == "all")
{
    foreach (Song song in songs)
    {
        Console.WriteLine(song.Name);
    }
}
else
{
    List<Song> filteredSongs = songs.Where(x => x.TypeList == commandType).ToList();
    foreach (Song song in filteredSongs)
    {
        Console.WriteLine(song.Name);
    }
}
class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}

