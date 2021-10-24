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

namespace UI_Library_Otomation.Forms
{
    public partial class ServiceListForm : Form
    {
        public ServiceListForm()
        {
            InitializeComponent();
        }

        private void ServiceListForm_Load(object sender, EventArgs e)
        {
            ListServices();
        }

        ServiceManager serviceManager = new ServiceManager();
        private void ListServices()
        {
            dgw_services.DataSource = serviceManager.GetServices();
            Console.WriteLine("Emanetler listelendi");
        }

        private void tbx_searchbookbarcode_TextChanged(object sender, EventArgs e)
        {
            dgw_services.DataSource = serviceManager.GetServicesByBarcode(tbx_searchbookbarcode.Text);
        }

        private void txt_searchstudent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgw_services.DataSource = serviceManager.GetServicesBySchoolNo(Convert.ToInt16(txt_searchstudent.Text));

            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
