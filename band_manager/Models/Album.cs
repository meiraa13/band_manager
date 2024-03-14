namespace band_manager.Models;
class Album
{
    private List<Music> musics = [];
    public string Name {  get; }
    public int TotalTime => musics.Sum(music => music.Duration);
    public List<Music> Musics => musics;

    public Album(string name)
    {
        Name = name;
    }

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void ShowAlbumMusics()
    {
        Console.WriteLine($"Lista de musicas do album {Name}:\n");
        foreach (Music music in musics)
        {
            Console.WriteLine($"Musica: {music.Name}");
        }
        Console.WriteLine($"Tempo de duração do album: {TotalTime}");
    }
}