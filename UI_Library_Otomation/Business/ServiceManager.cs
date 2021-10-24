using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Library_Otomation.Databases;
using UI_Library_Otomation.Entity;

namespace UI_Library_Otomation.Business
{
    public class ServiceManager
    {
        StudentDal studentDal = new StudentDal();
        BookDal bookDal = new BookDal();
        ServiceDal serviceDal = new ServiceDal();

        public void AddService(Student student, Book book)
        {
            studentDal.SetConnection();
            bookDal.SetConnection();
            serviceDal.SetConnection();

            bool isCreatable = true;
            foreach (var gettingService in serviceDal.GetAll())
            {
                if (gettingService.School_no == student.School_no && gettingService.Book_barcode == book.Book_barcode)
                {
                    isCreatable = false;
                }
            }

            if (isCreatable)
            {
                serviceDal.Create(student, book, DateTime.Now);
                Console.WriteLine("Emanet Başarı İle Eklendi");
                MessageBox.Show("Emanet Başarı İle Eklendi!", "Uyarı");
            }
            else
            {
                Console.WriteLine("Aynı kayıt birden fazla olamaz");
                MessageBox.Show("Aynı kayıt birden fazla olamaz!", "Uyarı");

            }
        }

        public List<Service> GetServices()
        {
            serviceDal.SetConnection();
            return serviceDal.GetAll();
        }

        public List<Service> GetServicesBySchoolNo(short school_no)
        {
            serviceDal.SetConnection();
            return serviceDal.GetAllBySchoolNo(school_no);
        }

        public List<Service> GetServicesByBookName(string book_name)
        {
            serviceDal.SetConnection();
            return serviceDal.GetAllByBarcode(book_name);
        }


        public List<Service> GetServicesByBarcode(string barcode)
        {
            serviceDal.SetConnection();
            return serviceDal.GetAllByBarcode(barcode);
        }

        public void DeleteService(string book_barcode)
        {
            serviceDal.SetConnection();
            serviceDal.DeleteByBookBarcode(book_barcode);
        }
    }
}
