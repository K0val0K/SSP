using System.ComponentModel;

namespace Lab1
{
    public partial class BookReaderForm : Form
    {
        public BookReaderForm()
        {
            InitializeComponent();
            booksListBox.SelectionMode = SelectionMode.One;
            LoadBookList();
        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {
            var book = GetSelectedBook((int)booksListBox.SelectedValue);
            bookInfoBox.Text = $"Title: {book.Title}, Author: {book.Author}, Creation year: {book.Year}";
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            booksListBox.DataSource = null;
            booksListBox.Items.Clear();
            LoadBookList();
            bookInfoBox.Text = String.Empty;
        }

        private void LoadBookList()
        {
            booksListBox.DataSource = GetBookList();
            booksListBox.DisplayMember = "Title";
            booksListBox.ValueMember = "Id";
        }

        private List<object> GetBookList()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "books.txt");

            return File.ReadLines(path)
                .Select
                ((book, counter) => new
                {
                    Id = counter,
                    Title = book.Substring(0, book.IndexOf(':'))
                })
                .ToList<object>();
        }

        private Book GetSelectedBook(int id)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "books.txt");

            var line = File.ReadLines(path).ElementAtOrDefault(id).Split(':');

            return new Book()
            {
                Title = line[0],
                Author = line[1],
                Year = int.Parse(line[2])
            };
        }
    }
}