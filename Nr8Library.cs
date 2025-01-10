using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr8
{
    public class Library
    {
        private Book[] books;
        private int currentCount;

        
        public Library(int capacity)
        {
            books = new Book[capacity];
            currentCount = 0;
        }

     
        public void AddBook(Book book)
        {
            if (currentCount < books.Length)
            {
                books[currentCount] = book;
                currentCount++;
            }
            else
            {
                Console.WriteLine("Library is full, cannot add more books.");
            }
        }

       
        public void DisplayBooks()
        {
            if (currentCount == 0)
            {
                Console.WriteLine("No books in the library.");
                return;
            }

            Console.WriteLine("Books in the Library:");
            for (int i = 0; i < currentCount; i++)
            {
                books[i].DisplayBookInfo();
            }
        }
