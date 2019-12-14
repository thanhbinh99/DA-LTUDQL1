using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiem
{
    public partial class frmLogin : Form
    {
        static NguoiDung nguoidung;
        static Form frm = null;
        static NguoiDung nguoiDung = null;
        
        public frmLogin()
        {
            InitializeComponent();
            txtmadangnhap.Validating += txtTenDangNhap_Validating;
            txtMatKhau.Validating += txtTenDangNhap_Validating;

            txtmadangnhap.GotFocus += TextBox_GotFocus;
            txtMatKhau.GotFocus += TextBox_GotFocus;
            txtmadangnhap.GotFocus += TextBox_LostFocus;
            txtMatKhau.GotFocus += TextBox_LostFocus;

            txtMatKhau.TextChanged += (s, e) =>
            {
                using (var qlttn = new QLTTNDataContext())
                {
                    nguoidung = qlttn.NguoiDungs.Where(nd => nd.maND == txtmadangnhap.Text && nd.MatKhau == txtMatKhau.Text).FirstOrDefault();
                    if (nguoidung != null)
                    {
                        frm = null;
                        if (nguoidung.maLND == "HS")
                        {
                            frm = new frmHocSinh();
                        }
                        else if (nguoidung.maLND == "GV")
                        {
                            frm = new frmGiaoVien();
                        }
                        else if(nguoidung.maLND == "AD")
                        {
                            frm = new frmAdmin();
                        }
                        if(frm != null)
                        {
                            frm.Show();
                            this.Hide();
                        }
                   
                    }
                }
            };
            this.Focus();
        }

        private void txtTenDangNhap_Validating(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.Text = "";
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.SelectedText = "";

            //this.Paint += (s, e) =>
            // {
            //     Image img = ThiTracNghiem.Properties.Resources.hinh_nen_form_login;
            //     e.Graphics.DrawImage(img, groupBox1.Bounds);
            // };
        }

        }
        
        //private void btndangki_Click(object sender, EventArgs e)
        //{
        //    fromDangKy dk = new fromDangKy(this);
        //    dk.ShowDialog();
        //}
    }

