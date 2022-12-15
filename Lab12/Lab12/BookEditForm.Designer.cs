namespace Lab12
{
    partial class BookEditForm
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
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BookAuthorLabel = new System.Windows.Forms.Label();
            this.BookIssueYearLabel = new System.Windows.Forms.Label();
            this.BookTextFileLabel = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.TextBox();
            this.BookIssueYear = new System.Windows.Forms.TextBox();
            this.BookTextFilename = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.authorsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(349, 56);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(49, 20);
            this.BookNameLabel.TabIndex = 0;
            this.BookNameLabel.Text = "Name";
            // 
            // BookAuthorLabel
            // 
            this.BookAuthorLabel.AutoSize = true;
            this.BookAuthorLabel.Location = new System.Drawing.Point(344, 134);
            this.BookAuthorLabel.Name = "BookAuthorLabel";
            this.BookAuthorLabel.Size = new System.Drawing.Size(54, 20);
            this.BookAuthorLabel.TabIndex = 1;
            this.BookAuthorLabel.Text = "Author";
            // 
            // BookIssueYearLabel
            // 
            this.BookIssueYearLabel.AutoSize = true;
            this.BookIssueYearLabel.Location = new System.Drawing.Point(344, 208);
            this.BookIssueYearLabel.Name = "BookIssueYearLabel";
            this.BookIssueYearLabel.Size = new System.Drawing.Size(73, 20);
            this.BookIssueYearLabel.TabIndex = 2;
            this.BookIssueYearLabel.Text = "Issue Year";
            // 
            // BookTextFileLabel
            // 
            this.BookTextFileLabel.AutoSize = true;
            this.BookTextFileLabel.Location = new System.Drawing.Point(344, 291);
            this.BookTextFileLabel.Name = "BookTextFileLabel";
            this.BookTextFileLabel.Size = new System.Drawing.Size(63, 20);
            this.BookTextFileLabel.TabIndex = 3;
            this.BookTextFileLabel.Text = "Text File";
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(264, 92);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(230, 27);
            this.BookName.TabIndex = 4;
            // 
            // BookIssueYear
            // 
            this.BookIssueYear.Location = new System.Drawing.Point(264, 253);
            this.BookIssueYear.Name = "BookIssueYear";
            this.BookIssueYear.Size = new System.Drawing.Size(230, 27);
            this.BookIssueYear.TabIndex = 6;
            // 
            // BookTextFilename
            // 
            this.BookTextFilename.Location = new System.Drawing.Point(264, 332);
            this.BookTextFilename.Name = "BookTextFilename";
            this.BookTextFilename.Size = new System.Drawing.Size(230, 27);
            this.BookTextFilename.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // authorsComboBox
            // 
            this.authorsComboBox.FormattingEnabled = true;
            this.authorsComboBox.Location = new System.Drawing.Point(264, 167);
            this.authorsComboBox.Name = "authorsComboBox";
            this.authorsComboBox.Size = new System.Drawing.Size(230, 28);
            this.authorsComboBox.TabIndex = 9;
            // 
            // BookEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.authorsComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BookTextFilename);
            this.Controls.Add(this.BookIssueYear);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.BookTextFileLabel);
            this.Controls.Add(this.BookIssueYearLabel);
            this.Controls.Add(this.BookAuthorLabel);
            this.Controls.Add(this.BookNameLabel);
            this.Name = "BookEditForm";
            this.Text = "BookEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label BookNameLabel;
        private Label BookAuthorLabel;
        private Label BookIssueYearLabel;
        private Label BookTextFileLabel;
        private TextBox BookName;
        private TextBox BookIssueYear;
        private TextBox BookTextFilename;
        private Button button1;
        private ComboBox authorsComboBox;
    }
}