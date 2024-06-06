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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButton.Location = new System.Drawing.Point(270, 386);
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
            this.UploadFileButton.Location = new System.Drawing.Point(220, 217);
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
            this.groupBox1.Controls.Add(this.BrosweFilePathButton);
            this.groupBox1.Controls.Add(this.filePathTxt);
            this.groupBox1.Controls.Add(this.ISBNLabel);
            this.groupBox1.Controls.Add(this.UploadFileButton);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(50, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 303);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Browser Your File Below";
            // 
            // BrosweFilePathButton
            // 
            this.BrosweFilePathButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BrosweFilePathButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrosweFilePathButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BrosweFilePathButton.Location = new System.Drawing.Point(502, 119);
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
            this.filePathTxt.Location = new System.Drawing.Point(19, 119);
            this.filePathTxt.Multiline = true;
            this.filePathTxt.Name = "filePathTxt";
            this.filePathTxt.Size = new System.Drawing.Size(459, 42);
            this.filePathTxt.TabIndex = 19;
            // 
            // LoadBookFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(726, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BackButton);
            this.Name = "LoadBookFileForm";
            this.Text = "Load Book File Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button UploadFileButton;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox filePathTxt;
        private System.Windows.Forms.Button BrosweFilePathButton;
    }
}