namespace Lab1
{
    public partial class BookReaderForm : Form
    {
        private Book selectedBook;
        private int currentPage = 0;

        int pageSize = 256;
        public BookReaderForm()
        {
            InitializeComponent();
            booksListBox.SelectionMode = SelectionMode.One;
            LoadBookList();
        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {
            if (booksListBox.SelectedIndex < 0) return;

            this.selectedBook = new Book();
            bool isSucceded = true;
            try
            {
                this.selectedBook = GetSelectedBookInfo(booksListBox.SelectedIndex);
            } catch(Exception)
            {
                isSucceded = false;
                MessageBox.Show("Ошибка чтения информации из файла. Файл либо данные повреждены или отсутвуют.");
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
            maxPages.Text = $"Max: {GetSelectedBookMaxPage().ToString()}";
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
            }catch(Exception)
            {
               MessageBox.Show("Ошибка чтения информации из файла. Файл либо данные повреждены или отсутвуют.");
            }
           
        }

        private string GetSelectedBookPath()
        {
            string path = @"D:\Study\SSP\Lab1\v1library\";
            path += selectedBook.TextLink;
            return path;
        }

        private void LoadBookList()
        {
            try
            {
                booksListBox.Items.AddRange(GetBookList());
            }
            catch(Exception)
            {
                MessageBox.Show("Ошибка чтения информации из файла.");
            }
            
        }

        private string[] GetBookList()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "books.txt");

            return File.ReadLines(path)
                .Select(book => book.Substring(0, book.IndexOf(':'))).ToArray();
        }

        private Book GetSelectedBookInfo(int id)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "books.txt");

            var line = File.ReadLines(path).ElementAtOrDefault(id).Split(':');

            return new Book()
            {
                Title = line[0],
                Author = line[1],
                Year = int.Parse(line[2]),
                TextLink = line[3]
            };
        }

        private void BookReaderForm_Load(object sender, EventArgs e)
        {

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
    }
}