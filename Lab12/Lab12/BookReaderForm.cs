using System.Data.OleDb;

namespace Lab12
{
    public partial class BookReaderForm : Form
    {
        public string connectionString = "Provider=SQLNCLIRDA11;Data Source=(local);Integrated Security=SSPI;Initial Catalog=Library";
        public BookSet bookSet;

        private Book selectedBook;
        private int currentPage = 0;

        int pageSize = 256;
        public BookReaderForm()
        {
            InitializeComponent();
            booksListBox.SelectionMode = SelectionMode.One;
            bookSet = new BookSet();

            LoadBookList();
        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {
            if (booksListBox.SelectedIndex < 0) return;

            this.selectedBook = new Book();
            bool isSucceded = true;
            try
            {  
                this.selectedBook = GetSelectedBookInfo(int.Parse(booksListBox.SelectedValue.ToString()));
            } catch(Exception)
            {
                isSucceded = false;
                MessageBox.Show("Cannot read book info from database.");
            }
                   
            bookInfoBox.Text = isSucceded ?
                $"Title: {this.selectedBook.Title}{Environment.NewLine}" +
                $"Author: {this.selectedBook.Author}{Environment.NewLine}" +
                $"Creation year: {this.selectedBook.Year}"
                :
                "Read error";

            bookTextBox.Text = String.Empty;
            this.currentPage = 0;
            
            LoadNextPage();
            //maxPages.Text = $"Max: {GetSelectedBookMaxPage()}";
        }

        private long GetSelectedBookMaxPage()
        {
            FileInfo fi = new FileInfo(GetSelectedBookPath());
            return fi.Length/pageSize;
        }

        private void LoadNextPage()
        {
            LoadBookPage(this.currentPage + 1);
        }

        private void LoadPreviousPage()
        {
           LoadBookPage(this.currentPage - 1);
        }

        private void LoadBookPage(long requiredPage)
        {
            if (requiredPage <= 0) return;
            try
            {
                using (FileStream fs = File.Open(GetSelectedBookPath(), FileMode.Open, FileAccess.Read, FileShare.None))
                using (BufferedStream bs = new BufferedStream(fs))
                using (StreamReader sr = new StreamReader(bs))
                {
                    int pageNumber = 1;
                    var buffer = new char[pageSize];
                    while (sr.ReadBlock(buffer, 0, pageSize) != 0)
                    {
                        if (pageNumber == requiredPage)
                        {
                            var convertedText = new string(buffer);
                            bookTextBox.Text = convertedText;
                            this.currentPage = pageNumber;
                            break;
                        }
                        Array.Clear(buffer, 0, pageSize);
                        pageNumber++;
                    }
                }
            }
            catch(Exception)
            {
               MessageBox.Show("Cannot read book text from file. File or data is damaged or don't exists.");
            }
           
        }

        private string GetSelectedBookPath()
        {
            string path = @"D:\Study\SSP\Lab12\library\";
            path += selectedBook.TextLink;
            return path;
        }

        private void LoadBookList()
        {
            try
            {
                GetBookList();
                booksListBox.DataSource = bookSet.Books;
                booksListBox.DisplayMember = "Name";
                booksListBox.ValueMember = "Id";
            }
            catch(Exception)
            {
                MessageBox.Show("Cannot read from the database.");
            }
            
        }

        private void GetBookList()
        {
            string sql = "SELECT * FROM Books";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connection);

                adapter.Fill(bookSet.Books);
            }

            //string path = Path.Combine(Directory.GetCurrentDirectory(), "books.txt");

            //return File.ReadLines(path)
            //    .Select(book => book.Substring(0, book.IndexOf(':'))).ToArray();
        }

        private Book GetSelectedBookInfo(int id)
        {
            //string path = Path.Combine(Directory.GetCurrentDirectory(), "books.txt");

            //var line = File.ReadLines(path).ElementAtOrDefault(id).Split(':');

            var book = bookSet.Books.FirstOrDefault(x => x.Id == id);

            return new Book()
            {
                Id = book.Id,
                Title = book.Name,
                Author = book.Author,
                Year = book.IssueDateYear,
                TextLink = book.BookFileName
            };
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (selectedBook == null) return;
            LoadPreviousPage();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (selectedBook == null) return;
            LoadNextPage();
        }

        private void UpdateBook_Click(object sender, EventArgs e)
        {
            if (booksListBox.SelectedIndex < 0) return;
            Book book = new Book();
            try
            {
                book = GetSelectedBookInfo(int.Parse(booksListBox.SelectedValue.ToString()));
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot read book info from database.");
            }

            var bookEditForm = new BookEditForm(this, book);
            bookEditForm.ShowDialog();

            LoadBookList();
        }
    }
}