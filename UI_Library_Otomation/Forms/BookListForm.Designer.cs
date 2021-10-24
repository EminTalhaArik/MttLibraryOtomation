
namespace UI_Library_Otomation.Forms
{
    partial class BookListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookListForm));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_searchbookbarcode = new System.Windows.Forms.Button();
            this.lbl_searchbookbarcode = new System.Windows.Forms.Label();
            this.gbx_selectedbook = new System.Windows.Forms.GroupBox();
            this.lbl_bookauthor = new System.Windows.Forms.Label();
            this.tbx_bookauthor = new System.Windows.Forms.TextBox();
            this.lbl_bookpagecount = new System.Windows.Forms.Label();
            this.tbx_bookno = new System.Windows.Forms.TextBox();
            this.lbl_bookname = new System.Windows.Forms.Label();
            this.tbx_bookname = new System.Windows.Forms.TextBox();
            this.txt_searchbookbarcode = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgw_books = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_bookShelfNo = new System.Windows.Forms.TextBox();
            this.gbx_selectedbook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_books)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(13, 15);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(67, 62);
            this.btn_exit.TabIndex = 24;
            this.btn_exit.Text = "Çıkış";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_searchbookbarcode
            // 
            this.btn_searchbookbarcode.Location = new System.Drawing.Point(107, 149);
            this.btn_searchbookbarcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_searchbookbarcode.Name = "btn_searchbookbarcode";
            this.btn_searchbookbarcode.Size = new System.Drawing.Size(221, 46);
            this.btn_searchbookbarcode.TabIndex = 23;
            this.btn_searchbookbarcode.Text = "Ara";
            this.btn_searchbookbarcode.UseVisualStyleBackColor = true;
            this.btn_searchbookbarcode.Click += new System.EventHandler(this.btn_searchbookbarcode_Click);
            // 
            // lbl_searchbookbarcode
            // 
            this.lbl_searchbookbarcode.AutoSize = true;
            this.lbl_searchbookbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_searchbookbarcode.Location = new System.Drawing.Point(21, 117);
            this.lbl_searchbookbarcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_searchbookbarcode.Name = "lbl_searchbookbarcode";
            this.lbl_searchbookbarcode.Size = new System.Drawing.Size(154, 20);
            this.lbl_searchbookbarcode.TabIndex = 22;
            this.lbl_searchbookbarcode.Text = "Barkod Numarası : ";
            // 
            // gbx_selectedbook
            // 
            this.gbx_selectedbook.Controls.Add(this.label1);
            this.gbx_selectedbook.Controls.Add(this.tbx_bookShelfNo);
            this.gbx_selectedbook.Controls.Add(this.lbl_bookauthor);
            this.gbx_selectedbook.Controls.Add(this.tbx_bookauthor);
            this.gbx_selectedbook.Controls.Add(this.lbl_bookpagecount);
            this.gbx_selectedbook.Controls.Add(this.tbx_bookno);
            this.gbx_selectedbook.Controls.Add(this.lbl_bookname);
            this.gbx_selectedbook.Controls.Add(this.tbx_bookname);
            this.gbx_selectedbook.Location = new System.Drawing.Point(13, 203);
            this.gbx_selectedbook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_selectedbook.Name = "gbx_selectedbook";
            this.gbx_selectedbook.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_selectedbook.Size = new System.Drawing.Size(417, 171);
            this.gbx_selectedbook.TabIndex = 20;
            this.gbx_selectedbook.TabStop = false;
            this.gbx_selectedbook.Text = "Seçilen Kitap";
            // 
            // lbl_bookauthor
            // 
            this.lbl_bookauthor.AutoSize = true;
            this.lbl_bookauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bookauthor.Location = new System.Drawing.Point(104, 63);
            this.lbl_bookauthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bookauthor.Name = "lbl_bookauthor";
            this.lbl_bookauthor.Size = new System.Drawing.Size(67, 20);
            this.lbl_bookauthor.TabIndex = 12;
            this.lbl_bookauthor.Text = "Yazar : ";
            // 
            // tbx_bookauthor
            // 
            this.tbx_bookauthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_bookauthor.Location = new System.Drawing.Point(188, 59);
            this.tbx_bookauthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_bookauthor.Name = "tbx_bookauthor";
            this.tbx_bookauthor.Size = new System.Drawing.Size(220, 26);
            this.tbx_bookauthor.TabIndex = 11;
            // 
            // lbl_bookpagecount
            // 
            this.lbl_bookpagecount.AutoSize = true;
            this.lbl_bookpagecount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bookpagecount.Location = new System.Drawing.Point(32, 98);
            this.lbl_bookpagecount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bookpagecount.Name = "lbl_bookpagecount";
            this.lbl_bookpagecount.Size = new System.Drawing.Size(139, 20);
            this.lbl_bookpagecount.TabIndex = 8;
            this.lbl_bookpagecount.Text = "Kitap Numarası : ";
            // 
            // tbx_bookno
            // 
            this.tbx_bookno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_bookno.Location = new System.Drawing.Point(188, 95);
            this.tbx_bookno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_bookno.Name = "tbx_bookno";
            this.tbx_bookno.Size = new System.Drawing.Size(220, 26);
            this.tbx_bookno.TabIndex = 7;
            // 
            // lbl_bookname
            // 
            this.lbl_bookname.AutoSize = true;
            this.lbl_bookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bookname.Location = new System.Drawing.Point(75, 27);
            this.lbl_bookname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bookname.Name = "lbl_bookname";
            this.lbl_bookname.Size = new System.Drawing.Size(98, 20);
            this.lbl_bookname.TabIndex = 4;
            this.lbl_bookname.Text = "Kitap İsmi : ";
            // 
            // tbx_bookname
            // 
            this.tbx_bookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_bookname.Location = new System.Drawing.Point(188, 23);
            this.tbx_bookname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_bookname.Name = "tbx_bookname";
            this.tbx_bookname.Size = new System.Drawing.Size(220, 26);
            this.tbx_bookname.TabIndex = 3;
            // 
            // txt_searchbookbarcode
            // 
            this.txt_searchbookbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_searchbookbarcode.Location = new System.Drawing.Point(204, 113);
            this.txt_searchbookbarcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_searchbookbarcode.Name = "txt_searchbookbarcode";
            this.txt_searchbookbarcode.Size = new System.Drawing.Size(220, 26);
            this.txt_searchbookbarcode.TabIndex = 21;
            this.txt_searchbookbarcode.TextChanged += new System.EventHandler(this.txt_searchbookbarcode_TextChanged);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(107, 386);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(200, 55);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "Kitabı Güncelle";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(107, 449);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(200, 55);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Kitabı Sil";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgw_books
            // 
            this.dgw_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_books.Location = new System.Drawing.Point(439, 7);
            this.dgw_books.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgw_books.Name = "dgw_books";
            this.dgw_books.RowHeadersWidth = 51;
            this.dgw_books.Size = new System.Drawing.Size(597, 532);
            this.dgw_books.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Raf Numarası : ";
            // 
            // tbx_bookShelfNo
            // 
            this.tbx_bookShelfNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_bookShelfNo.Location = new System.Drawing.Point(189, 129);
            this.tbx_bookShelfNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_bookShelfNo.Name = "tbx_bookShelfNo";
            this.tbx_bookShelfNo.Size = new System.Drawing.Size(220, 26);
            this.tbx_bookShelfNo.TabIndex = 13;
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1041, 548);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_searchbookbarcode);
            this.Controls.Add(this.lbl_searchbookbarcode);
            this.Controls.Add(this.gbx_selectedbook);
            this.Controls.Add(this.txt_searchbookbarcode);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgw_books);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BookListForm";
            this.Text = "MTT Kütüphane Otomasyonu Kitap Listeleme Paneli";
            this.Load += new System.EventHandler(this.BookListForm_Load);
            this.gbx_selectedbook.ResumeLayout(false);
            this.gbx_selectedbook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_searchbookbarcode;
        private System.Windows.Forms.Label lbl_searchbookbarcode;
        private System.Windows.Forms.GroupBox gbx_selectedbook;
        private System.Windows.Forms.Label lbl_bookauthor;
        private System.Windows.Forms.TextBox tbx_bookauthor;
        private System.Windows.Forms.Label lbl_bookpagecount;
        private System.Windows.Forms.TextBox tbx_bookno;
        private System.Windows.Forms.Label lbl_bookname;
        private System.Windows.Forms.TextBox tbx_bookname;
        private System.Windows.Forms.TextBox txt_searchbookbarcode;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgw_books;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_bookShelfNo;
    }
}