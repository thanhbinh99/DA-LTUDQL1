namespace ThiTracNghiem
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.txtmadangnhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndangki = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).BeginInit();
            // 
            // txtmadangnhap
            // 
            this.txtmadangnhap.Location = new System.Drawing.Point(33, 31);
            this.txtmadangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtmadangnhap.Name = "txtmadangnhap";
            this.txtmadangnhap.Size = new System.Drawing.Size(219, 30);
            this.txtmadangnhap.TabIndex = 1;
            this.txtmadangnhap.Text = "Điền mã đăng nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtmadangnhap);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(329, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(288, 154);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(33, 85);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '$';
            this.txtMatKhau.Size = new System.Drawing.Size(219, 30);
            this.txtMatKhau.TabIndex = 2;
            // errorProviderMain
            // 
            this.errorProviderMain.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Location = new System.Drawing.Point(207, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(13, 65);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '$';
            this.txtMatKhau.Size = new System.Drawing.Size(165, 20);
            this.txtMatKhau.TabIndex = 5;
            this.txtMatKhau.Text = "123456789";
            this.txtMatKhau.UseSystemPasswordChar = true;
        
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.errorProviderMain.SetIconAlignment(this.label1, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(80, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(768, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chào Mừng Bạn Đến với Bài Thi Trắc Nghiệm";
            // 
            // btndangki
            // 
            this.btndangki.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndangki.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndangki.Location = new System.Drawing.Point(362, 300);
            this.btndangki.Name = "btndangki";
            this.btndangki.Size = new System.Drawing.Size(219, 50);
            this.btndangki.TabIndex = 5;
            this.btndangki.Text = "Đăng Ký Tài Khoản ";
            this.btndangki.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ThiTracNghiem.Properties.Resources.hinh_nen_form_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 516);
            this.Controls.Add(this.btndangki);
            this.Controls.Add(this.label1);
            this.ClientSize = new System.Drawing.Size(604, 392);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtmadangnhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.ErrorProvider errorProviderMain;
        private System.Windows.Forms.Button btndangki;
        private System.Windows.Forms.Label label1;
    }
}