namespace BookManagementSystem
{
    partial class ViewBooksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.ComputerScienceButton = new System.Windows.Forms.Button();
            this.BackButtom = new System.Windows.Forms.Button();
            this.NetworkingButton = new System.Windows.Forms.Button();
            this.MathematicsButton = new System.Windows.Forms.Button();
            this.SoftwareDevelopmentButton = new System.Windows.Forms.Button();
            this.AllListButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToOrderColumns = true;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(45, 174);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(872, 343);
            this.dataGridViewBooks.TabIndex = 1;
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ISBNLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.ISBNLabel.Location = new System.Drawing.Point(202, 23);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(580, 35);
            this.ISBNLabel.TabIndex = 19;
            this.ISBNLabel.Text = "Select a Category to View the List of Book(s)";
            // 
            // ComputerScienceButton
            // 
            this.ComputerScienceButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ComputerScienceButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerScienceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ComputerScienceButton.Location = new System.Drawing.Point(108, 107);
            this.ComputerScienceButton.Name = "ComputerScienceButton";
            this.ComputerScienceButton.Size = new System.Drawing.Size(202, 48);
            this.ComputerScienceButton.TabIndex = 20;
            this.ComputerScienceButton.Text = "Computer Science";
            this.ComputerScienceButton.UseVisualStyleBackColor = false;
            this.ComputerScienceButton.Click += new System.EventHandler(this.ComputerScienceButton_Click);
            // 
            // BackButtom
            // 
            this.BackButtom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackButtom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButtom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButtom.Location = new System.Drawing.Point(389, 546);
            this.BackButtom.Name = "BackButtom";
            this.BackButtom.Size = new System.Drawing.Size(146, 46);
            this.BackButtom.TabIndex = 21;
            this.BackButtom.Text = "Back";
            this.BackButtom.UseVisualStyleBackColor = false;
            this.BackButtom.Click += new System.EventHandler(this.BackButtom_Click);
            // 
            // NetworkingButton
            // 
            this.NetworkingButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NetworkingButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkingButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NetworkingButton.Location = new System.Drawing.Point(337, 107);
            this.NetworkingButton.Name = "NetworkingButton";
            this.NetworkingButton.Size = new System.Drawing.Size(163, 48);
            this.NetworkingButton.TabIndex = 22;
            this.NetworkingButton.Text = "Networking";
            this.NetworkingButton.UseVisualStyleBackColor = false;
            this.NetworkingButton.Click += new System.EventHandler(this.NetworkingButton_Click);
            // 
            // MathematicsButton
            // 
            this.MathematicsButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MathematicsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathematicsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MathematicsButton.Location = new System.Drawing.Point(531, 107);
            this.MathematicsButton.Name = "MathematicsButton";
            this.MathematicsButton.Size = new System.Drawing.Size(169, 48);
            this.MathematicsButton.TabIndex = 23;
            this.MathematicsButton.Text = "Mathematics";
            this.MathematicsButton.UseVisualStyleBackColor = false;
            this.MathematicsButton.Click += new System.EventHandler(this.MathematicsButton_Click);
            // 
            // SoftwareDevelopmentButton
            // 
            this.SoftwareDevelopmentButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SoftwareDevelopmentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareDevelopmentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SoftwareDevelopmentButton.Location = new System.Drawing.Point(721, 107);
            this.SoftwareDevelopmentButton.Name = "SoftwareDevelopmentButton";
            this.SoftwareDevelopmentButton.Size = new System.Drawing.Size(246, 48);
            this.SoftwareDevelopmentButton.TabIndex = 24;
            this.SoftwareDevelopmentButton.Text = "Software Development";
            this.SoftwareDevelopmentButton.UseVisualStyleBackColor = false;
            this.SoftwareDevelopmentButton.Click += new System.EventHandler(this.SoftwareDevelopmentButton_Click);
            // 
            // AllListButton
            // 
            this.AllListButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AllListButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllListButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllListButton.Location = new System.Drawing.Point(12, 107);
            this.AllListButton.Name = "AllListButton";
            this.AllListButton.Size = new System.Drawing.Size(76, 48);
            this.AllListButton.TabIndex = 25;
            this.AllListButton.Text = "All";
            this.AllListButton.UseVisualStyleBackColor = false;
            this.AllListButton.Click += new System.EventHandler(this.AllListButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.ISBNLabel);
            this.panel1.Location = new System.Drawing.Point(-5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 82);
            this.panel1.TabIndex = 26;
            // 
            // ViewBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(972, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AllListButton);
            this.Controls.Add(this.SoftwareDevelopmentButton);
            this.Controls.Add(this.MathematicsButton);
            this.Controls.Add(this.NetworkingButton);
            this.Controls.Add(this.BackButtom);
            this.Controls.Add(this.ComputerScienceButton);
            this.Controls.Add(this.dataGridViewBooks);
            this.Name = "ViewBooksForm";
            this.Text = "View Books Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.Button ComputerScienceButton;
        private System.Windows.Forms.Button BackButtom;
        private System.Windows.Forms.Button NetworkingButton;
        private System.Windows.Forms.Button MathematicsButton;
        private System.Windows.Forms.Button SoftwareDevelopmentButton;
        private System.Windows.Forms.Button AllListButton;
        private System.Windows.Forms.Panel panel1;
    }
}