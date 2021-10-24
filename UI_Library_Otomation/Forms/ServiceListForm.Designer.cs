
namespace UI_Library_Otomation.Forms
{
    partial class ServiceListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceListForm));
            this.dgw_services = new System.Windows.Forms.DataGridView();
            this.tbx_searchbookbarcode = new System.Windows.Forms.TextBox();
            this.lbl_searchbookbarcode = new System.Windows.Forms.Label();
            this.lbl_searchstudent = new System.Windows.Forms.Label();
            this.txt_searchstudent = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.gbx_searchbook = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbx_searchstudemt = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_services)).BeginInit();
            this.gbx_searchbook.SuspendLayout();
            this.gbx_searchstudemt.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_services
            // 
            this.dgw_services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_services.Location = new System.Drawing.Point(288, 12);
            this.dgw_services.Name = "dgw_services";
            this.dgw_services.Size = new System.Drawing.Size(415, 494);
            this.dgw_services.TabIndex = 0;
            // 
            // tbx_searchbookbarcode
            // 
            this.tbx_searchbookbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbx_searchbookbarcode.Location = new System.Drawing.Point(113, 22);
            this.tbx_searchbookbarcode.Name = "tbx_searchbookbarcode";
            this.tbx_searchbookbarcode.Size = new System.Drawing.Size(147, 23);
            this.tbx_searchbookbarcode.TabIndex = 1;
            this.tbx_searchbookbarcode.TextChanged += new System.EventHandler(this.tbx_searchbookbarcode_TextChanged);
            // 
            // lbl_searchbookbarcode
            // 
            this.lbl_searchbookbarcode.AutoSize = true;
            this.lbl_searchbookbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_searchbookbarcode.Location = new System.Drawing.Point(20, 25);
            this.lbl_searchbookbarcode.Name = "lbl_searchbookbarcode";
            this.lbl_searchbookbarcode.Size = new System.Drawing.Size(87, 17);
            this.lbl_searchbookbarcode.TabIndex = 3;
            this.lbl_searchbookbarcode.Text = "Barkod No : ";
            // 
            // lbl_searchstudent
            // 
            this.lbl_searchstudent.AutoSize = true;
            this.lbl_searchstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_searchstudent.Location = new System.Drawing.Point(15, 22);
            this.lbl_searchstudent.Name = "lbl_searchstudent";
            this.lbl_searchstudent.Size = new System.Drawing.Size(92, 17);
            this.lbl_searchstudent.TabIndex = 6;
            this.lbl_searchstudent.Text = "Öğrenci Ara :";
            // 
            // txt_searchstudent
            // 
            this.txt_searchstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_searchstudent.Location = new System.Drawing.Point(113, 19);
            this.txt_searchstudent.Name = "txt_searchstudent";
            this.txt_searchstudent.Size = new System.Drawing.Size(147, 23);
            this.txt_searchstudent.TabIndex = 4;
            this.txt_searchstudent.TextChanged += new System.EventHandler(this.txt_searchstudent_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "Çıkış ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gbx_searchbook
            // 
            this.gbx_searchbook.Controls.Add(this.tbx_searchbookbarcode);
            this.gbx_searchbook.Controls.Add(this.lbl_searchbookbarcode);
            this.gbx_searchbook.Location = new System.Drawing.Point(7, 183);
            this.gbx_searchbook.Name = "gbx_searchbook";
            this.gbx_searchbook.Size = new System.Drawing.Size(266, 63);
            this.gbx_searchbook.TabIndex = 8;
            this.gbx_searchbook.TabStop = false;
            this.gbx_searchbook.Text = "Kitap Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Barkod No : ";
            // 
            // gbx_searchstudemt
            // 
            this.gbx_searchstudemt.Controls.Add(this.txt_searchstudent);
            this.gbx_searchstudemt.Controls.Add(this.lbl_searchstudent);
            this.gbx_searchstudemt.Location = new System.Drawing.Point(7, 291);
            this.gbx_searchstudemt.Name = "gbx_searchstudemt";
            this.gbx_searchstudemt.Size = new System.Drawing.Size(266, 60);
            this.gbx_searchstudemt.TabIndex = 9;
            this.gbx_searchstudemt.TabStop = false;
            this.gbx_searchstudemt.Text = "Öğrenci Ara";
            // 
            // ServiceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(710, 518);
            this.Controls.Add(this.gbx_searchstudemt);
            this.Controls.Add(this.gbx_searchbook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgw_services);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServiceListForm";
            this.Text = "MTT Kütüphane Otomasyonu Emanet Listeleme Paneli";
            this.Load += new System.EventHandler(this.ServiceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_services)).EndInit();
            this.gbx_searchbook.ResumeLayout(false);
            this.gbx_searchbook.PerformLayout();
            this.gbx_searchstudemt.ResumeLayout(false);
            this.gbx_searchstudemt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_services;
        private System.Windows.Forms.TextBox tbx_searchbookbarcode;
        private System.Windows.Forms.Label lbl_searchbookbarcode;
        private System.Windows.Forms.Label lbl_searchstudent;
        private System.Windows.Forms.TextBox txt_searchstudent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gbx_searchbook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbx_searchstudemt;
    }
}