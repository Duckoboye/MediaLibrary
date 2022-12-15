namespace MediaLibrary;

public class Book : GenericMedia
{
    private readonly string _isbn;
    private readonly int _pageCount;
    public Book(string title, int releaseYear, string author, int pageCount, string isbn)
    {
        Title = title;
        ReleaseYear = releaseYear;
        Author = author;
        _isbn = isbn;
        _pageCount = pageCount;
    }

    public override string Info()
    {
        return $"{Title} by {Author}, released {ReleaseYear}. pagecount: {_pageCount}, ISBN: {_isbn}";
    }
}