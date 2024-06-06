using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public class DataManager
    {
        private readonly BookDataStructure bookDataStructure;
        private readonly ProcessBooksData processBooksData;

        public DataManager()
        {
            bookDataStructure = BookDataStructure.GetInstance();
            processBooksData = new ProcessBooksData(bookDataStructure);
        }

        // Method to load books from a file
        public Dictionary<string, Book> LoadBooksFromFile(string filePath)
        {
            var readDataFile = ReadDataFile.GetInstance();
            return readDataFile.ReadBooks(filePath);
        }

        // Method to add books manually
        public void AddBooksManually(Book book)
        {
            bookDataStructure.Enqueue(book);
            processBooksData.AddManuallyAddedBooks();
        }
        public void AddBooksFromLoadedFile(Dictionary<string, Book> loadedBooks)
        {
            processBooksData.AddBooksFromLoadedFile(loadedBooks);
        }

        // Method to get total count of books
        public int GetTotalBookCount()
        {
            return bookDataStructure.Count();
        }

        // Method to display all categories of books
        public void DisplayAllCategories(DataGridView dataGridView)
        {
            processBooksData.DisplayAllCategories(dataGridView);
        }

        // Method to display books by a specific category
        public void DisplayBooksByCategory(string category, DataGridView dataGridView)
        {
            processBooksData.DisplayBooksByCategory(category, dataGridView);
        }
    }
}
