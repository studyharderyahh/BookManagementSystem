using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class AddBookForm : Form
    {
        private readonly ProcessBooksData processBooksData;
        private BookDataStructure bookDataStructure;

        public AddBookForm(ProcessBooksData processBooksData)
        {
            InitializeComponent();
            bookDataStructure = new BookDataStructure();
            this.processBooksData = processBooksData;
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn = ISBNTxt.Text;
                string authorsInput = AuthorsNameTxt.Text;
                string bookName = BookNameTxt.Text;
                string publisher = PublisherTxt.Text;
                string releasedYearInput = ReleasedYearTxt.Text;
                string category = CategoryTxt.Text;

                // Validate input
                if (string.IsNullOrWhiteSpace(isbn) || string.IsNullOrWhiteSpace(authorsInput) || string.IsNullOrWhiteSpace(bookName) || string.IsNullOrWhiteSpace(publisher) || string.IsNullOrWhiteSpace(releasedYearInput) || string.IsNullOrWhiteSpace(category))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validation for authors and released year
                List<string> authorsName = GetAuthorsNames(authorsInput);
                int releasedYear = GetReleasedYear(releasedYearInput);

                // Create new Book object
                Book newBook = new Book(isbn, authorsName, bookName, publisher, releasedYear, category);
                bookDataStructure.Enqueue(newBook);
                MessageBox.Show("Book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFields();
            }
        }

        private List<string> GetAuthorsNames(string authors)
        {
            List<string> authorsName = new List<string>(authors.Split(':'));
            if (authorsName.Any(string.IsNullOrWhiteSpace))
            {
                throw new InvalidOperationException("Author names cannot be empty.");
            }
            return authorsName;
        }
        private int GetReleasedYear(string year)
        {
            if (!int.TryParse(year, out int releasedYear))
            {
                throw new FormatException("Invalid released year format.");
            }
            return releasedYear;
        }
        private void ClearFields()
        {
            ISBNTxt.Clear();
            AuthorsNameTxt.Clear();
            BookNameTxt.Clear();
            PublisherTxt.Clear();
            ReleasedYearTxt.Clear();
            CategoryTxt.Clear();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            // Trigger the Closed event and show the Dashboard
            this.Close(); 
        }

    }
}
