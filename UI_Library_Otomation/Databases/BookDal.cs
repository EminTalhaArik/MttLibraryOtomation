using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Library_Otomation.Entity;

namespace UI_Library_Otomation.Databases
{
    public class BookDal
    {
        MySqlConnection Connection { get; set; }

        public void SetConnection()
        {
            Connection = new MySqlConnection("Server=127.0.0.1;" +
              "Database=mtt_library_otomation;" +
              "charset=utf8;uid=root; " +
              "PORT=3306;" +
              "PWD=thisIsPassword;");
        }

        //Kütüphane Connection String
        //Connection = new MySqlConnection("Server=127.0.0.1;" +
        //      "Database=mtt_library_otomation;" +
        //      "charset=utf8;uid=root; " +
        //      "PORT=3308;" +
        //      "PWD=mttmtal41;");

        public void Create(Book book)
        {
            Connection.Open();
            try
            {
                var sql = "INSERT INTO book(book_name, book_author, book_page_count, book_barcode, book_shelf_no) " +
                    "VALUES (@book_name, @book_author, @book_no, @book_barcode, @book_shelf_no)";
                var cmd = new MySqlCommand(sql, Connection);

                cmd.Parameters.AddWithValue("@book_name", book.Book_name);
                cmd.Parameters.AddWithValue("@book_author", book.Book_author);
                cmd.Parameters.AddWithValue("@book_no", book.Book_no);
                cmd.Parameters.AddWithValue("@book_shelf_no", book.Book_shelf_no);
                cmd.Parameters.AddWithValue("@book_barcode", book.Book_barcode);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Kitap Başarı İle Eklendi!", "Uyarı");
            }
            catch (Exception e)
            {
                Console.WriteLine("Sistem Bir Hata İle Karşılaştı {0}", e);
                MessageBox.Show("Sistem Bir Hata İle Karşılaştı", "Uyarı");

            }
            finally
            {
                Connection.Close();
            }
            Console.WriteLine("Kitap Başarı İle Eklendi!");
        }

        public Book Get(string barcode)
        {
            Book book = new Book();

            Connection.Open();

            try
            {
                var sql = "SELECT * FROM book WHERE book_barcode LIKE '" + barcode + "%'";
                var cmd = new MySqlCommand(sql, Connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    book.Book_barcode = Convert.ToString(reader["book_barcode"]);
                    book.Book_name = Convert.ToString(reader["book_name"]);
                    book.Book_author = Convert.ToString(reader["book_author"]);
                    book.Book_no = Convert.ToString(reader["book_no"]);
                    book.Book_shelf_no = Convert.ToString(reader["book_shelf_no"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sistem Bir Hata İle Karşılaştı {0}", e);
                MessageBox.Show("Sistem Bir Hata İle Karşılaştı", "Uyarı");

            }
            finally
            {
                Connection.Close();
            }

            return book;
        }

        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();

            Connection.Open();
            try
            {
                var sql = "SELECT * FROM book";
                var cmd = new MySqlCommand(sql, Connection);

                long count = Convert.ToInt64(cmd.ExecuteScalar());

                if (count != 0)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Book currentBook = new Book();
                        currentBook.Book_barcode = Convert.ToString(reader["book_barcode"]);
                        currentBook.Book_name = Convert.ToString(reader["book_name"]);
                        currentBook.Book_author = Convert.ToString(reader["book_author"]);
                        currentBook.Book_no = Convert.ToString(reader["book_no"]);
                        currentBook.Book_shelf_no = Convert.ToString(reader["book_shelf_no"]);

                        books.Add(currentBook);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sistem Bir Hata İle Karşılaştı {0}", e);
                MessageBox.Show("Sistem Bir Hata İle Karşılaştı", "Uyarı");

            }
            finally
            {
                Connection.Close();
            }

            return books;
        }

        public List<Book> GetAllSearchedBook(string barcode)
        {
            List<Book> books = new List<Book>();

            Connection.Open();
            try
            {
                var sql = "SELECT * FROM book WHERE book_barcode LIKE '" + barcode + "%'";
                var cmd = new MySqlCommand(sql, Connection);

                long count = Convert.ToInt64(cmd.ExecuteScalar());

                if (count != 0)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Book currentBook = new Book();
                        currentBook.Book_barcode = Convert.ToString(reader["book_barcode"]);
                        currentBook.Book_name = Convert.ToString(reader["book_name"]);
                        currentBook.Book_author = Convert.ToString(reader["book_author"]);
                        currentBook.Book_no = Convert.ToString(reader["book_no"]);
                        currentBook.Book_shelf_no = Convert.ToString(reader["book_shelf_no"]);

                        books.Add(currentBook);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sistem Bir Hata İle Karşılaştı {0}", e);
                MessageBox.Show("Sistem Bir Hata İle Karşılaştı", "Uyarı");

            }
            finally
            {
                Connection.Close();
            }

            return books;
        }

        public void Update(Book book)
        {
            Connection.Open();

            try
            {
                var sql = "UPDATE book SET book_name = @book_name , book_author = @book_author , book_shelf_no = @book_shelf_no ,book_no = @book_no WHERE book_barcode=" + book.Book_barcode;
                var cmd = new MySqlCommand(sql, Connection);

                cmd.Parameters.AddWithValue("@book_name", book.Book_name);
                cmd.Parameters.AddWithValue("@book_author", book.Book_author);
                cmd.Parameters.AddWithValue("@book_no", book.Book_no);
                cmd.Parameters.AddWithValue("@book_shelf_no", book.Book_shelf_no);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Kitap Başarı İle Güncellendi", "Uyarı");
            }
            catch (Exception e)
            {
                Console.WriteLine("Sistem Bir Hata İle Karşılaştı {0}", e);
                MessageBox.Show("Sistem Bir Hata İle Karşılaştı", "Uyarı");

            }
            finally
            {
                Connection.Close();
            }

            Console.WriteLine("Kitap başarı ile güncellendi");
        }

        public void Delete(string book_barcode)
        {
            Connection.Open();

            try
            {
                var sql = "DELETE FROM book WHERE book_barcode=@book_barcode";
                var cmd = new MySqlCommand(sql, Connection);

                cmd.Parameters.AddWithValue("@book_barcode", book_barcode);
                cmd.Prepare();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Kitap Başarı İle Silindi", "Uyarı");
            }
            catch (Exception e)
            {
                Console.WriteLine("Sistem Bir Hata İle Karşılaştı {0}", e);
                MessageBox.Show("Sistem Bir Hata İle Karşılaştı", "Uyarı");

            }
            finally
            {
                Connection.Close();
            }

            Console.WriteLine("Kitap Başarı İle Silindi");
        }
    }
}
