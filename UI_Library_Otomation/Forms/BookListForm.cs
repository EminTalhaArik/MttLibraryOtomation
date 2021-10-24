using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Library_Otomation.Business;
using UI_Library_Otomation.Entity;

namespace UI_Library_Otomation.Forms
{
    public partial class BookListForm : Form
    {
        public BookListForm()
        {
            InitializeComponent();
        }

        private void txt_searchbookbarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgw_books.DataSource = bookManager.GetBooks(txt_searchbookbarcode.Text);
            }
            catch { }
        }

        BookManager bookManager = new BookManager();
        private void ListBooks()
        {
            dgw_books.DataSource = bookManager.GetAll();
            Console.WriteLine("Kitaplar Listelendi!");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {
            ListBooks();
        }

        Book selectedBook = new Book();

        private void btn_searchbookbarcode_Click(object sender, EventArgs e)
        {
            if (ControlBarcode())
            {
                selectedBook = bookManager.GetBook(txt_searchbookbarcode.Text);

                tbx_bookname.Text = selectedBook.Book_name;
                tbx_bookauthor.Text = selectedBook.Book_author;
                tbx_bookno.Text = selectedBook.Book_no.ToString();
                tbx_bookShelfNo.Text = selectedBook.Book_shelf_no.ToString();
            }
        }

        private bool ControlBarcode()
        {
            if (txt_searchbookbarcode.Text != null && txt_searchbookbarcode.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (ControlBookName() && ControlBookAuthor() && ControlBookPageCount())
            {
                bookManager.UpdateBook(selectedBook.Book_barcode,
                    new Book(selectedBook.Book_barcode,
                    tbx_bookname.Text,
                    tbx_bookauthor.Text,
                    tbx_bookno.Text,
                    tbx_bookShelfNo.Text
                    ));
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kitap Seçiniz!", "Uyarı");
            }

            ListBooks();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (ControlBookName() && ControlBookAuthor() && ControlBookPageCount())
            {
                bookManager.DeleteBook(selectedBook.Book_barcode);
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kitap Seçiniz!", "Uyarı");
            }

            ListBooks();
        }

        private bool ControlBookName()
        {
            if (tbx_bookname.Text != null && tbx_bookname.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ControlBookAuthor()
        {
            if (tbx_bookauthor.Text != null && tbx_bookauthor.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ControlBookPageCount()
        {
            if (tbx_bookno.Text != null && tbx_bookno.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
