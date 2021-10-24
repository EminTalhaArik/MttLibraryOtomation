using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Library_Otomation.Entity;

namespace UI_Library_Otomation.Databases
{
    public class StudentDal
    {
        MySqlConnection Connection { get; set; }

        public void SetConnection()
        {
            Connection = new MySqlConnection("Server=127.0.0.1;" +
              "Database=mtt_library_otomation;" +
              "charset=utf8;uid=root; " +
              "PORT=3306;" +
              "PWD=thisIsPassword;");
        }

        //Kütüphane Connection String
        //Connection = new MySqlConnection("Server=127.0.0.1;" +
        //      "Database=mtt_library_otomation;" +
        //      "charset=utf8;uid=root; " +
        //      "PORT=3308;" +
        //      "PWD=mttmtal41;");
        public void Create(Student student)
        {
            Connection.Open();
            try
            {
                var sql = "INSERT INTO student(school_no, student_name, student_surname, student_phone_number) " +
                    "VALUES (@school_no, @student_name, @student_surname, @student_phone_number)";
                var cmd = new MySqlCommand(sql, Connection);

                cmd.Parameters.AddWithValue("@school_no", student.School_no);
                cmd.Parameters.AddWithValue("@student_name", student.Student_name);
                cmd.Parameters.AddWithValue("@student_surname", student.Student_surname);
                cmd.Parameters.AddWithValue("@student_phone_number", student.Studeny_phone_number);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Öğrenci Başarı İle Eklendi!", "Uyarı");
            }
            catch (Exception e)
            {
                Console.WriteLine("Sistem Bir Hata İle Karşılaştı {0}", e);
                MessageBox.Show("Sistem Bir Hata İle Karşılaştı", "Uyarı");

            }
            finally
            {
                Connection.Close();
            }
            Console.WriteLine("Öğrenci Başarı İle Eklendi!");
        }

        public Student Get(short school_id)
        {
            Student student = new Student();

            Connection.Open();

            try
            {
                var sql = "SELECT * FROM student WHERE school_no LIKE '" + school_id + "%'";
                var cmd = new MySqlCommand(sql, Connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    student.School_no = Convert.ToInt16(reader["school_no"]);
                    student.Student_name = Convert.ToString(reader["student_name"]);
                    student.Student_surname = Convert.ToString(reader["student_surname"]);
                    student.Studeny_phone_number = Convert.ToString(reader["student_phone_number"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sistem Bir Hata İle Karşılaştı {0}", e);
                MessageBox.Show("Sistem Bir Hata İle Karşılaştı", "Uyarı");

            }
            finally
            {
                Connection.Close();
            }

            return student;
        }

        public List<Student> GetAll()
        {
            List<Student> student = new List<Student>();

            Connection.Open();
            try
            {
                var sql = "SELECT * FROM student";
                var cmd = new MySqlCommand(sql, Connection);

                long count = Convert.ToInt64(cmd.ExecuteScalar());

                if (count != 0)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Student currentStudent = new Student();
                        currentStudent.School_no = Convert.ToInt16(reader["school_no"]);
                        currentStudent.Student_name = Convert.ToString(reader["student_name"]);
                        currentStudent.Student_surname = Convert.ToString(reader["student_surname"]);
                        currentStudent.Studeny_phone_number = Convert.ToString(reader["student_phone_number"]);

                        student.Add(currentStudent);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sistem Bir Hata İle Karşılaştı {0}", e);
                MessageBox.Show("Sistem Bir Hata İle Karşılaştı", "Uyarı");

            }
            finally
            {
                Connection.Close();
            }

            return student;
        }

        public List<Student> GetAllSearchedStudents(short school_no)
        {
            List<Student> students = new List<Student>();

            Connection.Open();
            try
            {
                var sql = "SELECT * FROM student WHERE school_no LIKE '" + school_no + "%'";
                var cmd = new MySqlCommand(sql, Connection);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count != 0)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Student currentStudent = new Student();
                        currentStudent.School_no = Convert.ToInt16(reader["school_no"]);
                        currentStudent.Student_name = Convert.ToString(reader["student_name"]);
                        currentStudent.Student_surname = Convert.ToString(reader["student_surname"]);
                        currentStudent.Studeny_phone_number = Convert.ToString(reader["student_phone_number"]);

                        students.Add(currentStudent);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sistem Bir Hata İle Karşılaştı {0}", e);
                MessageBox.Show("Sistem Bir Hata İle Karşılaştı", "Uyarı");

            }
            finally
            {
                Connection.Close();
            }

            return students;
        }

        public void Update(Student student)
        {
            Connection.Open();

            try
            {
                var sql = "UPDATE student SET student_name = @student_name, student_surname = @student_surname , student_phone_number = @student_phone_number WHERE school_no=" + student.School_no;
                var cmd = new MySqlCommand(sql, Connection);

                cmd.Parameters.AddWithValue("@student_name", student.Student_name);
                cmd.Parameters.AddWithValue("@student_surname", student.Student_surname);
                cmd.Parameters.AddWithValue("@student_phone_number", student.Studeny_phone_number);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Öğrenci Kaydı Başarı İle Güncellendi!");

            }
            catch (Exception e)
            {
                Console.WriteLine("Sistem Bir Hata İle Karşılaştı {0}", e);
                MessageBox.Show("Sistem Bir Hata İle Karşılaştı", "Uyarı");

            }
            finally
            {
                Connection.Close();
            }

            Console.WriteLine("Öğrenci başarı ile güncellendi");
        }

        public void Delete(short school_no)
        {
            Connection.Open();

            try
            {
                var sql = "DELETE FROM student WHERE school_no=@school_no";
                var cmd = new MySqlCommand(sql, Connection);

                cmd.Parameters.AddWithValue("@school_no", school_no);
                cmd.Prepare();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Öğrenci Kaydı Başarı İle Silindi!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Sistem Bir Hata İle Karşılaştı {0}", e);
                MessageBox.Show("Sistem Bir Hata İle Karşılaştı", "Uyarı");

            }
            finally
            {
                Connection.Close();
            }

            Console.WriteLine("Öğrenci Başarı İle Silindi");
        }
    }
}
