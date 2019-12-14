namespace ThiTracNghiem
{
    partial class fromDangKy
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
            this.txtmk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbGV = new System.Windows.Forms.RadioButton();
            this.rbHS = new System.Windows.Forms.RadioButton();
            this.btndangky = new System.Windows.Forms.Button();
            this.txtmanguoidung = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(185, 87);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(277, 22);
            this.txtmk.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mật Khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Loại Người Dùng";
            // 
            // rbGV
            // 
            this.rbGV.AutoSize = true;
            this.rbGV.Location = new System.Drawing.Point(210, 154);
            this.rbGV.Name = "rbGV";
            this.rbGV.Size = new System.Drawing.Size(91, 21);
            this.rbGV.TabIndex = 15;
            this.rbGV.TabStop = true;
            this.rbGV.Text = "Giao Viên";
            this.rbGV.UseVisualStyleBackColor = true;
            // 
            // rbHS
            // 
            this.rbHS.AutoSize = true;
            this.rbHS.Location = new System.Drawing.Point(348, 154);
            this.rbHS.Name = "rbHS";
            this.rbHS.Size = new System.Drawing.Size(86, 21);
            this.rbHS.TabIndex = 16;
            this.rbHS.TabStop = true;
            this.rbHS.Text = "Học Sinh";
            this.rbHS.UseVisualStyleBackColor = true;
            // 
            // btndangky
            // 
            this.btndangky.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndangky.Location = new System.Drawing.Point(210, 226);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(140, 50);
            this.btndangky.TabIndex = 17;
            this.btndangky.Text = "Đăng Ký";
            this.btndangky.UseVisualStyleBackColor = true;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // txtmanguoidung
            // 
            this.txtmanguoidung.Location = new System.Drawing.Point(185, 27);
            this.txtmanguoidung.Name = "txtmanguoidung";
            this.txtmanguoidung.Size = new System.Drawing.Size(277, 22);
            this.txtmanguoidung.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Mã Người Dùng";
            // 
            // fromDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 316);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtmanguoidung);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.rbHS);
            this.Controls.Add(this.rbGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.label4);
            this.Name = "fromDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fromDangKi";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbGV;
        private System.Windows.Forms.RadioButton rbHS;
        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.TextBox txtmanguoidung;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}