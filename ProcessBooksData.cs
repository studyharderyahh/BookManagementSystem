using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public class ProcessBooksData
    {
        // Dictionary to store stacks of books based on their category
        private readonly Dictionary<string, Stack<Book>> categorizedBooks;
        private readonly BookDataStructure bookDataStructure;

        // Constructor
        public ProcessBooksData(BookDataStructure bookDataStructure)
        {
            categorizedBooks = new Dictionary<string, Stack<Book>>()
            {
                //Stack for each kind of book we're keeping
                { "Computer Science", new Stack<Book>() },
                { "Networking", new Stack<Book>() },
                { "Mathematics", new Stack<Book>() },
                { "Software Development", new Stack<Book>() }
            };
            this.bookDataStructure = bookDataStructure;
        }

        // Method to categorize books based on their categories
        public void CategorizeBooks(Dictionary<string, Book> books)
        {
            foreach (var bookEntry in books)
            {
                Book book = bookEntry.Value;

                if (FilterBook(book))
                {
                    categorizedBooks[book.Category].Push(book);
                }
                else
                {
                    throw new InvalidOperationException($"Book '{book.BookName}' does not meet the conditions.");
                }
            }
        }

        // Method to check if a book is valid based on the criteria
        private bool FilterBook(Book book)
        {
            string[] validCategories = { "Computer Science", "Networking", "Mathematics", "Software Development" };
            return book.ReleasedYear > 1990 && validCategories.Contains(book.Category);
        }

        // Method to display books of a specific category in a DataGridView
        public void DisplayBooksByCategory(string category, DataGridView dataGridView)
        {
            if (categorizedBooks.ContainsKey(category))
            {
                var books = new List<Book>(categorizedBooks[category].ToArray());
                dataGridView.DataSource = books;
            }
            else
            {
                throw new ArgumentException($"Category '{category}' does not exist.");
            }
        }

        // Method to display all categorized books in a DataGridView
        public void DisplayAllCategories(DataGridView dataGridView)
        {
            var allBooks = categorizedBooks.Values.SelectMany(stack => stack.ToArray()).ToList();
            dataGridView.DataSource = allBooks;
        }
    }
}
