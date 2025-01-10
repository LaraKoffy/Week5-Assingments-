using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr8
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

       
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }
    }
