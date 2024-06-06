using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public class ReadDataFile
    {
        private static ReadDataFile fileReader;
        //private string FilePath = "SampleBooks.txt";

        // Criteria for filtering books
        private static int filterReleasedYear = 1990;
        private static string[] allowedBookCategory = { "Computer Science", "Networking", "Mathematics", "Software Development" };

        // Store books in a dictionary for efficient access and uniqueness by ISBN
        private Dictionary<string, Book> booksDictionary = new Dictionary<string, Book>();

        // Singleton pattern to ensure only one instance of ReadDataFile
        public static ReadDataFile GetInstance()
        {
            if (fileReader == null)
            {
                fileReader = new ReadDataFile();
            }
            return fileReader;
        }

        // Method to read books from the file and populate the booksDictionary
        public Dictionary<string, Book> ReadBooks(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Error: File does not exist.");
                    return null;
                }

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Remove leading and trailing spaces from the line
                        line = line.Trim();
                        string[] bookDetails = line.Split(',');

                        // Check if the line has all required fields
                        if (bookDetails.Length == 6)
                        {
                            string isbn = bookDetails[0];
                            string[] authors = bookDetails[1].Split(':');
                            string bookName = bookDetails[2];
                            string publisher = bookDetails[3];
                            int releasedYear = int.Parse(bookDetails[4]);
                            string category = bookDetails[5];

                            // Create a new Book object
                            Book book = new Book(isbn, authors.ToList(), bookName, publisher, releasedYear, category);

                            if (FilterBook(book))
                            {
                                // Add the book to the dictionary if it's not a duplicate ISBN
                                if (!booksDictionary.ContainsKey(isbn))
                                {
                                    booksDictionary.Add(isbn, book);
                                    //MessageBox.Show("Book " + book.ToString() + " Successfully added.");
                                }
                                else
                                {
                                    MessageBox.Show($"Duplicate ISBN found: {isbn}. Skipping the book.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid data format in line: " + line);
                        }
                    }
                }
                return booksDictionary;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading the file: " + ex.Message);
                return null;
            }
        }
     
        // Method to check if a book meets the filtering criteria
        /*public static bool FilterBook(Book book)
        {
            bool filterFlag = false;
            if (book.ReleasedYear == filterReleasedYear && allowedBookCategory.Contains(book.Category))
            {
                filterFlag = true;
                Console.WriteLine($"Book loaded: {book.BookName}");
            }
            else
            {
                Console.WriteLine($"Error: Either the Release Year is older than {filterReleasedYear} or Invalid Category!");
                filterFlag = false;
            }

            return filterFlag;
        }*/

        public bool FilterBook(Book book)
        {
            bool filterFlag = book.ReleasedYear >= filterReleasedYear && allowedBookCategory.Contains(book.Category);
            if (!filterFlag)
            {
                MessageBox.Show($"Book '{book.BookName}' does not meet the criteria.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return filterFlag;
        }
        
    }
}
