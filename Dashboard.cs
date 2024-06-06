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
            var loadBookFileForm = new LoadBookFileForm(dataManager);
            loadBookFileForm.Show();
            //RefreshView();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addBookForm = new AddBookForm(dataManager);
            addBookForm.Show();
            //RefreshView();
        }

        private void ViewBooksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var viewBooksForm = new ViewBooksForm(dataManager);
            viewBooksForm.Show();
        }
    }
}
