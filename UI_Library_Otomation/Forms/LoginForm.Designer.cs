
namespace UI_Library_Otomation
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btn_login = new System.Windows.Forms.Button();
            this.pbx_mtt_logo = new System.Windows.Forms.PictureBox();
            this.lbl_library_otomation_header = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_mtt_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.Location = new System.Drawing.Point(423, 160);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(117, 128);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Giriş Yap";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pbx_mtt_logo
            // 
            this.pbx_mtt_logo.Image = ((System.Drawing.Image)(resources.GetObject("pbx_mtt_logo.Image")));
            this.pbx_mtt_logo.Location = new System.Drawing.Point(95, 29);
            this.pbx_mtt_logo.Name = "pbx_mtt_logo";
            this.pbx_mtt_logo.Size = new System.Drawing.Size(130, 130);
            this.pbx_mtt_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_mtt_logo.TabIndex = 1;
            this.pbx_mtt_logo.TabStop = false;
            // 
            // lbl_library_otomation_header
            // 
            this.lbl_library_otomation_header.AutoSize = true;
            this.lbl_library_otomation_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_library_otomation_header.ForeColor = System.Drawing.Color.Snow;
            this.lbl_library_otomation_header.Location = new System.Drawing.Point(229, 53);
            this.lbl_library_otomation_header.Name = "lbl_library_otomation_header";
            this.lbl_library_otomation_header.Size = new System.Drawing.Size(219, 78);
            this.lbl_library_otomation_header.TabIndex = 2;
            this.lbl_library_otomation_header.Text = "Kütüphane \r\nOtomasyonu";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_password.Location = new System.Drawing.Point(162, 231);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(243, 30);
            this.txt_password.TabIndex = 3;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_username.Location = new System.Drawing.Point(162, 188);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(243, 30);
            this.txt_username.TabIndex = 4;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_username.ForeColor = System.Drawing.Color.Snow;
            this.lbl_username.Location = new System.Drawing.Point(12, 191);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(135, 25);
            this.lbl_username.TabIndex = 5;
            this.lbl_username.Text = "Kullanıcı Adı : ";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_password.ForeColor = System.Drawing.Color.Snow;
            this.lbl_password.Location = new System.Drawing.Point(79, 234);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(68, 25);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Şifre : ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(552, 314);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_library_otomation_header);
            this.Controls.Add(this.pbx_mtt_logo);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "MTT Kütüphane Otomasyonu Giriş Ekranı";
            this.Load += new System.EventHandler(this.frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_mtt_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox pbx_mtt_logo;
        private System.Windows.Forms.Label lbl_library_otomation_header;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
    }
}

