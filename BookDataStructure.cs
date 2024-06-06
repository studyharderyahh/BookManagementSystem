using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem
{
    public class BookDataStructure
    {
        public Queue<Book> AcceptableBooks { get; set; }

        // Constructor to initialize the book queue
        public BookDataStructure()
        {
            AcceptableBooks = new Queue<Book>();
        }

        // Method to enqueue a book if it meets the required conditions
        public void Enqueue(Book book)
        {
            if (IsValidBook(book))
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
        private bool IsValidBook(Book book)
        {
            string[] validCategories = { "Computer Science", "Networking", "Mathematics", "Software Development" };
            return book.ReleasedYear > 1990 && validCategories.Contains(book.Category);
        }
    }
}
