using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomeWork1.ADO.NET
{
    public partial class Form1 : Form
    {


        private string ConnectionString = "Data Source=ASD-FGQ8P13;Integrated Security=True;Connect Timeout=30;";
        private SqlConnection connection = null;
        private string DatabaseName = "Library";
        private string SQLExpression = @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Books')
                                        BEGIN
                                        CREATE TABLE Books (
                                        BookID INT PRIMARY KEY IDENTITY(1,1),
                                        Title NVARCHAR(100) NOT NULL,
                                        Author NVARCHAR(100) NOT NULL,
                                        PublicationYear INT,
                                        TotalCopies INT,
                                        CopiesInLibrary INT
                                        );
                                        END";

        public Form1()
        {
            InitializeComponent();
            tbConnectionString.Text = ConnectionString;

        }

        private void buttonCreateBD_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                connection.Close();
                connection = null;
                return;
            }
            using (SqlConnection masterConnection = new SqlConnection(ConnectionString))
            {
                masterConnection.Open();
                SqlCommand createDbCommand = new SqlCommand($"IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'Library')" +
                    $"BEGIN" +
                    $" CREATE DATABASE Library;" +
                    $"END", masterConnection);
                createDbCommand.ExecuteNonQuery(); // выполнили запрос
            }
            using (SqlConnection connection = new SqlConnection($"{ConnectionString};Database={DatabaseName}"))
            {
                connection.Open();
                SqlCommand createTableCommand = new SqlCommand(SQLExpression, connection);
                createTableCommand.ExecuteNonQuery();// выполнили запрос
            }

        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            string fillDataBase = @"INSERT INTO Books (Title, Author, PublicationYear, TotalCopies, CopiesInLibrary) VALUES 
                                ('С++', 'Олег Иванов', 2020, 2000, 10),
                                ('С', 'Олег Иванов', 2019, 2001, 20),
                                ('Java', 'Олег Иванов', 2018, 200, 30),
                                ('JavaScript', 'Олег Иванов', 2017, 1500, 40),
                                ('PHP', 'Олег Газманов', 2020, 200, 50);";


            try
            {
                using (SqlConnection connectionFillBD = new SqlConnection(ConnectionString))
                {
                    connectionFillBD.Open();
                    SqlCommand fillBD = new SqlCommand(fillDataBase, connectionFillBD);
                    int rowsAffected = fillBD.ExecuteNonQuery(); // Выполняем вставку данных
                    if (rowsAffected > 0)
                    {
                        textBox1.Text = $"Данные успешно добавлены в базу {DatabaseName}.";
                    }
                    else
                    {
                        textBox1.Text = $"Данные не добавлены в базу {DatabaseName}.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }



        }

        private void buttonAuthor_Click(object sender, EventArgs e)
        {
            string authorName = textBox2.Text;
            string _Expression =
                @"SELECT COUNT(*) AS TotalBooks
           FROM Books
           WHERE Author = @AuthorName;";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(_Expression, connection);
                command.Parameters.AddWithValue("@AuthorName", authorName);

                using (SqlDataReader _reader = command.ExecuteReader())
                {
                    if (_reader.HasRows && _reader.Read())
                    {
                        object totalBooks = _reader["TotalBooks"];
                        textBox1.Text =  $"Количество книг автора: {totalBooks.ToString()}";
                    }
                    else
                    {
                        textBox1.Text = "Автор не найден";
                    }
                }
            }
        }

        private void buttonTitle_Click(object sender, EventArgs e)
        {
            string bookTitle = textBox3.Text;
            string _Expression =
                @"SELECT COUNT(*) AS TotalBooks
                FROM Books
                WHERE Title = @bookTitle;";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(_Expression, connection);
                command.Parameters.AddWithValue("@bookTitle", bookTitle);

                using (SqlDataReader _reader = command.ExecuteReader())
                {
                    if (_reader.HasRows && _reader.Read())
                    {
                        object totalBooks = _reader["TotalBooks"];
                        textBox1.Text = $"Количество книг : {totalBooks.ToString()}";
                    }
                    else
                    {
                        textBox1.Text = "Книги не найдены";
                    }
                }
            }

        }
    }
}
