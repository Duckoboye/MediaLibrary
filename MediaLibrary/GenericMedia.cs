using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MediaLibrary;

public abstract class GenericMedia
{ 
    protected string Title = null!;
    protected int ReleaseYear;
    protected string Author = null!;

    public abstract string Info();


}