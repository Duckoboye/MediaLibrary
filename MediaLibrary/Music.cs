namespace MediaLibrary;

public class Music : GenericMedia
{
    private readonly uint _playTime;
    private readonly string _singer;
    public Music(string title, int releaseYear, string author, uint playTime, string singer)
    {
        Title = title;
        ReleaseYear = releaseYear;
        Author = author;
        _playTime = playTime;
        _singer = singer;
    }

    public override string Info()
    {
        return $"{Title} by {Author}, released {ReleaseYear}. Playtime: {_playTime}. Main singer: {_singer}";
    }
}