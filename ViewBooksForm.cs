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
    public partial class ViewBooksForm : Form
    {
        private readonly ProcessBooksData processBooksData;

        public ViewBooksForm(ProcessBooksData processBooksData)
        {
            InitializeComponent();
            this.processBooksData = processBooksData;
            processBooksData.DisplayAllCategories(dataGridViewBooks);
        }

        private void AllListButton_Click(object sender, EventArgs e)
        {
            processBooksData.DisplayAllCategories(dataGridViewBooks);
        }

        private void ComputerScienceButton_Click(object sender, EventArgs e)
        {
            processBooksData.DisplayBooksByCategory("Computer Science", dataGridViewBooks);
        }

        private void NetworkingButton_Click(object sender, EventArgs e)
        {
            processBooksData.DisplayBooksByCategory("Networking", dataGridViewBooks);
        }

        private void MathematicsButton_Click(object sender, EventArgs e)
        {
            processBooksData.DisplayBooksByCategory("Mathematics", dataGridViewBooks);
        }

        private void SoftwareDevelopmentButton_Click(object sender, EventArgs e)
        {
            processBooksData.DisplayBooksByCategory("Software Development", dataGridViewBooks);
        }

        private void BackButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
