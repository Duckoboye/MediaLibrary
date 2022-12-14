// See https://aka.ms/new-console-template for more information

namespace MediaLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericMedia media = new Book("Of Mice and Men", 1937, "John Steinbeck", "123-456-789");
            Console.WriteLine((media.Info()));
        }
    }
}
