namespace BookManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoadBookFileButton = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.ViewBooksButton = new System.Windows.Forms.Button();
            this.TitleBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.TitleBar.Controls.Add(this.label1);
            this.TitleBar.Controls.Add(this.label2);
            this.TitleBar.Location = new System.Drawing.Point(-8, 12);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(910, 73);
            this.TitleBar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Book Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(817, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Version 1.0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.LoadBookFileButton);
            this.groupBox1.Controls.Add(this.AddBookButton);
            this.groupBox1.Controls.Add(this.ViewBooksButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(1, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 307);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dashboard";
            // 
            // LoadBookFileButton
            // 
            this.LoadBookFileButton.BackColor = System.Drawing.Color.Teal;
            this.LoadBookFileButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold);
            this.LoadBookFileButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadBookFileButton.Image")));
            this.LoadBookFileButton.Location = new System.Drawing.Point(65, 69);
            this.LoadBookFileButton.Name = "LoadBookFileButton";
            this.LoadBookFileButton.Size = new System.Drawing.Size(221, 211);
            this.LoadBookFileButton.TabIndex = 3;
            this.LoadBookFileButton.Text = "Load Book File";
            this.LoadBookFileButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadBookFileButton.UseVisualStyleBackColor = false;
            this.LoadBookFileButton.Click += new System.EventHandler(this.LoadBookFileButton_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.BackColor = System.Drawing.Color.Teal;
            this.AddBookButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold);
            this.AddBookButton.Image = ((System.Drawing.Image)(resources.GetObject("AddBookButton.Image")));
            this.AddBookButton.Location = new System.Drawing.Point(344, 69);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(232, 211);
            this.AddBookButton.TabIndex = 1;
            this.AddBookButton.Text = "Add New Book";
            this.AddBookButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddBookButton.UseVisualStyleBackColor = false;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // ViewBooksButton
            // 
            this.ViewBooksButton.BackColor = System.Drawing.Color.Teal;
            this.ViewBooksButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold);
            this.ViewBooksButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewBooksButton.Image")));
            this.ViewBooksButton.Location = new System.Drawing.Point(638, 69);
            this.ViewBooksButton.Name = "ViewBooksButton";
            this.ViewBooksButton.Size = new System.Drawing.Size(219, 211);
            this.ViewBooksButton.TabIndex = 2;
            this.ViewBooksButton.Text = "View Book";
            this.ViewBooksButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ViewBooksButton.UseVisualStyleBackColor = false;
            this.ViewBooksButton.Click += new System.EventHandler(this.ViewBooksButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(896, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TitleBar);
            this.Name = "Dashboard";
            this.Text = "Book Management System";
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoadBookFileButton;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button ViewBooksButton;
    }
}

