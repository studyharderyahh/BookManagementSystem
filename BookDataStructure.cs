using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem
{
    public class BookDataStructure
    {
        private static readonly object lockObject = new object();
        private static BookDataStructure instance;
        public Queue<Book> AcceptableBooks { get; private set; }

        // Constructor to initialize the book queue
        public BookDataStructure()
        {
            AcceptableBooks = new Queue<Book>();
        }

        // Singleton pattern to ensure only one instance of BookDataStructure
        public static BookDataStructure GetInstance()
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new BookDataStructure();
                }
                return instance;
            }
        }

        // Method to enqueue a book if it meets the required conditions
        public void Enqueue(Book book)
        {
            if (FilterBook(book))
            {
                AcceptableBooks.Enqueue(book);
            }
            else
            {
                throw new InvalidOperationException($"Book '{book.BookName}' does not meet the conditions.");
            }
        }

        // Method to get the count of books in the queue
        public int Count()
        {
            return AcceptableBooks.Count;
        }

        // Check if the book meets the required conditions
        private bool FilterBook(Book book)
        {
            string[] validCategories = { "Computer Science", "Networking", "Mathematics", "Software Development" };
            return book.ReleasedYear > 1990 && validCategories.Contains(book.Category);
        }
    }
}
