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
            processBooksData = new ProcessBooksData();
        }

        // Method to load books from a file
        public BookDataStructure LoadBooksFromFile(string filePath)
        {
            return ReadDataFile.LoadBooksFromFile(filePath);
        }

        // Method to add books manually
        public void AddBooksManually(Book book)
        {
            bookDataStructure.AddBook(book);
            processBooksData.AddManuallyAddedBooks(book);
        }
        public void AddBooksFromLoadedFile(BookDataStructure bookDataStructure)
        {
            processBooksData.AddBooksFromLoadedFile(bookDataStructure);
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
