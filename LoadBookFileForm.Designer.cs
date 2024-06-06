namespace BookManagementSystem
{
    partial class LoadBookFileForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.UploadFileButton = new System.Windows.Forms.Button();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BrosweFilePathButton = new System.Windows.Forms.Button();
            this.filePathTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewBooksButton = new System.Windows.Forms.Button();
            this.ListOfBookInfo = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButton.Location = new System.Drawing.Point(299, 532);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(146, 42);
            this.BackButton.TabIndex = 16;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UploadFileButton
            // 
            this.UploadFileButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UploadFileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadFileButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UploadFileButton.Location = new System.Drawing.Point(228, 166);
            this.UploadFileButton.Name = "UploadFileButton";
            this.UploadFileButton.Size = new System.Drawing.Size(138, 49);
            this.UploadFileButton.TabIndex = 17;
            this.UploadFileButton.Text = "Upload File";
            this.UploadFileButton.UseVisualStyleBackColor = false;
            this.UploadFileButton.Click += new System.EventHandler(this.UploadFileButton_Click);
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.ISBNLabel.Location = new System.Drawing.Point(25, 65);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(251, 26);
            this.ISBNLabel.TabIndex = 18;
            this.ISBNLabel.Text = "Select a File to Upload:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListOfBookInfo);
            this.groupBox1.Controls.Add(this.BrosweFilePathButton);
            this.groupBox1.Controls.Add(this.filePathTxt);
            this.groupBox1.Controls.Add(this.ISBNLabel);
            this.groupBox1.Controls.Add(this.UploadFileButton);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(52, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 487);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Browser Your File Below";
            // 
            // BrosweFilePathButton
            // 
            this.BrosweFilePathButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BrosweFilePathButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrosweFilePathButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BrosweFilePathButton.Location = new System.Drawing.Point(502, 107);
            this.BrosweFilePathButton.Name = "BrosweFilePathButton";
            this.BrosweFilePathButton.Size = new System.Drawing.Size(108, 42);
            this.BrosweFilePathButton.TabIndex = 20;
            this.BrosweFilePathButton.Text = "Broswe";
            this.BrosweFilePathButton.UseVisualStyleBackColor = false;
            this.BrosweFilePathButton.Click += new System.EventHandler(this.BrosweFilePathButton_Click);
            // 
            // filePathTxt
            // 
            this.filePathTxt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathTxt.Location = new System.Drawing.Point(21, 107);
            this.filePathTxt.Multiline = true;
            this.filePathTxt.Name = "filePathTxt";
            this.filePathTxt.Size = new System.Drawing.Size(459, 42);
            this.filePathTxt.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Or";
            // 
            // ViewBooksButton
            // 
            this.ViewBooksButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ViewBooksButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBooksButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBooksButton.Location = new System.Drawing.Point(299, 599);
            this.ViewBooksButton.Name = "ViewBooksButton";
            this.ViewBooksButton.Size = new System.Drawing.Size(146, 42);
            this.ViewBooksButton.TabIndex = 21;
            this.ViewBooksButton.Text = "View Books";
            this.ViewBooksButton.UseVisualStyleBackColor = false;
            this.ViewBooksButton.Click += new System.EventHandler(this.ViewBooksButton_Click);
            // 
            // ListOfBookInfo
            // 
            this.ListOfBookInfo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfBookInfo.FormattingEnabled = true;
            this.ListOfBookInfo.ItemHeight = 20;
            this.ListOfBookInfo.Location = new System.Drawing.Point(6, 252);
            this.ListOfBookInfo.Name = "ListOfBookInfo";
            this.ListOfBookInfo.Size = new System.Drawing.Size(604, 204);
            this.ListOfBookInfo.TabIndex = 22;
            // 
            // LoadBookFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(729, 672);
            this.Controls.Add(this.ViewBooksButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BackButton);
            this.Name = "LoadBookFileForm";
            this.Text = "Load Book File Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button UploadFileButton;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox filePathTxt;
        private System.Windows.Forms.Button BrosweFilePathButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewBooksButton;
        private System.Windows.Forms.ListBox ListOfBookInfo;
    }
}