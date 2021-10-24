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
    public partial class AddBookForm : Form
    {
        ProcessManager processManager = new ProcessManager();

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btn_studentmanagement_Click(object sender, EventArgs e)
        {
            processManager.StudentManagementFormButton();
            this.Hide();
        }

        private void btn_bookmanagement_Click(object sender, EventArgs e)
        {
            processManager.BookManagementFormButton();
            this.Hide();
        }

        private void btn_addbook_Click(object sender, EventArgs e)
        {
            processManager.AddBookFormButton();
            this.Hide();
        }

        private void btn_service_Click(object sender, EventArgs e)
        {
            processManager.ServiceManagementFormButton();
            this.Hide();
        }

        BookManager bookManager = new BookManager();

        private void btn_addbooks_Click(object sender, EventArgs e)
        {
            if (ControlBookName() && ControlBookBarcode() && ControlBookPageCount() && ControlBookAuthor())
            {
                bookManager.AddBook(new Book(txt_bookbarcode.Text.ToString(),
                    txt_bookname.Text.ToString(),
                    txt_bookauthor.Text.ToString(),
                    txt_bookNo.Text.ToString(),
                    txt_bookShelfNo.Text.ToString()
                    ));
                ResetTextBoxes();
            }
            else
            {
                Console.WriteLine("Lütfen Tüm Boşlukları Doldurunuz!");
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
            }
        }

        private bool ControlBookName()
        {
            if (txt_bookname.Text != "" && txt_bookname.Text != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ControlBookBarcode()
        {
            if (txt_bookbarcode.Text != "" && txt_bookbarcode.Text != null)
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
            if (txt_bookNo.Text != "" && txt_bookNo.Text != null)
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
            if (txt_bookauthor.Text != "" && txt_bookauthor.Text != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ResetTextBoxes()
        {
            txt_bookauthor.Text = "";
            txt_bookbarcode.Text = "";
            txt_bookname.Text = "";
            txt_bookNo.Text = "";
        }
    }
}
