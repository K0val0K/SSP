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
            var book = GetSelectedBook(booksListBox.SelectedIndex);
            bookInfoBox.Text = $"Title: {book.Title}, Author: {book.Author}, Creation year: {book.Year}";
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            booksListBox.Items.Clear();
            LoadBookList();
            bookInfoBox.Text = String.Empty;
        }

        private void LoadBookList()
        {
            var s = GetBookList();
            booksListBox.Items.AddRange(GetBookList());
        }

        private string[] GetBookList()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "books.txt");

            return File.ReadLines(path)
                .Select(book => book.Substring(0, book.IndexOf(':'))).ToArray();
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