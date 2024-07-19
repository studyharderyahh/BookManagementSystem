namespace BookManagementSystem
{
    partial class AddBookForm
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
            this.BookInformationForm = new System.Windows.Forms.GroupBox();
            this.CategoryTxt = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.ReleasedYearTxt = new System.Windows.Forms.TextBox();
            this.ReleasedLabel = new System.Windows.Forms.Label();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.PublisherTxt = new System.Windows.Forms.TextBox();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.BookNameTxt = new System.Windows.Forms.TextBox();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.AuthorsNameTxt = new System.Windows.Forms.TextBox();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.ISBNTxt = new System.Windows.Forms.TextBox();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.BookInformationForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookInformationForm
            // 
            this.BookInformationForm.Controls.Add(this.CategoryTxt);
            this.BookInformationForm.Controls.Add(this.categoryLabel);
            this.BookInformationForm.Controls.Add(this.GoBackButton);
            this.BookInformationForm.Controls.Add(this.ReleasedYearTxt);
            this.BookInformationForm.Controls.Add(this.ReleasedLabel);
            this.BookInformationForm.Controls.Add(this.AddBookButton);
            this.BookInformationForm.Controls.Add(this.PublisherTxt);
            this.BookInformationForm.Controls.Add(this.PublisherLabel);
            this.BookInformationForm.Controls.Add(this.AgeLabel);
            this.BookInformationForm.Controls.Add(this.BookNameTxt);
            this.BookInformationForm.Controls.Add(this.BookNameLabel);
            this.BookInformationForm.Controls.Add(this.AuthorsNameTxt);
            this.BookInformationForm.Controls.Add(this.FNameLabel);
            this.BookInformationForm.Controls.Add(this.ISBNTxt);
            this.BookInformationForm.Controls.Add(this.ISBNLabel);
            this.BookInformationForm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookInformationForm.Location = new System.Drawing.Point(79, 12);
            this.BookInformationForm.Name = "BookInformationForm";
            this.BookInformationForm.Size = new System.Drawing.Size(515, 559);
            this.BookInformationForm.TabIndex = 2;
            this.BookInformationForm.TabStop = false;
            this.BookInformationForm.Text = "Book Information Form";
            // 
            // CategoryTxt
            // 
            this.CategoryTxt.Location = new System.Drawing.Point(200, 348);
            this.CategoryTxt.Name = "CategoryTxt";
            this.CategoryTxt.Size = new System.Drawing.Size(257, 30);
            this.CategoryTxt.TabIndex = 17;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(34, 338);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(89, 23);
            this.categoryLabel.TabIndex = 16;
            this.categoryLabel.Text = "Category";
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GoBackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GoBackButton.Location = new System.Drawing.Point(174, 495);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(146, 42);
            this.GoBackButton.TabIndex = 15;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // ReleasedYearTxt
            // 
            this.ReleasedYearTxt.Location = new System.Drawing.Point(200, 281);
            this.ReleasedYearTxt.Name = "ReleasedYearTxt";
            this.ReleasedYearTxt.Size = new System.Drawing.Size(257, 30);
            this.ReleasedYearTxt.TabIndex = 12;
            // 
            // ReleasedLabel
            // 
            this.ReleasedLabel.AutoSize = true;
            this.ReleasedLabel.Location = new System.Drawing.Point(34, 281);
            this.ReleasedLabel.Name = "ReleasedLabel";
            this.ReleasedLabel.Size = new System.Drawing.Size(130, 23);
            this.ReleasedLabel.TabIndex = 11;
            this.ReleasedLabel.Text = "Released Year";
            // 
            // AddBookButton
            // 
            this.AddBookButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddBookButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBookButton.Location = new System.Drawing.Point(174, 423);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(146, 49);
            this.AddBookButton.TabIndex = 10;
            this.AddBookButton.Text = "Add Book";
            this.AddBookButton.UseVisualStyleBackColor = false;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // PublisherTxt
            // 
            this.PublisherTxt.Location = new System.Drawing.Point(200, 227);
            this.PublisherTxt.Name = "PublisherTxt";
            this.PublisherTxt.Size = new System.Drawing.Size(257, 30);
            this.PublisherTxt.TabIndex = 9;
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.AutoSize = true;
            this.PublisherLabel.Location = new System.Drawing.Point(34, 230);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(88, 23);
            this.PublisherLabel.TabIndex = 8;
            this.PublisherLabel.Text = "Publisher";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(39, 230);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(0, 23);
            this.AgeLabel.TabIndex = 6;
            // 
            // BookNameTxt
            // 
            this.BookNameTxt.Location = new System.Drawing.Point(200, 165);
            this.BookNameTxt.Name = "BookNameTxt";
            this.BookNameTxt.Size = new System.Drawing.Size(257, 30);
            this.BookNameTxt.TabIndex = 5;
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(34, 172);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(108, 23);
            this.BookNameLabel.TabIndex = 4;
            this.BookNameLabel.Text = "Book Name";
            // 
            // AuthorsNameTxt
            // 
            this.AuthorsNameTxt.Location = new System.Drawing.Point(200, 107);
            this.AuthorsNameTxt.Name = "AuthorsNameTxt";
            this.AuthorsNameTxt.Size = new System.Drawing.Size(257, 30);
            this.AuthorsNameTxt.TabIndex = 3;
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Location = new System.Drawing.Point(34, 114);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(145, 23);
            this.FNameLabel.TabIndex = 2;
            this.FNameLabel.Text = "Author(s) Name";
            // 
            // ISBNTxt
            // 
            this.ISBNTxt.Location = new System.Drawing.Point(200, 50);
            this.ISBNTxt.Name = "ISBNTxt";
            this.ISBNTxt.Size = new System.Drawing.Size(257, 30);
            this.ISBNTxt.TabIndex = 1;
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Location = new System.Drawing.Point(34, 57);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(55, 23);
            this.ISBNLabel.TabIndex = 0;
            this.ISBNLabel.Text = "ISBN";
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(672, 621);
            this.Controls.Add(this.BookInformationForm);
            this.Name = "AddBookForm";
            this.Text = "Add Book Form";
            this.BookInformationForm.ResumeLayout(false);
            this.BookInformationForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BookInformationForm;
        private System.Windows.Forms.TextBox CategoryTxt;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.TextBox ReleasedYearTxt;
        private System.Windows.Forms.Label ReleasedLabel;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.TextBox PublisherTxt;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox BookNameTxt;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.TextBox AuthorsNameTxt;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.TextBox ISBNTxt;
        private System.Windows.Forms.Label ISBNLabel;
    }
}