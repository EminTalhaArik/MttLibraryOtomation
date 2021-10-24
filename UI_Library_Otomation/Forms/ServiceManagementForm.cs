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
using UI_Library_Otomation.Databases;
using UI_Library_Otomation.Entity;

namespace UI_Library_Otomation.Forms
{
    public partial class ServiceManagementForm : Form
    {
        ProcessManager processManager = new ProcessManager();
        public ServiceManagementForm()
        {
            InitializeComponent();

        }

        private void btn_studentmanagement_Click(object sender, EventArgs e)
        {
            processManager.StudentManagementFormButton();
            this.Hide();
        }

        private void btn_bookmanagement_Click(object sender, EventArgs e)
        {
            processManager.BookManagementFormButton();
            this.Hide();
        }

        private void btn_addbook_Click(object sender, EventArgs e)
        {
            processManager.AddBookFormButton();
            this.Hide();
        }

        private void btn_service_Click(object sender, EventArgs e)
        {
            processManager.ServiceManagementFormButton();
            this.Hide();
        }
        public Student selectedStudent;
        public Book selectedBook;

        ServiceManager serviceManager = new ServiceManager();

        StudentManager studentManager = new StudentManager();
        BookManager bookManager = new BookManager();

        private void ResetSelection()
        {
            selectedBook = null;
            selectedStudent = null;
        }

        private void txt_searchstudent_TextChanged(object sender, EventArgs e)
        {
            try
            {
                selectedStudent = studentManager.GetStudent(Convert.ToInt16(txt_searchstudent.Text));

                FillSelectedStudentArea();
            }
            catch { }
        }

        private void FillSelectedStudentArea()
        {
            txt_studentname.Text = selectedStudent.Student_name;
            txt_studentsurname.Text = selectedStudent.Student_surname;
            txt_studentphonenumber.Text = selectedStudent.Studeny_phone_number;
        }

        private void FillSelectedBookArea()
        {
            tbx_bookname.Text = selectedBook.Book_name;
            tbx_author.Text = selectedBook.Book_author;
            tbx_bookNo.Text = selectedBook.Book_no.ToString();
            tbx_bookShelfNo.Text = selectedBook.Book_shelf_no.ToString();
        }

        private void txt_searchbook_TextChanged(object sender, EventArgs e)
        {
            try
            {
                selectedBook = bookManager.GetBook(txt_searchbook.Text);

                FillSelectedBookArea();
            }
            catch { }
        }


        private void btn_addservice_Click_1(object sender, EventArgs e)
        {
            if (selectedStudent != null && selectedBook != null)
            {

                serviceManager.AddService(selectedStudent, selectedBook);
                ResetSelection();

            }
            else
            {
                Console.WriteLine("Lütfen Tüm Seçimlerinizi Gerçekleştirin");
                MessageBox.Show("Lütfen Tüm Seçimlerinizi Gerçekleştirin!", "Uyarı");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_deleteservice_Click(object sender, EventArgs e)
        {
            if (selectedStudent != null && selectedBook != null)
            {
                serviceManager.DeleteService(selectedBook.Book_barcode);

            }
        }

        private void ServiceManagementForm_Load(object sender, EventArgs e)
        {

        }

        //private void FilterBooksService(string barcode)
        //{
        //    try
        //    {
        //        List<Service> services = serviceManager.GetServicesByBarcode(barcode);
        //        List<FullyService> newService = new List<FullyService>();
        //        foreach (var item in services)
        //        {
        //            FullyService newAddingService = new FullyService();

        //            newAddingService.studentNo = item.School_no;
        //            newAddingService.studentName = studentManager.GetStudent(item.School_no).Student_name;
        //            newAddingService.studentSurname = studentManager.GetStudent(item.School_no).Student_surname;
        //            newAddingService.bookBarcode = item.Book_barcode;
        //            newAddingService.bookName = bookManager.GetBook(item.Book_barcode).Book_name;
        //            newAddingService.purchaseDate = item.Purchase_date;

        //            newService.Add(newAddingService);
        //        }

        //        dgw_services.DataSource = newService;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Sistem Bir Hata İle Karşılaştı : {0}", e);
        //    }
        //}

        //private void FilterStudentService(string school_no)
        //{
        //    try
        //    {
        //        List<Service> services = serviceManager.GetServicesBySchoolNo(Convert.ToInt16(school_no));
        //        List<FullyService> newService = new List<FullyService>();
        //        foreach (var item in services)
        //        {
        //            FullyService newAddingService = new FullyService();

        //            newAddingService.studentNo = item.School_no;
        //            newAddingService.studentName = studentManager.GetStudent(item.School_no).Student_name;
        //            newAddingService.studentSurname = studentManager.GetStudent(item.School_no).Student_surname;
        //            newAddingService.bookBarcode = item.Book_barcode;
        //            newAddingService.bookName = bookManager.GetBook(item.Book_barcode).Book_name;
        //            newAddingService.purchaseDate = item.Purchase_date;

        //            newService.Add(newAddingService);
        //        }

        //        dgw_services.DataSource = newService;
        //        Console.WriteLine(newService.Count);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Sistem Bir Hata İle Karşılaştı : {0}", e);
        //    }
        //}

    }
}
