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
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
            LoadDoanhThu();
        }
        public void LoadDoanhThu()
        {
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            SqlDataAdapter daDoanhThu = null;
            DataTable dtDoanhThu = null;
            string sql = "SELECT A.MAHOADON,A.NGAYLAP,C.TENMON,C.DONGIA,B.SOLUONG,(C.DONGIA*B.SOLUONG) AS THANHTIEN FROM HOADON AS A, CHITIETHOADON AS B, THUCUONG AS C WHERE A.MAHOADON = B.MAHOADON AND B.MAMON = C.MAMON ORDER BY A.MAHOADON ASC ";
            try
            {
                conn = new SqlConnection(strConnectionString);
                daDoanhThu = new SqlDataAdapter(sql, conn);
                dtDoanhThu = new DataTable();
                dtDoanhThu.Clear();
                daDoanhThu.Fill(dtDoanhThu);
                dgvDoanhThu.DataSource = dtDoanhThu;
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi lấy doanh thu !");
            }
            dtDoanhThu.Dispose();
            dtDoanhThu = null;
            // Hủy kết nối
            conn = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtNam.Text == "")
            {
                MessageBox.Show("Chưa điền năm !");
            }
            else
            {
                try
                {
                    ThongKeThang(Convert.ToInt32(cbThang.Value), Convert.ToInt32(txtNam.Text));
                }
                catch(SqlException)
                {
                    MessageBox.Show("Năm phải là số !");
                }
            }
        }

        private void ThongKeThang(int thang_,int nam_)
        {
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            SqlDataAdapter daDoanhThu = null;
            DataTable dtDoanhThu = null;
            string sql = "SELECT A.MAHOADON,A.NGAYLAP,SUM((C.DONGIA*B.SOLUONG)) AS THANHTIEN FROM HOADON AS A,CHITIETHOADON AS B,THUCUONG AS C WHERE A.MAHOADON=B.MAHOADON AND B.MAMON=C.MAMON AND MONTH(A.NGAYLAP)="+thang_+" AND YEAR(A.NGAYLAP)="+nam_+" GROUP BY A.MAHOADON,A.NGAYLAP ORDER BY A.MAHOADON ASC ";
            try
            {
                conn = new SqlConnection(strConnectionString);
                daDoanhThu = new SqlDataAdapter(sql, conn);
                dtDoanhThu = new DataTable();
                dtDoanhThu.Clear();
                daDoanhThu.Fill(dtDoanhThu);
                dgvDoanhThu.DataSource = dtDoanhThu;
                TinhTongDoanhThu(thang_, nam_);
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi lấy doanh thu !");
            }
            dtDoanhThu.Dispose();
            dtDoanhThu = null;
            // Hủy kết nối
            conn = null;
        }

        private void TinhTongDoanhThu(int thang_, int nam_)
        {
            txtTongDoanhThu.Text = " 0 VND";
            int i;
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            SqlDataAdapter daDT = null;
            DataTable dtDT = null;
            string sql = "SELECT SUM((C.DONGIA*B.SOLUONG)) AS THANHTIEN FROM HOADON AS A,CHITIETHOADON AS B,THUCUONG AS C WHERE A.MAHOADON=B.MAHOADON AND B.MAMON=C.MAMON AND MONTH(A.NGAYLAP)="+thang_+" AND YEAR(A.NGAYLAP)="+nam_+"";
            try
            {
                conn = new SqlConnection(strConnectionString);
                daDT = new SqlDataAdapter(sql, conn);
                dtDT = new DataTable();
                dtDT.Clear();
                daDT.Fill(dtDT);

            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi lấy tổng doanh thu !");
            }
            for (i = 0; i < dtDT.Rows.Count; i++)
            {
                txtTongDoanhThu.Text = dtDT.Rows[i]["THANHTIEN"].ToString()+" VND";
                txtTongDoanhThu.ForeColor = Color.Red;
            }
            dtDT.Dispose();
            dtDT = null;
            // Hủy kết nối
            conn = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadDoanhThu();
            txtTongDoanhThu.Text = " 0 VND";
        }
    }
}
