using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library_Otomation.Entity
{
    public class Book
    {
        private string book_barcode;
        private string book_name;
        private string book_author;
        private string book_no;
        private string book_shelf_no;

        public Book(string book_barcode, string book_name, string book_author, string book_no, string book_shelf_no)
        {
            this.Book_barcode = book_barcode;
            this.Book_name = book_name;
            this.Book_author = book_author;
            this.Book_no = book_no;
            this.book_shelf_no = book_shelf_no;
        }

        public Book()
        {

        }

        public string Book_barcode { get => book_barcode; set => book_barcode = value; }
        public string Book_name { get => book_name; set => book_name = value; }
        public string Book_author { get => book_author; set => book_author = value; }
        public string Book_no { get => book_no; set => book_no = value; }
        public string Book_shelf_no { get => book_shelf_no; set => book_shelf_no = value; }

    }
}
