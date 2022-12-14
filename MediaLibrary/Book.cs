namespace MediaLibrary;

public class Book : GenericMedia
{
    private readonly string _isbn;
    public Book(string title, int releaseYear, string author, int pageCount, string isbn)
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