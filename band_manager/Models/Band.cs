namespace band_manager.Models;
class Band
{
    private List<Album> albuns = [];
    private List<int> grades = [];
    public string Name { get; }
    public double Average => grades.Average();
    public List<Album> Albuns => albuns;
    
    public Band(string name)
    {
        Name = name;
    }

    public void AddAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void AddGrade(int grade)
    {
        grades.Add(grade);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"Discografia da banda {Name}");
        foreach(Album album in albuns)
        {
            Console.WriteLine($"Album: {album.Name} ({album.TotalTime})");
        }
    }



}