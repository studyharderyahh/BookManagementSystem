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
    public partial class LoadBookFileForm : Form
    {
        // Field to store the file path
        private string filePath;
        // Field to store the ReadDataFile instance
        private ReadDataFile readDataFile;
        private readonly DataManager dataManager;

        public LoadBookFileForm(DataManager dataManager)
        {
            InitializeComponent();
            this.dataManager = dataManager;
        }


        private void BrosweFilePathButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.filePath = openFileDialog.FileName;
                    filePathTxt.Text = this.filePath;
                }
            }
        }

        private void UploadFileButton_Click(object sender, EventArgs e)
        {
            // Check if a file path is selected
            if (string.IsNullOrEmpty(this.filePath))
            {
                MessageBox.Show("Please select a file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var booksDictionary = dataManager.LoadBooksFromFile(filePath);
            // Count total books
            int totalBooks = booksDictionary.Count;

            if (booksDictionary != null && totalBooks > 0)
            {
                // Clear existing items and add new ones
                ListOfBookInfo.Items.Clear();
                foreach (var book in booksDictionary.Values)
                {
                    ListOfBookInfo.Items.Add(book.ToString());
                }

                dataManager.AddBooksFromLoadedFile(booksDictionary);
                MessageBox.Show($"{totalBooks} Books loaded and categorized successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to load books.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Trigger the Closed event and show the Dashboard
            this.Close(); 
        }

        private void ViewBooksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Use ShowDialog instead of Show, Becaue I feel like it's easier
            ViewBooksForm viewBooksForm = new ViewBooksForm(dataManager);
            viewBooksForm.Show();
        }
    }
}
