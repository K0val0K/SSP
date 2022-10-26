using System.Data;
using System.Data.SqlClient;

string connectionString = "Server=(local);Database=Library;Trusted_Connection=True;";

ShowInfo();

while (true)
{
    var key = Console.ReadKey();
    Console.ReadLine();
    switch (key.Key)
    {
        case ConsoleKey.D1: ReadAll(); Console.WriteLine(); break;
        case ConsoleKey.D2: FillDataToInsert(); break;
        case ConsoleKey.D3: SelectDataToDelete(); break;
    }

    ShowInfo();
}


void ShowInfo()
{
    Console.WriteLine("Нажмите 1 для чтения с базы данных");
    Console.WriteLine("Нажмите 2 для добавления в базу данных");
    Console.WriteLine("Нажмите 3 для удаления из базы данных");
}

void ReadAll()
{
    string sql = "SELECT * FROM Books";
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        // Создаем объект DataAdapter
        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
        // Создаем объект DataSet
        DataSet ds = new DataSet();
        // Заполняем Dataset
        adapter.Fill(ds);

        foreach (DataTable dt in ds.Tables)
        {
            foreach (DataColumn column in dt.Columns)
                Console.Write($"{column.ColumnName}\t");
            Console.WriteLine();
            // перебор всех строк таблицы
            foreach (DataRow row in dt.Rows)
            {
                // получаем все ячейки строки
                var cells = row.ItemArray;
                foreach (object cell in cells)
                    Console.Write($"{cell}\t");
                Console.WriteLine();
            }
        }


    }
}

void SelectDataToDelete()
{
    ReadAll();
    Console.WriteLine("Введите id книги для удаления");
    var id = int.Parse(Console.ReadLine());

    DeleteFromTableById(id);
    Console.WriteLine();
    ReadAll();
}

void DeleteFromTableById(int id)
{
    string sqlExpression = $"DELETE  FROM Books WHERE Id={id}";
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        int number = command.ExecuteNonQuery();
        Console.WriteLine("Удалено объектов: {0}", number);
    }
}

void FillDataToInsert()
{
    Console.Write("Название книги: ");
    var name = Console.ReadLine();

    Console.Write("Имя автора: ");
    var author = Console.ReadLine();

    Console.Write("Год написания: ");
    var year = Console.ReadLine();

    Console.Write("Файл книги: ");
    var fileName = Console.ReadLine();

    InsertDataToTable(name, author, int.Parse(year), fileName);
    Console.WriteLine();
    ReadAll();
}

void InsertDataToTable(string Name, string Author, int IssueDateYear, string BookFileName)
{
    string sqlExpression = $"INSERT INTO Books (Name, Author, IssueDateYear, BookFileName) VALUES ('{Name}', '{Author}', {IssueDateYear}, '{BookFileName}')";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        int number = command.ExecuteNonQuery();
        Console.WriteLine("Добавлено объектов: {0}", number);
    }
}

