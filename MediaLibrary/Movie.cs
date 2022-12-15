namespace MediaLibrary;

public class Movie : GenericMedia
{
    private readonly string _resolution;
    private readonly Dictionary<string,string> _leadingRoles;
    public Movie(string title, int releaseYear, string author, string resolution, Dictionary<string, string> leadingRoles)
    {
        Title = title;
        ReleaseYear = releaseYear;
        Author = author;
        _resolution = resolution;
        _leadingRoles = leadingRoles;
    }

    private string GetRoles()
    {
        return _leadingRoles.Aggregate("", (current, role) => $"{current}{role.Key} as {role.Value}. ");
    }

    public override string Info()
    {
        return $"{Title} by {Author}, released {ReleaseYear}. {_resolution} | {GetRoles()}";
    }
}