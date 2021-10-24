using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library_Otomation.Forms;

namespace UI_Library_Otomation.Business
{
    public class ProcessManager
    {
        public void AddBookFormButton()
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.Show();
        }

        public void StudentManagementFormButton()
        {
            StudentManagementForm studentManagementForm = new StudentManagementForm();
            studentManagementForm.Show();
        }

        public void BookManagementFormButton()
        {
            AddBookForm bookManagementForm = new AddBookForm();
            bookManagementForm.Show();
        }

        public void ServiceManagementFormButton()
        {
            ServiceManagementForm serviceManagementForm = new ServiceManagementForm();
            serviceManagementForm.Show();
        }

        public void MainFormButton()
        {
            MainForm mainForm = new MainForm("");
            mainForm.Show();
        }

        public void LoginFormButton()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        public void StudentListFormButton()
        {
            StudentListForm studentListForm = new StudentListForm();
            studentListForm.Show();
        }

        public void BookListFormButton()
        {
            BookListForm bookListForm = new BookListForm();
            bookListForm.Show();
        }

        public void ServiceListFormButton()
        {
            ServiceListForm serviceListForm = new ServiceListForm();
            serviceListForm.Show();
        }
    }
}
