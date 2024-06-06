using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public class BookDataStructure : IEnumerable<Book>
    {
        // Criteria for filtering books
        private static int filterReleasedYear = 1990;
        private static string[] allowedBookCategory = { "Computer Science", "Networking", "Mathematics", "Software Development" };

        private static readonly object lockObject = new object();
        private static BookDataStructure instance;
        public Queue<Book> books { get; private set; }

        // Constructor to initialize the book queue
        public BookDataStructure()
        {
            books = new Queue<Book>();
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
        public void AddBook(Book book)
        {
            /*
             // For debugging purpose only
             StringBuilder message = new StringBuilder();
             int count = books.Count;

             // Dequeue each book and append its string representation to the message
             for (int i = 0; i < count; i++)
             {
                 Book bk = books.Dequeue();
                 message.AppendLine(bk.ToString());
                 // Enqueue the book back to the queue
                 books.Enqueue(bk);
             }

             // Display the message in a MessageBox
             MessageBox.Show(message.ToString());

            */

            if (FilterBook(book))
            {
                books.Enqueue(book);
            }
            else
            {
                // Check if it can be logged
                MessageBox.Show($"Book Name '{book.BookName}' does not meet the conditions.");
            }



        }

        // Check if the book meets the required conditions
        public bool FilterBook(Book book)
        {
            bool filterFlag = book.ReleasedYear >= filterReleasedYear && allowedBookCategory.Contains(book.Category);
            return filterFlag;
        }


        public int Count()
        {
            return books.Count;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
