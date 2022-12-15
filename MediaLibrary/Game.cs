namespace MediaLibrary;

public class Game : GenericMedia
{
    private readonly string _publisher;
    public Game(string title, int releaseYear, string author, string publisher)
    {
        Title = title;
        ReleaseYear = releaseYear;
        Author = author;
        _publisher = publisher;
    }

    public override string Info()
    {
        return $"{Title}, developed by {Author}, released {ReleaseYear}. Publisher: {_publisher}.";
    }
}