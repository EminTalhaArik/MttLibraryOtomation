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
    public partial class StudentManagementForm : Form
    {
        ProcessManager processManager = new ProcessManager();

        public StudentManagementForm()
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

        private void btn_servicemanagement_Click(object sender, EventArgs e)
        {
            processManager.ServiceManagementFormButton();
            this.Hide();
        }

        StudentManager studentManager = new StudentManager();
        private void btn_addstudent_Click(object sender, EventArgs e)
        {
            if (ControlStudentSchoolNumber() && ControlStudentName() && ControlStudentSurname())
            {
                studentManager.AddStudent(new Student(
                Convert.ToInt16(txt_studentschoolno.Text),
                txt_studentname.Text.ToString(),
                txt_studentsurname.Text.ToString(),
                txt_studentphonenumber.Text.ToString()));
                ResetTextBoxes();
            }
            else
            {
                Console.WriteLine("Lütfen Önemli Boşlukları Doldurunuz!");
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
            }
        }

        private bool ControlStudentSchoolNumber()
        {
            if (txt_studentschoolno.Text != null && txt_studentschoolno.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ControlStudentName()
        {
            if (txt_studentname.Text != null && txt_studentname.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ControlStudentSurname()
        {
            if (txt_studentsurname.Text != null && txt_studentsurname.Text != "")
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
            txt_studentname.Text = "";
            txt_studentsurname.Text = "";
            txt_studentschoolno.Text = "";
            txt_studentphonenumber.Text = "";
        }
    }
}
