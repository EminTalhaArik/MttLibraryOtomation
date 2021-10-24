using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library_Otomation.Entity
{
    public class Admin
    {
        private int admin_id;
        private string admin_name;
        private string admin_surname;
        private string admin_username;
        private string admin_password;

        public Admin(string admin_name, string admin_surname, string admin_username, string admin_password)
        {
            this.Admin_name = admin_name;
            this.Admin_surname = admin_surname;
            this.Admin_username = admin_username;
            this.Admin_password = admin_password;
        }

        public Admin()
        {

        }

        public int Admin_id { get => admin_id; set => admin_id = value; }
        public string Admin_name { get => admin_name; set => admin_name = value; }
        public string Admin_surname { get => admin_surname; set => admin_surname = value; }
        public string Admin_username { get => admin_username; set => admin_username = value; }
        public string Admin_password { get => admin_password; set => admin_password = value; }
    }
}
