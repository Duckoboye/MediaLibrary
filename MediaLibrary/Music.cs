namespace MediaLibrary;

public class Music : GenericMedia
{
    private readonly string _isbn;
    public Music(string title, int releaseYear, string author, string isbn, string singer)
    {
        Title = title;
        ReleaseYear = releaseYear;
        Author = author;
        _isbn = isbn;
    }

    public override string Info()
    {
        return $"{Title} by {Author}, released {ReleaseYear}. ISBN: {_isbn}";
    }
}