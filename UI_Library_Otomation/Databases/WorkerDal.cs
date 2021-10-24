using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Library_Otomation.Entity;

namespace UI_Library_Otomation.Databases
{
    public class WorkerDal
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

        public List<Worker> GetAll()
        {
            List<Worker> workers = new List<Worker>();

            Connection.Open();

            var sql = "SELECT * FROM worker";
            var cmd = new MySqlCommand(sql, Connection);

            long count = Convert.ToInt64(cmd.ExecuteScalar());

            if (count != 0)
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Worker currentWorker = new Worker();
                    currentWorker.Worker_id = Convert.ToInt32(reader["worker_id"]);
                    currentWorker.Worker_name = Convert.ToString(reader["worker_name"]);
                    currentWorker.Worker_surname = Convert.ToString(reader["worker_surname"]);
                    currentWorker.Worker_username = Convert.ToString(reader["worker_username"]);
                    currentWorker.Worker_password = Convert.ToString(reader["worker_password"]);

                    workers.Add(currentWorker);
                }
            }
            Connection.Close();

            return workers;
        }

    }
}
