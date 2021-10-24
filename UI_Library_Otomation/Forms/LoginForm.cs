using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Library_Otomation.Databases;
using UI_Library_Otomation.Entity;
using UI_Library_Otomation.Forms;

namespace UI_Library_Otomation
{
    public partial class LoginForm : Form
    {
        AdminDal adminDal = new AdminDal();
        WorkerDal workerDal = new WorkerDal();

        public LoginForm()
        {
            InitializeComponent();
            adminDal.SetConnection();
            workerDal.SetConnection();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (ControlPasswordText() && ControlUserNameText())
            {
                Login();
            }
            else
            {
                Console.WriteLine("Lütfen Tüm Bölgeleri Doldurunuz!");
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private bool ControlPasswordText()
        {
            return txt_password.Text != null && txt_password.Text != "";
        }

        private bool ControlUserNameText()
        {
            return txt_username.Text != null && txt_username.Text != "";
        }

        private void Login()
        {
            List<Admin> admins = adminDal.GetAll();
            foreach (var admin in admins)
            {
                if (admin.Admin_username.ToString() == txt_username.Text.ToString() &&
                    admin.Admin_password.ToString() == txt_password.Text.ToString())
                {
                    MainForm mainForm = new MainForm("Yönetici");
                    mainForm.Show();
                    this.Hide();
                }
            }

            List<Worker> workers = workerDal.GetAll();

            foreach (var worker in workers)
            {

                if (worker.Worker_username.ToString() == txt_username.Text.ToString() &&
                    worker.Worker_password.ToString() == txt_password.Text.ToString()
                    )
                {
                    MainForm mainForm = new MainForm("Görevli");
                    mainForm.Show();
                    this.Hide();
                }
            }
        }
    }
}
