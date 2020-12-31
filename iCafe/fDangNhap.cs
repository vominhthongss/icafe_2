using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCafe
{
    public partial class fDangNhap : Form
    {
        private string user;
        private string password;
        public fDangNhap()
        {
            InitializeComponent();
            
        }


        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if (KiemTraDangNhap(User, Password) == true)
            {
                LoadFormQuanLyBan(User);
            }
            else MessageBox.Show("Sai mật khẩu hoặc tài khoản !");
          
            
        }
        public bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            bool kq = false;
            User = txtUser.Text.ToString();
            Password = txtPassword.Text.ToString();
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            SqlDataAdapter daTaiKhoan = null;
            DataTable dtTaiKhoan = null;
            string sql = "SELECT * FROM NHANVIEN WHERE MANHANVIEN='"+User+"' AND MATKHAU='"+Password+"'";
            try
            {
                conn = new SqlConnection(strConnectionString);
                daTaiKhoan = new SqlDataAdapter(sql, conn);
                dtTaiKhoan = new DataTable();
                dtTaiKhoan.Clear();
                daTaiKhoan.Fill(dtTaiKhoan);
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi lấy tài khoản !");
            }
            if (dtTaiKhoan.Rows.Count > 0)
            {
                kq = true;
            }
            else kq = false;


            dtTaiKhoan.Dispose();
            dtTaiKhoan = null;
            // Hủy kết nối
            conn = null;


            return kq;
        }
        private void LoadFormQuanLyBan(string tenDangNhap)
        {
            fQuanLyBan fquanlyban = new fQuanLyBan(tenDangNhap);
            this.Hide();
            fquanlyban.ShowDialog();
            this.Show();
        }
    }
}
