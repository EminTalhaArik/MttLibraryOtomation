using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Library_Otomation.Entity
{
    public class Service
    {
        private int service_id;
        private short school_no;
        private string book_barcode;
        private DateTime purchase_date;

        public Service(int service_id, short school_no, string book_barcode, DateTime purchase_date)
        {
            this.Service_id = service_id;
            this.School_no = school_no;
            this.Book_barcode = book_barcode;
            this.Purchase_date = purchase_date;
        }

        public Service()
        {

        }

        public int Service_id { get => service_id; set => service_id = value; }
        public short School_no { get => school_no; set => school_no = value; }
        public string Book_barcode { get => book_barcode; set => book_barcode = value; }
        public DateTime Purchase_date { get => purchase_date; set => purchase_date = value; }


    }
}
