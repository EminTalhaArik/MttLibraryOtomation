
namespace UI_Library_Otomation.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pcbMttLogo = new System.Windows.Forms.PictureBox();
            this.btn_studentmanagement = new System.Windows.Forms.Button();
            this.btn_addbook = new System.Windows.Forms.Button();
            this.btn_service = new System.Windows.Forms.Button();
            this.btn_servicelist = new System.Windows.Forms.Button();
            this.btn_booklist = new System.Windows.Forms.Button();
            this.btn_studentlist = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_reklam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMttLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbMttLogo
            // 
            this.pcbMttLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbMttLogo.Image")));
            this.pcbMttLogo.Location = new System.Drawing.Point(7, 62);
            this.pcbMttLogo.Name = "pcbMttLogo";
            this.pcbMttLogo.Size = new System.Drawing.Size(250, 250);
            this.pcbMttLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMttLogo.TabIndex = 0;
            this.pcbMttLogo.TabStop = false;
            // 
            // btn_studentmanagement
            // 
            this.btn_studentmanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_studentmanagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_studentmanagement.Location = new System.Drawing.Point(272, 212);
            this.btn_studentmanagement.Name = "btn_studentmanagement";
            this.btn_studentmanagement.Size = new System.Drawing.Size(200, 45);
            this.btn_studentmanagement.TabIndex = 1;
            this.btn_studentmanagement.Text = "Öğrenci Ekle";
            this.btn_studentmanagement.UseVisualStyleBackColor = true;
            this.btn_studentmanagement.Click += new System.EventHandler(this.btn_studentmanagement_Click);
            // 
            // btn_addbook
            // 
            this.btn_addbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addbook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addbook.Location = new System.Drawing.Point(272, 263);
            this.btn_addbook.Name = "btn_addbook";
            this.btn_addbook.Size = new System.Drawing.Size(200, 45);
            this.btn_addbook.TabIndex = 3;
            this.btn_addbook.Text = "Kitap Ekle";
            this.btn_addbook.UseVisualStyleBackColor = true;
            this.btn_addbook.Click += new System.EventHandler(this.btn_addbook_Click);
            // 
            // btn_service
            // 
            this.btn_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_service.Location = new System.Drawing.Point(272, 110);
            this.btn_service.Name = "btn_service";
            this.btn_service.Size = new System.Drawing.Size(200, 45);
            this.btn_service.TabIndex = 4;
            this.btn_service.Text = "Emanet Al - Ver";
            this.btn_service.UseVisualStyleBackColor = true;
            this.btn_service.Click += new System.EventHandler(this.btn_service_Click);
            // 
            // btn_servicelist
            // 
            this.btn_servicelist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_servicelist.Location = new System.Drawing.Point(272, 161);
            this.btn_servicelist.Name = "btn_servicelist";
            this.btn_servicelist.Size = new System.Drawing.Size(200, 45);
            this.btn_servicelist.TabIndex = 5;
            this.btn_servicelist.Text = "Emanet Verilen Kitaplar";
            this.btn_servicelist.UseVisualStyleBackColor = true;
            this.btn_servicelist.Click += new System.EventHandler(this.btn_servicelist_Click);
            // 
            // btn_booklist
            // 
            this.btn_booklist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_booklist.Location = new System.Drawing.Point(272, 8);
            this.btn_booklist.Name = "btn_booklist";
            this.btn_booklist.Size = new System.Drawing.Size(200, 45);
            this.btn_booklist.TabIndex = 6;
            this.btn_booklist.Text = "Kitapları Listele";
            this.btn_booklist.UseVisualStyleBackColor = true;
            this.btn_booklist.Click += new System.EventHandler(this.btn_booklist_Click);
            // 
            // btn_studentlist
            // 
            this.btn_studentlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_studentlist.Location = new System.Drawing.Point(272, 59);
            this.btn_studentlist.Name = "btn_studentlist";
            this.btn_studentlist.Size = new System.Drawing.Size(200, 45);
            this.btn_studentlist.TabIndex = 7;
            this.btn_studentlist.Text = "Öğrencileri Listele";
            this.btn_studentlist.UseVisualStyleBackColor = true;
            this.btn_studentlist.Click += new System.EventHandler(this.btn_studentlist_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.Location = new System.Drawing.Point(272, 314);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(200, 45);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Çıkış Yap";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_reklam
            // 
            this.lbl_reklam.AutoSize = true;
            this.lbl_reklam.Location = new System.Drawing.Point(4, 350);
            this.lbl_reklam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reklam.Name = "lbl_reklam";
            this.lbl_reklam.Size = new System.Drawing.Size(184, 13);
            this.lbl_reklam.TabIndex = 9;
            this.lbl_reklam.Text = "Emin Talha Arık Tarafından Geliştirildi!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 336);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "www.linktr.ee/talhemin";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(476, 371);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_reklam);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_studentlist);
            this.Controls.Add(this.btn_booklist);
            this.Controls.Add(this.btn_servicelist);
            this.Controls.Add(this.btn_service);
            this.Controls.Add(this.btn_addbook);
            this.Controls.Add(this.btn_studentmanagement);
            this.Controls.Add(this.pcbMttLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MTT Kütüphane Otomasyonu Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pcbMttLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMttLogo;
        private System.Windows.Forms.Button btn_studentmanagement;
        private System.Windows.Forms.Button btn_addbook;
        private System.Windows.Forms.Button btn_service;
        private System.Windows.Forms.Button btn_servicelist;
        private System.Windows.Forms.Button btn_booklist;
        private System.Windows.Forms.Button btn_studentlist;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_reklam;
        private System.Windows.Forms.Label label1;
    }
}