using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ThiTracNghiem
{
    class KiemTraDangNhap
    {
        public int checklogin (string mand, string password)
        {
            AccessData acc = new AccessData();
            SqlDataReader reader = acc.ExecuteReader("SELECT maND, MatKhau FROM NGUOIDUNG");
            while(reader.Read())
            {
                if (reader[0].ToString()==mand && reader[1].ToString()==password)
                {
                    //reader[0] tương ứng cho textbox username
                    //reader[1] tương ứng cho textbox password
                    return 1;
                }
            }
            return 0;
        }
    }
}
