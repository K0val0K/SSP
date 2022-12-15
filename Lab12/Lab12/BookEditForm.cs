using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public partial class BookEditForm : Form
    {
        private string connectionString;
        private BookSet bookSet;
        private Book book;
        private List<Author> authors = new();
        public BookEditForm(BookReaderForm bookReaderForm, Book book)
        {
            InitializeComponent();
            connectionString = bookReaderForm.connectionString;
            bookSet = bookReaderForm.bookSet;
            this.book = book;
            this.BookName.Text = book.Title;
            this.BookIssueYear.Text = book.Year.ToString();
            this.BookTextFilename.Text = book.TextLink;

            LoadAuthorsToComboBox();
        }

        private void LoadAuthorsToComboBox()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string sql = "SELECT * FROM Authors";
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                var dt = ds.Tables[0];

                foreach(DataRow row in dt.Rows)
                {
                    var cells = row.ItemArray;
                    authors.Add(new Author() { Id = int.Parse(cells[0].ToString()), Name = cells[1].ToString() });                  
                }

                authorsComboBox.DataSource = authors;
                authorsComboBox.ValueMember = "Id";
                authorsComboBox.DisplayMember = "Name";
                var selectedAuthor = authors.FirstOrDefault(x => x.Id == book.AuthorId);
                authorsComboBox.SelectedIndex = authors.IndexOf(selectedAuthor);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string sql = "SELECT * FROM Books";
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connection);

                var selectedBook = bookSet.Books.FirstOrDefault(x => x.Id == book.Id);

                selectedBook.Name = this.BookName.Text;

                selectedBook.Author = int.Parse(authorsComboBox.SelectedValue.ToString());


                selectedBook.IssueDateYear = int.Parse(this.BookIssueYear.Text);
                selectedBook.BookFileName = this.BookTextFilename.Text;

                OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(adapter);
                adapter.Update(bookSet.Books);
            }
        }
    }
}
