
namespace UI_Library_Otomation.Forms
{
    partial class ServiceManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceManagementForm));
            this.lbl_searchbook = new System.Windows.Forms.Label();
            this.txt_searchbook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_searchstudent = new System.Windows.Forms.TextBox();
            this.gbx_selectedstudent = new System.Windows.Forms.GroupBox();
            this.lbl_studentphonenumber = new System.Windows.Forms.Label();
            this.lbl_studentsurname = new System.Windows.Forms.Label();
            this.lbl_studentname = new System.Windows.Forms.Label();
            this.txt_studentphonenumber = new System.Windows.Forms.TextBox();
            this.txt_studentsurname = new System.Windows.Forms.TextBox();
            this.txt_studentname = new System.Windows.Forms.TextBox();
            this.gbx_selectedbook = new System.Windows.Forms.GroupBox();
            this.lbl_bookpagecount = new System.Windows.Forms.Label();
            this.tbx_bookNo = new System.Windows.Forms.TextBox();
            this.lbl_bookauthor = new System.Windows.Forms.Label();
            this.tbx_bookname = new System.Windows.Forms.TextBox();
            this.lbl_bookname = new System.Windows.Forms.Label();
            this.tbx_author = new System.Windows.Forms.TextBox();
            this.btn_addservice = new System.Windows.Forms.Button();
            this.btn_deleteservice = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_bookShelfNo = new System.Windows.Forms.TextBox();
            this.gbx_selectedstudent.SuspendLayout();
            this.gbx_selectedbook.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_searchbook
            // 
            this.lbl_searchbook.AutoSize = true;
            this.lbl_searchbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_searchbook.Location = new System.Drawing.Point(249, 20);
            this.lbl_searchbook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_searchbook.Name = "lbl_searchbook";
            this.lbl_searchbook.Size = new System.Drawing.Size(121, 20);
            this.lbl_searchbook.TabIndex = 25;
            this.lbl_searchbook.Text = "Kitap Barkodu : ";
            // 
            // txt_searchbook
            // 
            this.txt_searchbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_searchbook.Location = new System.Drawing.Point(253, 44);
            this.txt_searchbook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_searchbook.Name = "txt_searchbook";
            this.txt_searchbook.Size = new System.Drawing.Size(215, 30);
            this.txt_searchbook.TabIndex = 24;
            this.txt_searchbook.TextChanged += new System.EventHandler(this.txt_searchbook_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Öğrenci Numarası : ";
            // 
            // txt_searchstudent
            // 
            this.txt_searchstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_searchstudent.Location = new System.Drawing.Point(16, 44);
            this.txt_searchstudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_searchstudent.Name = "txt_searchstudent";
            this.txt_searchstudent.Size = new System.Drawing.Size(215, 30);
            this.txt_searchstudent.TabIndex = 37;
            this.txt_searchstudent.TextChanged += new System.EventHandler(this.txt_searchstudent_TextChanged);
            // 
            // gbx_selectedstudent
            // 
            this.gbx_selectedstudent.Controls.Add(this.lbl_studentphonenumber);
            this.gbx_selectedstudent.Controls.Add(this.lbl_studentsurname);
            this.gbx_selectedstudent.Controls.Add(this.lbl_studentname);
            this.gbx_selectedstudent.Controls.Add(this.txt_studentphonenumber);
            this.gbx_selectedstudent.Controls.Add(this.txt_studentsurname);
            this.gbx_selectedstudent.Controls.Add(this.txt_studentname);
            this.gbx_selectedstudent.Location = new System.Drawing.Point(16, 102);
            this.gbx_selectedstudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_selectedstudent.Name = "gbx_selectedstudent";
            this.gbx_selectedstudent.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_selectedstudent.Size = new System.Drawing.Size(453, 194);
            this.gbx_selectedstudent.TabIndex = 39;
            this.gbx_selectedstudent.TabStop = false;
            this.gbx_selectedstudent.Text = "Seçilen Öğrenci";
            // 
            // lbl_studentphonenumber
            // 
            this.lbl_studentphonenumber.AutoSize = true;
            this.lbl_studentphonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_studentphonenumber.Location = new System.Drawing.Point(25, 126);
            this.lbl_studentphonenumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_studentphonenumber.Name = "lbl_studentphonenumber";
            this.lbl_studentphonenumber.Size = new System.Drawing.Size(145, 20);
            this.lbl_studentphonenumber.TabIndex = 45;
            this.lbl_studentphonenumber.Text = "Telefon Numarası : ";
            // 
            // lbl_studentsurname
            // 
            this.lbl_studentsurname.AutoSize = true;
            this.lbl_studentsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_studentsurname.Location = new System.Drawing.Point(37, 86);
            this.lbl_studentsurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_studentsurname.Name = "lbl_studentsurname";
            this.lbl_studentsurname.Size = new System.Drawing.Size(134, 20);
            this.lbl_studentsurname.TabIndex = 44;
            this.lbl_studentsurname.Text = "Öğrenci Soyismi : ";
            // 
            // lbl_studentname
            // 
            this.lbl_studentname.AutoSize = true;
            this.lbl_studentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_studentname.Location = new System.Drawing.Point(69, 47);
            this.lbl_studentname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_studentname.Name = "lbl_studentname";
            this.lbl_studentname.Size = new System.Drawing.Size(109, 20);
            this.lbl_studentname.TabIndex = 41;
            this.lbl_studentname.Text = "Öğrenci İsmi : ";
            // 
            // txt_studentphonenumber
            // 
            this.txt_studentphonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_studentphonenumber.Location = new System.Drawing.Point(208, 118);
            this.txt_studentphonenumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_studentphonenumber.Name = "txt_studentphonenumber";
            this.txt_studentphonenumber.ReadOnly = true;
            this.txt_studentphonenumber.Size = new System.Drawing.Size(215, 30);
            this.txt_studentphonenumber.TabIndex = 43;
            // 
            // txt_studentsurname
            // 
            this.txt_studentsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_studentsurname.Location = new System.Drawing.Point(208, 79);
            this.txt_studentsurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_studentsurname.Name = "txt_studentsurname";
            this.txt_studentsurname.ReadOnly = true;
            this.txt_studentsurname.Size = new System.Drawing.Size(215, 30);
            this.txt_studentsurname.TabIndex = 42;
            // 
            // txt_studentname
            // 
            this.txt_studentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_studentname.Location = new System.Drawing.Point(208, 39);
            this.txt_studentname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_studentname.Name = "txt_studentname";
            this.txt_studentname.ReadOnly = true;
            this.txt_studentname.Size = new System.Drawing.Size(215, 30);
            this.txt_studentname.TabIndex = 41;
            // 
            // gbx_selectedbook
            // 
            this.gbx_selectedbook.Controls.Add(this.label2);
            this.gbx_selectedbook.Controls.Add(this.tbx_bookShelfNo);
            this.gbx_selectedbook.Controls.Add(this.lbl_bookpagecount);
            this.gbx_selectedbook.Controls.Add(this.tbx_bookNo);
            this.gbx_selectedbook.Controls.Add(this.lbl_bookauthor);
            this.gbx_selectedbook.Controls.Add(this.tbx_bookname);
            this.gbx_selectedbook.Controls.Add(this.lbl_bookname);
            this.gbx_selectedbook.Controls.Add(this.tbx_author);
            this.gbx_selectedbook.Location = new System.Drawing.Point(492, 102);
            this.gbx_selectedbook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_selectedbook.Name = "gbx_selectedbook";
            this.gbx_selectedbook.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_selectedbook.Size = new System.Drawing.Size(453, 220);
            this.gbx_selectedbook.TabIndex = 40;
            this.gbx_selectedbook.TabStop = false;
            this.gbx_selectedbook.Text = "Seçilen Kitap";
            // 
            // lbl_bookpagecount
            // 
            this.lbl_bookpagecount.AutoSize = true;
            this.lbl_bookpagecount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bookpagecount.Location = new System.Drawing.Point(68, 126);
            this.lbl_bookpagecount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bookpagecount.Name = "lbl_bookpagecount";
            this.lbl_bookpagecount.Size = new System.Drawing.Size(128, 20);
            this.lbl_bookpagecount.TabIndex = 51;
            this.lbl_bookpagecount.Text = "Kitap Numarası : ";
            // 
            // tbx_bookNo
            // 
            this.tbx_bookNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_bookNo.Location = new System.Drawing.Point(207, 118);
            this.tbx_bookNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_bookNo.Name = "tbx_bookNo";
            this.tbx_bookNo.ReadOnly = true;
            this.tbx_bookNo.Size = new System.Drawing.Size(215, 30);
            this.tbx_bookNo.TabIndex = 49;
            // 
            // lbl_bookauthor
            // 
            this.lbl_bookauthor.AutoSize = true;
            this.lbl_bookauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bookauthor.Location = new System.Drawing.Point(121, 86);
            this.lbl_bookauthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bookauthor.Name = "lbl_bookauthor";
            this.lbl_bookauthor.Size = new System.Drawing.Size(63, 20);
            this.lbl_bookauthor.TabIndex = 50;
            this.lbl_bookauthor.Text = "Yazar : ";
            // 
            // tbx_bookname
            // 
            this.tbx_bookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_bookname.Location = new System.Drawing.Point(207, 39);
            this.tbx_bookname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_bookname.Name = "tbx_bookname";
            this.tbx_bookname.ReadOnly = true;
            this.tbx_bookname.Size = new System.Drawing.Size(215, 30);
            this.tbx_bookname.TabIndex = 47;
            // 
            // lbl_bookname
            // 
            this.lbl_bookname.AutoSize = true;
            this.lbl_bookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bookname.Location = new System.Drawing.Point(92, 47);
            this.lbl_bookname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bookname.Name = "lbl_bookname";
            this.lbl_bookname.Size = new System.Drawing.Size(90, 20);
            this.lbl_bookname.TabIndex = 46;
            this.lbl_bookname.Text = "Kitap İsmi : ";
            // 
            // tbx_author
            // 
            this.tbx_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_author.Location = new System.Drawing.Point(207, 79);
            this.tbx_author.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_author.Name = "tbx_author";
            this.tbx_author.ReadOnly = true;
            this.tbx_author.Size = new System.Drawing.Size(215, 30);
            this.tbx_author.TabIndex = 48;
            // 
            // btn_addservice
            // 
            this.btn_addservice.Location = new System.Drawing.Point(243, 337);
            this.btn_addservice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addservice.Name = "btn_addservice";
            this.btn_addservice.Size = new System.Drawing.Size(216, 58);
            this.btn_addservice.TabIndex = 41;
            this.btn_addservice.Text = "Emanet Ver";
            this.btn_addservice.UseVisualStyleBackColor = true;
            this.btn_addservice.Click += new System.EventHandler(this.btn_addservice_Click_1);
            // 
            // btn_deleteservice
            // 
            this.btn_deleteservice.Location = new System.Drawing.Point(492, 337);
            this.btn_deleteservice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_deleteservice.Name = "btn_deleteservice";
            this.btn_deleteservice.Size = new System.Drawing.Size(216, 58);
            this.btn_deleteservice.TabIndex = 42;
            this.btn_deleteservice.Text = "Emaneti Al";
            this.btn_deleteservice.UseVisualStyleBackColor = true;
            this.btn_deleteservice.Click += new System.EventHandler(this.btn_deleteservice_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(879, 20);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(67, 62);
            this.btn_exit.TabIndex = 43;
            this.btn_exit.Text = "Çıkış";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Raf Numarası : ";
            // 
            // tbx_bookShelfNo
            // 
            this.tbx_bookShelfNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_bookShelfNo.Location = new System.Drawing.Point(207, 164);
            this.tbx_bookShelfNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_bookShelfNo.Name = "tbx_bookShelfNo";
            this.tbx_bookShelfNo.ReadOnly = true;
            this.tbx_bookShelfNo.Size = new System.Drawing.Size(215, 30);
            this.tbx_bookShelfNo.TabIndex = 52;
            // 
            // ServiceManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(959, 422);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_deleteservice);
            this.Controls.Add(this.btn_addservice);
            this.Controls.Add(this.gbx_selectedbook);
            this.Controls.Add(this.gbx_selectedstudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_searchstudent);
            this.Controls.Add(this.lbl_searchbook);
            this.Controls.Add(this.txt_searchbook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ServiceManagementForm";
            this.Text = "MTT Kütüphane Otomasyonu Emanet Yönetim Paneli";
            this.Load += new System.EventHandler(this.ServiceManagementForm_Load);
            this.gbx_selectedstudent.ResumeLayout(false);
            this.gbx_selectedstudent.PerformLayout();
            this.gbx_selectedbook.ResumeLayout(false);
            this.gbx_selectedbook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_searchbook;
        private System.Windows.Forms.TextBox txt_searchbook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_searchstudent;
        private System.Windows.Forms.GroupBox gbx_selectedstudent;
        private System.Windows.Forms.Label lbl_studentphonenumber;
        private System.Windows.Forms.Label lbl_studentsurname;
        private System.Windows.Forms.Label lbl_studentname;
        private System.Windows.Forms.TextBox txt_studentphonenumber;
        private System.Windows.Forms.TextBox txt_studentsurname;
        private System.Windows.Forms.TextBox txt_studentname;
        private System.Windows.Forms.GroupBox gbx_selectedbook;
        private System.Windows.Forms.Label lbl_bookpagecount;
        private System.Windows.Forms.TextBox tbx_bookNo;
        private System.Windows.Forms.Label lbl_bookauthor;
        private System.Windows.Forms.TextBox tbx_bookname;
        private System.Windows.Forms.Label lbl_bookname;
        private System.Windows.Forms.TextBox tbx_author;
        private System.Windows.Forms.Button btn_addservice;
        private System.Windows.Forms.Button btn_deleteservice;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_bookShelfNo;
    }
}