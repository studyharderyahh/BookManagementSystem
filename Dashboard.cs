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
    public partial class Dashboard : Form
    {
        private readonly ProcessBooksData processBooksData;

        public Dashboard()
        {
            InitializeComponent();
            processBooksData = new ProcessBooksData();
        }

        private void LoadBookFileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoadBookFileForm loadBookFile = new LoadBookFileForm(processBooksData);
            // Show Dashboard again when LoadBookFile is closed
            loadBookFile.Closed += (s, args) => this.Show(); 
            loadBookFile.Show();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBookForm addBookForm = new AddBookForm(processBooksData);
            // Show Dashboard again when AddBookForm is closed
            addBookForm.Closed += (s, args) => this.Show(); 
            addBookForm.Show();
        }

        private void ViewBooksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewBooksForm viewBooksForm = new ViewBooksForm(processBooksData);
            // Show Dashboard again when ViewBooksForm is closed
            viewBooksForm.Closed += (s, args) => this.Show(); 
            viewBooksForm.Show();
        }
    }
}
