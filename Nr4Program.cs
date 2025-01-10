namespace Nr4
{
    internal class Program
    {
        static void Start()
        {

            Console.WriteLine("Enter the book title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter the author of the book:");
            string author = Console.ReadLine();


            Book book = new Book(title, author);


            book.DisplayBookInfo();
        }

        static void Main(string[] args)
        {

            Start();
        }
    }
}
