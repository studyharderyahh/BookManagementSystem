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
        private readonly DataManager dataManager;
        // Field to keep track of the selected category
        private string selectedCategory = "All";

        public ViewBooksForm(DataManager dataManager)
        {
            InitializeComponent();
            this.dataManager = dataManager;
            // Always refresh the display when the form is opened
            dataManager.DisplayAllCategories(dataGridViewBooks);
        }

        private void AllListButton_Click(object sender, EventArgs e)
        {
            selectedCategory = "All";
            dataManager.DisplayAllCategories(dataGridViewBooks);
        }

        private void ComputerScienceButton_Click(object sender, EventArgs e)
        {
            selectedCategory = "Computer Science";
            dataManager.DisplayBooksByCategory("Computer Science", dataGridViewBooks);
        }

        private void NetworkingButton_Click(object sender, EventArgs e)
        {
            selectedCategory = "Networking";
            dataManager.DisplayBooksByCategory("Networking", dataGridViewBooks);
        }

        private void MathematicsButton_Click(object sender, EventArgs e)
        {
            selectedCategory = "Mathematics";
            dataManager.DisplayBooksByCategory("Mathematics", dataGridViewBooks);
        }

        private void SoftwareDevelopmentButton_Click(object sender, EventArgs e)
        {
            selectedCategory = "Software Development";
            dataManager.DisplayBooksByCategory("Software Development", dataGridViewBooks);
        }

        private void BackButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteTopValueButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCategory == "All")
                {
                    MessageBox.Show("Please select a specific category to delete from.");
                    return;
                }

                dataManager.DeleteTopBook(selectedCategory);
                // Refresh the DataGridView to reflect the changes
                dataManager.DisplayBooksByCategory(selectedCategory, dataGridViewBooks);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
