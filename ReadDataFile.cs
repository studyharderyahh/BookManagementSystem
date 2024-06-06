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
        private static ReadDataFile fileReaderInstance;
        private string filePath = "SampleBooks.txt";

        // Store books in a dictionary for efficient access and uniqueness by ISBN
        // private Dictionary<string, Book> booksDictionary = new Dictionary<string, Book>();

        // Singleton pattern to ensure only one instance of ReadDataFile
        public static ReadDataFile GetInstance()
        {
            if (fileReaderInstance == null)
            {
                fileReaderInstance = new ReadDataFile();
            }
            return fileReaderInstance;
        }


        public static BookDataStructure LoadBooksFromFile(string filePath)
        {
            BookDataStructure bookDataStructure = new BookDataStructure();
            ReadDataFile readDataFile = ReadDataFile.GetInstance();
            readDataFile.filePath = filePath;

            readDataFile.ReadFile(bookDataStructure);

            return bookDataStructure;

        }

        // Method to read books from the file and populate the booksDictionary
        public void ReadFile(BookDataStructure bookDataStructure)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Error: File does not exist.");
                }

                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
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
                            bookDataStructure.AddBook(new Book(isbn, authors.ToList(), bookName, publisher, releasedYear, category));

                            /* // Add the book to the dictionary if it's not a duplicate ISBN
                            if (!booksDictionary.ContainsKey(isbn))
                            {
                                booksDictionary.Add(isbn, book);
                                //MessageBox.Show("Book " + book.ToString() + " Successfully added.");
                            }
                            else
                            {
                                MessageBox.Show($"Duplicate ISBN found: {isbn}. Skipping the book.");
                            } */
                        }
                        else
                        {
                            MessageBox.Show("Invalid data format in line: " + line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading the file: " + ex.Message);
            }
        }

    }
}
