
namespace UI_Library_Otomation.Forms
{
    partial class StudentListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentListForm));
            this.dgw_students = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.tbx_studentname = new System.Windows.Forms.TextBox();
            this.gbx_selectedStudent = new System.Windows.Forms.GroupBox();
            this.lbl_studentsurname = new System.Windows.Forms.Label();
            this.tbx_studentsurname = new System.Windows.Forms.TextBox();
            this.lbl_studentphonenumber = new System.Windows.Forms.Label();
            this.tbx_studentphonenumber = new System.Windows.Forms.TextBox();
            this.lbl_schoolno = new System.Windows.Forms.Label();
            this.tbx_schoolno = new System.Windows.Forms.TextBox();
            this.lbl_studentname = new System.Windows.Forms.Label();
            this.lbl_searchstudentschoolno = new System.Windows.Forms.Label();
            this.tbx_searchstudentschoolno = new System.Windows.Forms.TextBox();
            this.btn_searchstudentschoolno = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_students)).BeginInit();
            this.gbx_selectedStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_students
            // 
            this.dgw_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_students.Location = new System.Drawing.Point(331, 6);
            this.dgw_students.Name = "dgw_students";
            this.dgw_students.Size = new System.Drawing.Size(446, 432);
            this.dgw_students.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(82, 365);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 45);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Öğrenciyi Sil";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(82, 314);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(150, 45);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Öğrenciyi Güncelle";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // tbx_studentname
            // 
            this.tbx_studentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_studentname.Location = new System.Drawing.Point(141, 19);
            this.tbx_studentname.Name = "tbx_studentname";
            this.tbx_studentname.Size = new System.Drawing.Size(166, 23);
            this.tbx_studentname.TabIndex = 3;
            // 
            // gbx_selectedStudent
            // 
            this.gbx_selectedStudent.Controls.Add(this.lbl_studentsurname);
            this.gbx_selectedStudent.Controls.Add(this.tbx_studentsurname);
            this.gbx_selectedStudent.Controls.Add(this.lbl_studentphonenumber);
            this.gbx_selectedStudent.Controls.Add(this.tbx_studentphonenumber);
            this.gbx_selectedStudent.Controls.Add(this.lbl_schoolno);
            this.gbx_selectedStudent.Controls.Add(this.tbx_schoolno);
            this.gbx_selectedStudent.Controls.Add(this.lbl_studentname);
            this.gbx_selectedStudent.Controls.Add(this.tbx_studentname);
            this.gbx_selectedStudent.Location = new System.Drawing.Point(12, 168);
            this.gbx_selectedStudent.Name = "gbx_selectedStudent";
            this.gbx_selectedStudent.Size = new System.Drawing.Size(313, 140);
            this.gbx_selectedStudent.TabIndex = 4;
            this.gbx_selectedStudent.TabStop = false;
            this.gbx_selectedStudent.Text = "Seçilen Öğrenci";
            // 
            // lbl_studentsurname
            // 
            this.lbl_studentsurname.AutoSize = true;
            this.lbl_studentsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_studentsurname.Location = new System.Drawing.Point(67, 51);
            this.lbl_studentsurname.Name = "lbl_studentsurname";
            this.lbl_studentsurname.Size = new System.Drawing.Size(68, 17);
            this.lbl_studentsurname.TabIndex = 12;
            this.lbl_studentsurname.Text = "Soyisim : ";
            // 
            // tbx_studentsurname
            // 
            this.tbx_studentsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_studentsurname.Location = new System.Drawing.Point(141, 48);
            this.tbx_studentsurname.Name = "tbx_studentsurname";
            this.tbx_studentsurname.Size = new System.Drawing.Size(166, 23);
            this.tbx_studentsurname.TabIndex = 11;
            // 
            // lbl_studentphonenumber
            // 
            this.lbl_studentphonenumber.AutoSize = true;
            this.lbl_studentphonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_studentphonenumber.Location = new System.Drawing.Point(4, 109);
            this.lbl_studentphonenumber.Name = "lbl_studentphonenumber";
            this.lbl_studentphonenumber.Size = new System.Drawing.Size(132, 17);
            this.lbl_studentphonenumber.TabIndex = 8;
            this.lbl_studentphonenumber.Text = "Telefon Numarası : ";
            // 
            // tbx_studentphonenumber
            // 
            this.tbx_studentphonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_studentphonenumber.Location = new System.Drawing.Point(141, 106);
            this.tbx_studentphonenumber.Name = "tbx_studentphonenumber";
            this.tbx_studentphonenumber.Size = new System.Drawing.Size(166, 23);
            this.tbx_studentphonenumber.TabIndex = 7;
            // 
            // lbl_schoolno
            // 
            this.lbl_schoolno.AutoSize = true;
            this.lbl_schoolno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_schoolno.Location = new System.Drawing.Point(22, 80);
            this.lbl_schoolno.Name = "lbl_schoolno";
            this.lbl_schoolno.Size = new System.Drawing.Size(113, 17);
            this.lbl_schoolno.TabIndex = 6;
            this.lbl_schoolno.Text = "Okul Numarası : ";
            // 
            // tbx_schoolno
            // 
            this.tbx_schoolno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_schoolno.Location = new System.Drawing.Point(141, 77);
            this.tbx_schoolno.Name = "tbx_schoolno";
            this.tbx_schoolno.Size = new System.Drawing.Size(166, 23);
            this.tbx_schoolno.TabIndex = 5;
            // 
            // lbl_studentname
            // 
            this.lbl_studentname.AutoSize = true;
            this.lbl_studentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_studentname.Location = new System.Drawing.Point(91, 22);
            this.lbl_studentname.Name = "lbl_studentname";
            this.lbl_studentname.Size = new System.Drawing.Size(44, 17);
            this.lbl_studentname.TabIndex = 4;
            this.lbl_studentname.Text = "İsim : ";
            // 
            // lbl_searchstudentschoolno
            // 
            this.lbl_searchstudentschoolno.AutoSize = true;
            this.lbl_searchstudentschoolno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_searchstudentschoolno.Location = new System.Drawing.Point(34, 79);
            this.lbl_searchstudentschoolno.Name = "lbl_searchstudentschoolno";
            this.lbl_searchstudentschoolno.Size = new System.Drawing.Size(113, 17);
            this.lbl_searchstudentschoolno.TabIndex = 14;
            this.lbl_searchstudentschoolno.Text = "Okul Numarası : ";
            // 
            // tbx_searchstudentschoolno
            // 
            this.tbx_searchstudentschoolno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_searchstudentschoolno.Location = new System.Drawing.Point(153, 76);
            this.tbx_searchstudentschoolno.Name = "tbx_searchstudentschoolno";
            this.tbx_searchstudentschoolno.Size = new System.Drawing.Size(166, 23);
            this.tbx_searchstudentschoolno.TabIndex = 13;
            this.tbx_searchstudentschoolno.TextChanged += new System.EventHandler(this.tbx_searchstudentschoolno_TextChanged);
            // 
            // btn_searchstudentschoolno
            // 
            this.btn_searchstudentschoolno.Location = new System.Drawing.Point(82, 105);
            this.btn_searchstudentschoolno.Name = "btn_searchstudentschoolno";
            this.btn_searchstudentschoolno.Size = new System.Drawing.Size(166, 37);
            this.btn_searchstudentschoolno.TabIndex = 15;
            this.btn_searchstudentschoolno.Text = "Ara";
            this.btn_searchstudentschoolno.UseVisualStyleBackColor = true;
            this.btn_searchstudentschoolno.Click += new System.EventHandler(this.btn_searchstudentschoolno_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(12, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(59, 44);
            this.btn_exit.TabIndex = 16;
            this.btn_exit.Text = "Çıkış";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(781, 445);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_searchstudentschoolno);
            this.Controls.Add(this.lbl_searchstudentschoolno);
            this.Controls.Add(this.gbx_selectedStudent);
            this.Controls.Add(this.tbx_searchstudentschoolno);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgw_students);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentListForm";
            this.Text = "MTT Kütüphane Otomasyonu Öğrenci Listeleme Paneli";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_students)).EndInit();
            this.gbx_selectedStudent.ResumeLayout(false);
            this.gbx_selectedStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_students;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox tbx_studentname;
        private System.Windows.Forms.GroupBox gbx_selectedStudent;
        private System.Windows.Forms.Label lbl_studentsurname;
        private System.Windows.Forms.TextBox tbx_studentsurname;
        private System.Windows.Forms.Label lbl_studentphonenumber;
        private System.Windows.Forms.TextBox tbx_studentphonenumber;
        private System.Windows.Forms.Label lbl_schoolno;
        private System.Windows.Forms.TextBox tbx_schoolno;
        private System.Windows.Forms.Label lbl_studentname;
        private System.Windows.Forms.Label lbl_searchstudentschoolno;
        private System.Windows.Forms.TextBox tbx_searchstudentschoolno;
        private System.Windows.Forms.Button btn_searchstudentschoolno;
        private System.Windows.Forms.Button btn_exit;
    }
}