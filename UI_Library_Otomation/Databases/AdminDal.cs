using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using UI_Library_Otomation.Entity;

namespace UI_Library_Otomation.Databases
{
    public class AdminDal
    {
        MySqlConnection Connection { get; set; }

        public void SetConnection()
        {
            Connection = new MySqlConnection("Server=127.0.0.1;" +
              "Database=mtt_library_otomation;" +
              "uid=root; " +
              "PORT=3306;" +
              "PWD=thisIsPassword;");
        }

        //Kütüphane Connection String
        //Connection = new MySqlConnection("Server=127.0.0.1;" +
        //      "Database=mtt_library_otomation;" +
        //      "charset=utf8;uid=root; " +
        //      "PORT=3308;" +
        //      "PWD=mttmtal41;");

        public void Create(Admin admin)
        {
            Connection.Open();

            var sql = "INSERT INTO admin(admin_name, admin_surname, admin_username, admin_password) " +
                "VALUES (@admin_name, @admin_surname, @admin_username, @admin_password)";
            var cmd = new MySqlCommand(sql, Connection);

            cmd.Parameters.AddWithValue("@admin_name", admin.Admin_name);
            cmd.Parameters.AddWithValue("@admin_surname", admin.Admin_surname);
            cmd.Parameters.AddWithValue("@admin_username", admin.Admin_username);
            cmd.Parameters.AddWithValue("@admin_password", admin.Admin_password);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            Connection.Close();
            Console.WriteLine("Admin Başarı İle Eklendi!");
        }

        public Admin Get(int id)
        {
            Admin admin = new Admin();

            Connection.Open();

            var sql = "SELECT * FROM admin WHERE admin_id=@id";
            var cmd = new MySqlCommand(sql, Connection);

            cmd.Parameters.AddWithValue("@id", id);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                admin.Admin_id = Convert.ToInt32(reader["admin_id"]);
                admin.Admin_name = Convert.ToString(reader["admin_name"]);
                admin.Admin_surname = Convert.ToString(reader["admin_surname"]);
                admin.Admin_username = Convert.ToString(reader["admin_username"]);
                admin.Admin_password = Convert.ToString(reader["admin_password"]);
            }

            Connection.Close();

            return admin;
        }

        public List<Admin> GetAll()
        {
            List<Admin> admins = new List<Admin>();

            Connection.Open();

            var sql = "SELECT * FROM admin";
            var cmd = new MySqlCommand(sql, Connection);

            long count = Convert.ToInt64(cmd.ExecuteScalar());

            if (count != 0)
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Admin currentAdmin = new Admin();
                    currentAdmin.Admin_id = Convert.ToInt32(reader["admin_id"]);
                    currentAdmin.Admin_name = Convert.ToString(reader["admin_name"]);
                    currentAdmin.Admin_surname = Convert.ToString(reader["admin_surname"]);
                    currentAdmin.Admin_username = Convert.ToString(reader["admin_username"]);
                    currentAdmin.Admin_password = Convert.ToString(reader["admin_password"]);

                    admins.Add(currentAdmin);
                }
            }
            Connection.Close();

            return admins;
        }

        public void Update(Admin admin)
        {
            Console.WriteLine("Admin başarılı bir şekilde güncellendi");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Admin başarılı bir şekilde silindi");
        }
    }
}
