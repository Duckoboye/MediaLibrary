// See https://aka.ms/new-console-template for more information

namespace MediaLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> leadingRoles = new Dictionary<string, string>();
            leadingRoles.Add("William afton", "Pink guy");
            leadingRoles.Add("John johnson", "Steve");
            leadingRoles.Add("Christian bale", "Patrick Bateman");
            leadingRoles.Add("Jeffrey Pezos", "Bengt Perrson");
            Movie movie = new Movie("Titel", 1984, "me", "1080p", new Dictionary<string, string>());
            
            //GenericMedia media = new Book("Of Mice and Men", 1937, "John Steinbeck", "123-456-789");

            Console.WriteLine(movie.Info());
            
        }
    };
}
