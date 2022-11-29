namespace Lab12
{
    partial class BookReaderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.bookInfoBox = new System.Windows.Forms.TextBox();
            this.bookTextBox = new System.Windows.Forms.TextBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxPages = new System.Windows.Forms.Label();
            this.UpdateBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // booksListBox
            // 
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.ItemHeight = 20;
            this.booksListBox.Location = new System.Drawing.Point(174, 12);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(402, 144);
            this.booksListBox.TabIndex = 0;
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(174, 176);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(179, 42);
            this.showInfoButton.TabIndex = 1;
            this.showInfoButton.Text = "Show Info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // bookInfoBox
            // 
            this.bookInfoBox.Location = new System.Drawing.Point(12, 280);
            this.bookInfoBox.Multiline = true;
            this.bookInfoBox.Name = "bookInfoBox";
            this.bookInfoBox.ReadOnly = true;
            this.bookInfoBox.Size = new System.Drawing.Size(197, 105);
            this.bookInfoBox.TabIndex = 3;
            // 
            // bookTextBox
            // 
            this.bookTextBox.Location = new System.Drawing.Point(322, 246);
            this.bookTextBox.Multiline = true;
            this.bookTextBox.Name = "bookTextBox";
            this.bookTextBox.ReadOnly = true;
            this.bookTextBox.Size = new System.Drawing.Size(466, 105);
            this.bookTextBox.TabIndex = 4;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(322, 391);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(94, 29);
            this.buttonPrev.TabIndex = 5;
            this.buttonPrev.Text = "Previous";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(694, 391);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(94, 29);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Book Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Book Text";
            // 
            // maxPages
            // 
            this.maxPages.AutoSize = true;
            this.maxPages.Location = new System.Drawing.Point(593, 396);
            this.maxPages.Name = "maxPages";
            this.maxPages.Size = new System.Drawing.Size(0, 20);
            this.maxPages.TabIndex = 10;
            // 
            // UpdateBook
            // 
            this.UpdateBook.Location = new System.Drawing.Point(391, 176);
            this.UpdateBook.Name = "UpdateBook";
            this.UpdateBook.Size = new System.Drawing.Size(185, 44);
            this.UpdateBook.TabIndex = 11;
            this.UpdateBook.Text = "Update";
            this.UpdateBook.UseVisualStyleBackColor = true;
            // 
            // BookReaderForm
            // 
            this.ClientSize = new System.Drawing.Size(881, 535);
            this.Controls.Add(this.booksListBox);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.bookInfoBox);
            this.Controls.Add(this.bookTextBox);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxPages);
            this.Controls.Add(this.UpdateBook);
            this.Name = "BookReaderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox booksListBox;
        private Button showInfoButton;
        private TextBox bookInfoBox;
        private TextBox bookTextBox;
        private Button buttonPrev;
        private Button buttonNext;
        private Label label1;
        private Label label2;
        private Label maxPages;
        private Button UpdateBook;
    }
}