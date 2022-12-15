// See https://aka.ms/new-console-template for more information

namespace MediaLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie("Titel", 1984, "me", "1080p", new Dictionary<string, string>
            {
                { "William afton", "Pink guy" },
                { "John johnson", "Steve" },
                { "Christian bale", "Patrick Bateman" },
                { "Jeffrey Pezos", "Bengt Perrson" }
            });
            Book book = new Book("1984", 1984, "George Orwell", 3000, "ISBN-123-123-123");
            Music music = new Music("gaming", 1941, "micheal bay", 300, "micheal bay");
            Game game = new Game("pro gaming 9K", 2020, "Hideo Kojima", "Nintenod");
            

            Console.WriteLine(movie.Info());
            Console.WriteLine(book.Info());
            Console.WriteLine(music.Info());
            Console.WriteLine(game.Info());
            
        }
    };
}
