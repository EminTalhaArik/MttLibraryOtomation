using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library_Otomation.Entity
{
    public class Worker
    {
        private int worker_id;
        private string worker_name;
        private string worker_surname;
        private string worker_username;
        private string worker_password;

        public Worker(int worker_id, string worker_name, string worker_surname, string worker_username, string worker_password)
        {
            this.worker_id = worker_id;
            this.worker_name = worker_name;
            this.worker_surname = worker_surname;
            this.worker_username = worker_username;
            this.worker_password = worker_password;
        }

        public Worker() { }

        public int Worker_id { get => worker_id; set => worker_id = value; }
        public string Worker_name { get => worker_name; set => worker_name = value; }
        public string Worker_surname { get => worker_surname; set => worker_surname = value; }
        public string Worker_username { get => worker_username; set => worker_username = value; }
        public string Worker_password { get => worker_password; set => worker_password = value; }
    }
}
