namespace Lab1
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
            this.refreshButton = new System.Windows.Forms.Button();
            this.bookInfoBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // booksListBox
            // 
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.ItemHeight = 20;
            this.booksListBox.Location = new System.Drawing.Point(174, 30);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(402, 144);
            this.booksListBox.TabIndex = 0;
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(174, 215);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(179, 42);
            this.showInfoButton.TabIndex = 1;
            this.showInfoButton.Text = "Show Info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(395, 215);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(181, 42);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh List";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // bookInfoBox
            // 
            this.bookInfoBox.Location = new System.Drawing.Point(174, 301);
            this.bookInfoBox.Multiline = true;
            this.bookInfoBox.Name = "bookInfoBox";
            this.bookInfoBox.Size = new System.Drawing.Size(402, 105);
            this.bookInfoBox.TabIndex = 3;
            // 
            // BookReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookInfoBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.booksListBox);
            this.Name = "BookReaderForm";
            this.Text = "Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox booksListBox;
        private Button showInfoButton;
        private Button refreshButton;
        private TextBox bookInfoBox;
    }
}