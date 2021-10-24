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
    public class StudentManager
    {
        StudentDal studentDal = new StudentDal();
        public void AddStudent(Student student)
        {
            studentDal.SetConnection();
            bool isCreatable = true;
            foreach (var gettingStudent in studentDal.GetAll())
            {
                if (gettingStudent.School_no == student.School_no)
                {
                    Console.WriteLine("Obje Eklenemiyor");
                    isCreatable = false;

                }
            }
            if (isCreatable)
            {
                studentDal.Create(student);
            }
            else
            {
                Console.WriteLine("Aynı kayıt birden fazla olamaz!");
                MessageBox.Show("Aynı kayıt birden fazla olamaz!", "Uyarı");
            }
        }

        public List<Student> GetAll()
        {
            studentDal.SetConnection();
            return studentDal.GetAll();
        }

        public List<Student> GetStudents(short schoolNo)
        {
            studentDal.SetConnection();
            return studentDal.GetAllSearchedStudents(Convert.ToInt16(schoolNo));
        }

        public Student GetStudent(short schoolNo)
        {
            studentDal.SetConnection();
            return studentDal.Get(schoolNo);
        }

        public void UpdateStudent(short schoolNo, Student newStudent)
        {
            studentDal.SetConnection();
            newStudent.School_no = schoolNo;
            studentDal.Update(newStudent);
        }

        public void DeleteStudent(short schoolNo)
        {
            studentDal.SetConnection();
            studentDal.Delete(schoolNo);
        }
    }
}
