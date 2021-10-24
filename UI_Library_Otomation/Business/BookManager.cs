using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Library_Otomation.Databases;
using UI_Library_Otomation.Entity;

namespace UI_Library_Otomation.Business
{
    public class BookManager
    {
        BookDal bookDal = new BookDal();

        public void AddBook(Book book)
        {
            bookDal.SetConnection();
            bool isCreatable = true;
            foreach (var gettingBook in bookDal.GetAll())
            {
                if (gettingBook.Book_barcode == book.Book_barcode)
                {
                    Console.WriteLine("Obje Eklenemiyor!");
                    isCreatable = false;
                }
            }
            if (isCreatable)
            {
                bookDal.Create(book);
            }
            else
            {
                Console.WriteLine("Aynı kayıt birden fazla olamaz!");
                MessageBox.Show("Aynı kayıt birden fazla olamaz!", "Uyarı");
            }
        }

        public List<Book> GetAll()
        {
            bookDal.SetConnection();
            return bookDal.GetAll();
        }

        public Book GetBook(string barcode)
        {
            bookDal.SetConnection();
            return bookDal.Get(barcode);
        }
        public List<Book> GetBooks(string barcode)
        {
            bookDal.SetConnection();
            return bookDal.GetAllSearchedBook(barcode);
        }

        public void UpdateBook(string book_barcode, Book newBook)
        {
            newBook.Book_barcode = book_barcode;
            bookDal.Update(newBook);
        }

        public void DeleteBook(string book_barcode)
        {
            bookDal.Delete(book_barcode);
        }
    }
}
