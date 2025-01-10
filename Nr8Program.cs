namespace Nr8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the library capacity: ");
            int capacity;
            while (!int.TryParse(Console.ReadLine(), out capacity) || capacity <= 0)
            {
                Console.Write("Please enter a valid library capacity: ");
            }

            Library library = new Library(capacity);

            
            string addMoreBooks;
            do
            {
                Console.WriteLine("Enter book details:");

                Console.Write("Enter the title: ");
                string title = Console.ReadLine();

                Console.Write("Enter the author: ");
                string author = Console.ReadLine();

                Book newBook = new Book(title, author);
                library.AddBook(newBook);

                Console.Write("Do you want to add another book? (y/n): ");
                addMoreBooks = Console.ReadLine().ToLower();
            } while (addMoreBooks == "y");

          
            library.DisplayBooks();
        }
}
