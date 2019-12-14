using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiem
{
    public partial class fromDangKy : Form
    {
        AccessData acc = new AccessData();
        frmLogin frmlogin;
        public fromDangKy(frmLogin frmlogin)
        {
            this.frmlogin = frmlogin;
            InitializeComponent();
            //    for (int i =1; i<=31;i++)
            //    {
            //        this.cbdate.Items.Add(i.ToString());
            //    }
            //    for (int i=0;i<=12;i++)
            //    {
            //        this.cbmonth.Items.Add(i.ToString());
            //    }
            //    int curyear = DateTime.Now.Year;
            //    for (int i=curyear; i>=1900;i--)
            //    {
            //        this.cbyear.Items.Add(i.ToString());
            //    }
        }
        private void btndangky_Click(object sender, EventArgs e)
        {
            AccessData acc = new AccessData();
            string loaind = "";
            if (this.rbGV.Checked == true)
            {
                loaind = "GV";
            }
            else
            {
                if (this.rbHS.Checked == true)
                {
                    loaind = "HS";
                }
            }
            string sql = "INSERT INTO NGUOIDUNG VALUES('" + txtmanguoidung.Text + "', '" + txtmk.Text + "','" + loaind + "')"; // Query Insert data
            acc.ExcuteNotQuery(sql);
            MessageBox.Show("Đăng Ký Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // Nếu đang ký thành công => Sẽ có thông báo Thành Công và đồng thời các TextBox sẽ mất giá trị do [B]ClearTextBox()[/B].
            ClearTextBox();

            frmlogin.Show();
            this.Close();
        }
        private void ClearTextBox()
        {
            txtmanguoidung.Clear();
            txtmk.Clear();
        }
    }
}
