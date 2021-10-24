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

namespace UI_Library_Otomation.Forms
{
    public partial class MainForm : Form
    {
        ProcessManager processManager = new ProcessManager();

        public MainForm(string enteredWorker)
        {
            InitializeComponent();

            if (enteredWorker == "Görevli")
            {
                btn_addbook.Visible = false;
                btn_studentmanagement.Visible = false;
            }
            else
            {

            }
        }

        private void btn_studentmanagement_Click(object sender, EventArgs e)
        {
            processManager.StudentManagementFormButton();
            //this.Hide();
        }

        private void btn_bookmanagement_Click(object sender, EventArgs e)
        {
            processManager.BookManagementFormButton();
            //this.Hide();
        }

        private void btn_addbook_Click(object sender, EventArgs e)
        {
            processManager.AddBookFormButton();
            //this.Hide();
        }

        private void btn_service_Click(object sender, EventArgs e)
        {
            processManager.ServiceManagementFormButton();
            //this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            processManager.LoginFormButton();
            this.Hide();
        }

        private void btn_studentlist_Click(object sender, EventArgs e)
        {
            processManager.StudentListFormButton();
            //this.Hide();
        }

        private void btn_booklist_Click(object sender, EventArgs e)
        {
            processManager.BookListFormButton();
            //this.Hide();
        }

        private void btn_servicelist_Click(object sender, EventArgs e)
        {
            processManager.ServiceListFormButton();
            //this.Hide();
        }
    }
}
