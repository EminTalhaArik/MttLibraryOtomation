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
    class ServiceDal
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
        public void Create(Student student, Book book, DateTime purchaseDate)
        {
            Connection.Open();
            try
            {
                var sql = "INSERT INTO service(school_no, book_barcode, purchase_date) " +
                    "VALUES (@school_no, @book_barcode, @purchase_date)";
                var cmd = new MySqlCommand(sql, Connection);

                cmd.Parameters.AddWithValue("@school_no", student.School_no);
                cmd.Parameters.AddWithValue("@book_barcode", book.Book_barcode);
                cmd.Parameters.AddWithValue("@purchase_date", purchaseDate);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Emanet Başarılı Bir Şekilde Verildi", "Uyarı");
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
            Console.WriteLine("Servis Başarı İle Eklendi!");
        }

        public Service GetByServiceID(int service_id)
        {
            Service service = new Service();

            Connection.Open();

            try
            {
                var sql = "SELECT * FROM service WHERE service_id=@service_id";
                var cmd = new MySqlCommand(sql, Connection);

                cmd.Parameters.AddWithValue("@service_id", service_id);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    service.Service_id = Convert.ToInt16(reader["service_id"]);
                    service.School_no = Convert.ToInt16(reader["school_no"]);
                    service.Book_barcode = Convert.ToString(reader["book_barcode"]);
                    service.Purchase_date = Convert.ToDateTime(reader["purchase_date"]);

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

            return service;
        }

        public Service GetBySchoolNo(short school_no)
        {
            Service service = new Service();

            Connection.Open();

            try
            {
                var sql = "SELECT * FROM service WHERE school_no=@school_no";
                var cmd = new MySqlCommand(sql, Connection);

                cmd.Parameters.AddWithValue("@school_no", school_no);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    service.Service_id = Convert.ToInt16(reader["service_id"]);
                    service.School_no = Convert.ToInt16(reader["school_no"]);
                    service.Book_barcode = Convert.ToString(reader["book_barcode"]);
                    service.Purchase_date = Convert.ToDateTime(reader["purchase_date"]);
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

            return service;
        }

        public Service GetByBookBarcode(string book_barcode)
        {
            Service service = new Service();

            Connection.Open();

            try
            {
                var sql = "SELECT * FROM service WHERE book_barcode=@book_barcode";
                var cmd = new MySqlCommand(sql, Connection);

                cmd.Parameters.AddWithValue("@book_barcode", book_barcode);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    service.Service_id = Convert.ToInt16(reader["service_id"]);
                    service.School_no = Convert.ToInt16(reader["school_no"]);
                    service.Book_barcode = Convert.ToString(reader["book_barcode"]);
                    service.Purchase_date = Convert.ToDateTime(reader["purchase_date"]);
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

            return service;
        }



        public List<Service> GetAll()
        {
            List<Service> services = new List<Service>();

            Connection.Open();
            try
            {
                var sql = "SELECT * FROM service";
                var cmd = new MySqlCommand(sql, Connection);

                long count = Convert.ToInt64(cmd.ExecuteScalar());

                if (count != 0)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Service currentService = new Service();
                        currentService.School_no = Convert.ToInt16(reader["school_no"]);
                        currentService.Book_barcode = Convert.ToString(reader["book_barcode"]);
                        currentService.Purchase_date = Convert.ToDateTime(reader["purchase_date"]);

                        services.Add(currentService);
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

            return services;
        }

        public List<Service> GetAllBySchoolNo(short school_no)
        {
            List<Service> services = new List<Service>();

            Connection.Open();
            try
            {
                var sql = "SELECT * FROM service WHERE school_no LIKE '" + school_no + "%'";
                var cmd = new MySqlCommand(sql, Connection);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count != 0)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Service currentService = new Service();
                        currentService.School_no = Convert.ToInt16(reader["school_no"]);
                        currentService.Book_barcode = Convert.ToString(reader["book_barcode"]);
                        currentService.Purchase_date = Convert.ToDateTime(reader["purchase_date"]);

                        services.Add(currentService);
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

            return services;
        }

        public List<Service> GetAllByBarcode(string barcode)
        {
            List<Service> services = new List<Service>();

            Connection.Open();
            try
            {
                var sql = "SELECT * FROM service WHERE book_barcode LIKE '" + barcode + "%'";
                var cmd = new MySqlCommand(sql, Connection);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count != 0)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Service currentService = new Service();
                        currentService.School_no = Convert.ToInt16(reader["school_no"]);
                        currentService.Book_barcode = Convert.ToString(reader["book_barcode"]);
                        currentService.Purchase_date = Convert.ToDateTime(reader["purchase_date"]);

                        services.Add(currentService);
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

            return services;
        }

        public List<Service> GetAllByBookName(string name)
        {
            List<Service> services = new List<Service>();

            Connection.Open();
            try
            {
                var sql = "SELECT * FROM service WHERE book_name LIKE '" + name + "%'";
                var cmd = new MySqlCommand(sql, Connection);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count != 0)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Service currentService = new Service();
                        currentService.School_no = Convert.ToInt16(reader["school_no"]);
                        currentService.Book_barcode = Convert.ToString(reader["book_barcode"]);
                        currentService.Purchase_date = Convert.ToDateTime(reader["purchase_date"]);

                        services.Add(currentService);
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

            return services;
        }

        public void UpdateBySchoolNo(Service service)
        {
            Connection.Open();

            try
            {
                var sql = "UPDATE service SET @service WHERE school_no=" + service.School_no;
                var cmd = new MySqlCommand(sql, Connection);

                cmd.Parameters.AddWithValue("@service", service);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

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

            Console.WriteLine("Servis başarı ile güncellendi");
        }

        public void UpdateByBookBarcode(Service service)
        {
            Connection.Open();

            try
            {
                var sql = "UPDATE service SET @service WHERE book_Barcode=" + service.Book_barcode;
                var cmd = new MySqlCommand(sql, Connection);

                cmd.Parameters.AddWithValue("@service", service);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

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

            Console.WriteLine("Servis başarı ile güncellendi");
        }

        public void DeleteBySchoolNo(short school_no)
        {
            Connection.Open();

            try
            {
                var sql = "DELETE FROM service WHERE school_no=@school_no";
                var cmd = new MySqlCommand(sql, Connection);

                cmd.Parameters.AddWithValue("@school_no", school_no);
                cmd.Prepare();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Emanet Başarılı Bir Şekilde Alındı", "Uyarı");

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

            Console.WriteLine("Servis Başarı İle Silindi");
        }

        public void DeleteByBookBarcode(string book_barcode)
        {
            Connection.Open();

            try
            {
                var sql = "DELETE FROM service WHERE book_barcode=@book_barcode";
                var cmd = new MySqlCommand(sql, Connection);

                cmd.Parameters.AddWithValue("@book_barcode", book_barcode);
                cmd.Prepare();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Emanet Başarılı Bir Şekilde Alındı", "Uyarı");
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

            Console.WriteLine("Servis Başarı İle Silindi");
        }

        //Emanet Verme Sistemini Hazırlayacağım
    }
}
