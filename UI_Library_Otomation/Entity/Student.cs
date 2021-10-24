using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library_Otomation.Entity
{
    public class Student
    {
        private short school_no;
        private string student_name;
        private string student_surname;
        private string student_phone_number;

        public Student(short school_no, string student_name, string student_surname, string studeny_phone_number)
        {
            this.school_no = school_no;
            this.student_name = student_name;
            this.student_surname = student_surname;
            this.student_phone_number = studeny_phone_number;
        }

        public Student()
        {

        }

        public short School_no { get => school_no; set => school_no = value; }
        public string Student_name { get => student_name; set => student_name = value; }
        public string Student_surname { get => student_surname; set => student_surname = value; }
        public string Studeny_phone_number { get => student_phone_number; set => student_phone_number = value; }
    }
}
