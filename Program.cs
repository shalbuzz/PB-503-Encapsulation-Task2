
 
namespace Encapsulation_2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books books1 = new Books(1,"Scream1",350.6,"Horror");
            Books books2 = new Books(2, "Joker", 450, "Horror");
            Books books3 = new Books(3, "Forest-Gamp", 130.5,"Comedian");

            Library library = new Library();
            library.AddBooks(books1);
            library.AddBooks(books2);
            library.AddBooks(books3);

            var foundBook = library.GetBookById(1);
            if (foundBook != null) {

                Console.WriteLine($"{foundBook.Name} books");
            
            }

            else
            {
                Console.WriteLine("Not found");
            }

            var foundBookName = library.GetBookByName("Scream1");
            if (foundBookName != null) {

                Console.WriteLine($"{foundBookName.Name}, {foundBookName.Id}");
            }

            else
            {
                Console.WriteLine("Not found");
            }

            Books[] wantedBooks = library.GetBooksByName("Sc");

            foreach (var book in wantedBooks) {

                Console.WriteLine(book.Name );
            }

            Books[] filteredBook = library.GetFilteredBook("Horror");

            foreach (var book in filteredBook) {

                Console.WriteLine(book.Name);


            }

            Books[] filteredBooks = library.GetFilteredBooks(250, 450);

            foreach (var book in filteredBooks) {
                Console.WriteLine(book.Name);
            }
        }
    }
}
