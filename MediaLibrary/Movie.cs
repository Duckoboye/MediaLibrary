namespace MediaLibrary;

public class Movie : GenericMedia
{
    private readonly string _isbn;
    public Movie(string title, int releaseYear, string author, string resolution, string[] leadingRoles)
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