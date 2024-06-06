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
        // Static field to hold the single instance of Dashboard
        private static Dashboard instance;
        private readonly DataManager dataManager;

        public Dashboard()
        {
            InitializeComponent();
            dataManager = new DataManager();
        }

        // Public property to access the single instance of Dashboard
        public static Dashboard Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Dashboard();
                }
                return instance;
            }
        }

        private void LoadBookFileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoadBookFileForm loadBookFile = new LoadBookFileForm(dataManager);
            // Show Dashboard again when LoadBookFile is closed
            loadBookFile.Closed += (s, args) => this.Show();
            loadBookFile.Show();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBookForm addBookForm = new AddBookForm(dataManager);
            // Show Dashboard again when AddBookForm is closed
            addBookForm.Closed += (s, args) => this.Show();
            addBookForm.Show();
        }

        private void ViewBooksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewBooksForm viewBooksForm = new ViewBooksForm(dataManager);
            // Show Dashboard again when ViewBooksForm is closed
            viewBooksForm.Closed += (s, args) => this.Show();
            viewBooksForm.Show();
        }
    }
}
