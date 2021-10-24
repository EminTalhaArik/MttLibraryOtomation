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
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            ListStudents();
        }

        StudentManager studentManager = new StudentManager();
        private void ListStudents()
        {
            dgw_students.DataSource = studentManager.GetAll();
            Console.WriteLine("Öğrenciler Listelendi");
        }

        private void tbx_searchstudentschoolno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgw_students.DataSource = studentManager.GetStudents(Convert.ToInt16(tbx_searchstudentschoolno.Text));
            }
            catch { }
        }

        Student selectedStudent = new Student();

        private void btn_searchstudentschoolno_Click(object sender, EventArgs e)
        {
            if (ControlSchoolNo())
            {

                selectedStudent = studentManager.GetStudent(Convert.ToInt16(tbx_searchstudentschoolno.Text));

                tbx_studentname.Text = selectedStudent.Student_name;
                tbx_studentsurname.Text = selectedStudent.Student_surname;
                tbx_schoolno.Text = selectedStudent.School_no.ToString(); ;
                tbx_studentphonenumber.Text = selectedStudent.Studeny_phone_number;
            }
        }

        private bool ControlSchoolNo()
        {
            if (tbx_searchstudentschoolno.Text != null && tbx_searchstudentschoolno.Text != "")
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
            if (ControlStudentNameAndSurname() && ControlStudentPhoneNumber() && ControlStudentSchoolNo())
            {
                studentManager.UpdateStudent(selectedStudent.School_no, new Student(Convert.ToInt16(tbx_schoolno.Text),
                    tbx_studentname.Text,
                    tbx_studentsurname.Text,
                    tbx_studentphonenumber.Text
                    ));
            }

            ListStudents();
        }

        private bool ControlStudentSchoolNo()
        {
            if (tbx_schoolno.Text != null && tbx_schoolno.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ControlStudentNameAndSurname()
        {
            if (tbx_studentname.Text != null && tbx_studentname.Text != "" && tbx_studentsurname.Text != null && tbx_studentsurname.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ControlStudentPhoneNumber()
        {
            if (tbx_studentphonenumber.Text != null && tbx_studentphonenumber.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedStudent != null && ControlSchoolNo())
            {
                studentManager.DeleteStudent(selectedStudent.School_no);
            }
            else
            {
                MessageBox.Show("Lütfen Bir Öğrenci Seçiniz!", "Uyarı");
            }

            ListStudents();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
