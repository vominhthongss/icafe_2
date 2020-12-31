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
    public partial class fQuanLyBan : Form
    {
        public static string USER;
        public fQuanLyBan()
        {
            InitializeComponent();
            LoadDanhSachThucUong();
            LoadTrangThaiBan();
            
            
        }
        public fQuanLyBan(string user)
        {
            InitializeComponent();
            LoadDanhSachThucUong();
            LoadTrangThaiBan();
            LoadTenNguoiDangNhap(user);
            
        }
        public string nam = DateTime.Now.ToString("yyyy");
        public string thang = DateTime.Now.ToString("MM");
        public string ngay = DateTime.Now.ToString("dd");
        public string today;
        
        private void LoadTenNguoiDangNhap(string user)
        {
            USER = user;
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            SqlDataAdapter daTaiKhoan = null;
            DataTable dtTaiKhoan = null;
            string sql = "SELECT TENNHANVIEN FROM NHANVIEN WHERE MANHANVIEN='" + user + "'";
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
            lbUser.Text = dtTaiKhoan.Rows[0]["TENNHANVIEN"].ToString();


            dtTaiKhoan.Dispose();
            dtTaiKhoan = null;
            // Hủy kết nối
            conn = null;
        }

        public void LoadTrangThaiBan()
        {
            //xử lý trạng thái bàn
            int i;
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            SqlDataAdapter daBan = null;
            DataTable dtBan= null;
            string sql = "SELECT * FROM BAN";
            try
            {
                conn = new SqlConnection(strConnectionString);
                daBan = new SqlDataAdapter(sql, conn);
                dtBan = new DataTable();
                dtBan.Clear();
                daBan.Fill(dtBan);
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi lấy trạng thái bàn !");
            }
            
            for (i = 0; i < dtBan.Rows.Count; i++)
            {
                if(dtBan.Rows[i]["TRANGTHAI"].ToString()=="Có người")
                {
                    if (1 == (i + 1))
                    {
                        btnBan1.BackColor = Color.LightPink;
                    }
                    
                    if (2 == (i + 1))
                    {
                        btnBan2.BackColor = Color.LightPink;
                    }
                    
                    if (3 == (i + 1))
                    {
                        btnBan3.BackColor = Color.LightPink;
                    }
                    
                    if (4 == (i + 1))
                    {
                        btnBan4.BackColor = Color.LightPink;
                    }
                   
                    if (5 == (i + 1))
                    {
                        btnBan5.BackColor = Color.LightPink;
                    }
                    
                    if (6 == (i + 1))
                    {
                        btnBan6.BackColor = Color.LightPink;
                    }
                   
                    if (7 == (i + 1))
                    {
                        btnBan7.BackColor = Color.LightPink;
                    }
                    
                    if (8 == (i + 1))
                    {
                        btnBan8.BackColor = Color.LightPink;
                    }
                    
                    if (9 == (i + 1))
                    {
                        btnBan9.BackColor = Color.LightPink;
                    }
                    
                    if (10 == (i + 1))
                    {
                        btnBan10.BackColor = Color.LightPink;
                    }
                    
                }
                if (dtBan.Rows[i]["TRANGTHAI"].ToString() == "Trống")
                {
                    if (1 == (i + 1))
                    {
                        btnBan1.BackColor = Color.White;
                    }

                    if (2 == (i + 1))
                    {
                        btnBan2.BackColor = Color.White;
                    }

                    if (3 == (i + 1))
                    {
                        btnBan3.BackColor = Color.White;
                    }

                    if (4 == (i + 1))
                    {
                        btnBan4.BackColor = Color.White;
                    }

                    if (5 == (i + 1))
                    {
                        btnBan5.BackColor = Color.White;
                    }

                    if (6 == (i + 1))
                    {
                        btnBan6.BackColor = Color.White;
                    }

                    if (7 == (i + 1))
                    {
                        btnBan7.BackColor = Color.White;
                    }

                    if (8 == (i + 1))
                    {
                        btnBan8.BackColor = Color.White;
                    }

                    if (9 == (i + 1))
                    {
                        btnBan9.BackColor = Color.White;
                    }

                    if (10 == (i + 1))
                    {
                        btnBan10.BackColor = Color.White;
                    }

                }
            }
            dtBan.Dispose();
            dtBan = null;
            // Hủy kết nối
            conn = null;
            btnBan1.TabStop = false;
            btnBan2.TabStop = false;
            btnBan3.TabStop = false;
            btnBan4.TabStop = false;
            btnBan5.TabStop = false;
            btnBan6.TabStop = false;
            btnBan7.TabStop = false;
            btnBan8.TabStop = false;
            btnBan9.TabStop = false;
            btnBan10.TabStop = false;
        }
        public void BanDangChon(int SttBan)
        {
            lbBanDangChon.Text = ""+SttBan;
        }

        public void LayMaHoaDon(int SttBan)
        {
            int i;
            txtMaHoaDon.Text = "";
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            SqlDataAdapter daHoaDon = null;
            DataTable dtHoaDon = null;
            string sql = "SELECT A.MAHOADON FROM HOADON AS A,CHITIETHOADON AS B WHERE A.MAHOADON = B.MAHOADON AND A.TRANGTHAIHOADON = N'Chưa thanh toán' AND B.STTBAN = "+SttBan+" GROUP BY A.MAHOADON";
            try
            {
                conn = new SqlConnection(strConnectionString);
                daHoaDon = new SqlDataAdapter(sql, conn);
                dtHoaDon = new DataTable();
                dtHoaDon.Clear();
                daHoaDon.Fill(dtHoaDon);
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi lấy mã hóa đơn !");
            }
            for (i = 0; i < dtHoaDon.Rows.Count; i++)
            {
                txtMaHoaDon.Text = dtHoaDon.Rows[i]["MAHOADON"].ToString();
            }
            dtHoaDon.Dispose();
            dtHoaDon = null;
            // Hủy kết nối
            conn = null;
        }
        private void TinhTongTien(int SttBan)
        {
            txtTongTien.Text = "0 VND";
            int i;
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            SqlDataAdapter daHoaDon = null;
            DataTable dtHoaDon = null;
            string sql = "SELECT A.TENMON,B.SOLUONG,A.DONGIA, (B.SOLUONG*A.DONGIA) AS THANHTIEN FROM THUCUONG AS A,CHITIETHOADON AS B,HOADON AS C WHERE A.MAMON = B.MAMON AND B.MAHOADON = C.MAHOADON AND C.TRANGTHAIHOADON = N'Chưa thanh toán' AND STTBAN = " + SttBan + " ";
            try
            {
                conn = new SqlConnection(strConnectionString);
                daHoaDon = new SqlDataAdapter(sql, conn);
                dtHoaDon = new DataTable();
                dtHoaDon.Clear();
                daHoaDon.Fill(dtHoaDon);
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi lấy tính tổng tiền !");
            }
            int tongtien = 0;
            for (i = 0; i < dtHoaDon.Rows.Count; i++)
            {
                tongtien += Convert.ToInt32(dtHoaDon.Rows[i]["THANHTIEN"]);
            }
            txtTongTien.Text =tongtien+" VND";
            dtHoaDon.Dispose();
            dtHoaDon = null;
            // Hủy kết nối
            conn = null;
        }
        public void LoadDanhSachThucUong()
        {
            int i;
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            SqlDataAdapter daThucUong = null;
            DataTable dtThucUong = null;
            string sql = "SELECT * FROM THUCUONG ORDER BY TENMON ASC";
            try
            {
                conn = new SqlConnection(strConnectionString);
                daThucUong = new SqlDataAdapter(sql, conn);
                dtThucUong = new DataTable();
                dtThucUong.Clear();
                daThucUong.Fill(dtThucUong);                        
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi lấy danh sách món!");
            }
            //đổ danh sách các món uống vào ComboBox
            for (i = 0; i < dtThucUong.Rows.Count; i++)
            {
                cbThucUong.Items.Add(dtThucUong.Rows[i]["TENMON"].ToString()); 
            }
            /////
            cbThucUong.SelectedItem = dtThucUong.Rows[0]["TENMON"].ToString(); // set giá trị mặc định đầu tiên
            dtThucUong.Dispose();
            dtThucUong = null;
            // Hủy kết nối
            conn = null;
        }
        public void LoadHoaDonBan(int SttBan)
        {
            BanDangChon(SttBan);
            LayMaHoaDon(SttBan);
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            SqlDataAdapter daHoaDon = null;
            DataTable dtHoaDon = null;
            string sql = "SELECT A.TENMON,B.SOLUONG,A.DONGIA, (B.SOLUONG*A.DONGIA) AS THANHTIEN FROM THUCUONG AS A,CHITIETHOADON AS B,HOADON AS C WHERE A.MAMON = B.MAMON AND B.MAHOADON = C.MAHOADON AND C.TRANGTHAIHOADON =N'Chưa thanh toán' AND STTBAN = " + SttBan+" ";
            try
            {
                conn = new SqlConnection(strConnectionString);
                daHoaDon = new SqlDataAdapter(sql, conn);
                dtHoaDon = new DataTable();
                dtHoaDon.Clear();
                daHoaDon.Fill(dtHoaDon);
                dgvHoaDon.DataSource = dtHoaDon;
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi lấy hóa đơn !");
            }
            dtHoaDon.Dispose();
            dtHoaDon = null;
            // Hủy kết nối
            conn = null;
        }
        public void LayMaMon(string TenMon)
        {
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            SqlDataAdapter daMaMon = null;
            DataTable dtMaMon= null;
            string sql = "SELECT MAMON FROM THUCUONG WHERE TENMON=N'"+TenMon+"'";
            try
            {
                conn = new SqlConnection(strConnectionString);
                daMaMon = new SqlDataAdapter(sql, conn);
                dtMaMon = new DataTable();
                dtMaMon.Clear();
                daMaMon.Fill(dtMaMon);
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi lấy mã món!");
            }
            txtMaMon.Text = dtMaMon.Rows[0]["MAMON"].ToString();
            dtMaMon.Dispose();
            dtMaMon = null;
            // Hủy kết nối
            conn = null;
        }
        public void XoaMon()
        {
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                int r = dgvHoaDon.CurrentCell.RowIndex;
                string TenMon = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
                string sql = "DELETE FROM CHITIETHOADON WHERE MAMON=(SELECT MAMON FROM THUCUONG WHERE TENMON=N'"+TenMon+"') AND MAHOADON='" + txtMaHoaDon.Text.ToString() + "' ";
                cmd.CommandText = System.String.Concat(sql);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                LoadHoaDonBan(Convert.ToInt32(lbBanDangChon.Text));
                MessageBox.Show("Đã xóa xong!");
                
            }
            catch(SqlException)
            {
                MessageBox.Show("Không xóa được món ăn lỗi rồi !!!");
            }
            //
           

        }

        private void ResetLaiBan(object sttBan)
        {
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                string sql = "UPDATE BAN SET TRANGTHAI=N'Trống' WHERE STTBAN=" + sttBan + " ";
                cmd.CommandText = System.String.Concat(sql);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                LoadTrangThaiBan();



            }
            catch (SqlException)
            {
                MessageBox.Show("Không cập nhật được bàn có người lỗi rồi !!!");
            }
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public void ThemMonChoBan(int SttBan)
        {
            
            
            string mahoadon = RandomString(10); //mã hóa đơn tạo ngẫu nhiên

            string mamon = txtMaMon.Text.ToString();
            string mahoadon_txt = txtMaHoaDon.Text.ToString();
            string soluong = cbSoLuong.Value.ToString();
            int bandangchon = Convert.ToInt32(lbBanDangChon.Text);

            if (SttBan == 1)
            {
                string _mahoadon = mahoadon;
                if (btnBan1.BackColor == Color.LightPink)
                {
                    
                    ThemVaoChiTietHoaDon(bandangchon, mahoadon_txt, mamon, soluong);
                }
                else
                {
                    TaoHoaDon(_mahoadon, USER);
                    ThemVaoChiTietHoaDon(bandangchon, _mahoadon, mamon, soluong);
                    CapNhatBanCoNguoi(bandangchon);
                }
                TinhTongTien(bandangchon);
            }
            if (SttBan == 2)
            {
                string _mahoadon = mahoadon;
                if (btnBan2.BackColor == Color.LightPink)
                {
                    ThemVaoChiTietHoaDon(bandangchon, mahoadon_txt, mamon, soluong);
                }
                else
                {
                    TaoHoaDon(_mahoadon, USER);
                    ThemVaoChiTietHoaDon(bandangchon, _mahoadon, mamon, soluong);
                    CapNhatBanCoNguoi(bandangchon);
                }
                TinhTongTien(bandangchon);
            }
            if (SttBan == 3)
            {
                string _mahoadon = mahoadon;
                if (btnBan3.BackColor == Color.LightPink)
                {
                    ThemVaoChiTietHoaDon(bandangchon, mahoadon_txt, mamon, soluong);
                }
                else
                {
                    TaoHoaDon(_mahoadon, USER);
                    ThemVaoChiTietHoaDon(bandangchon, _mahoadon, mamon, soluong);
                    CapNhatBanCoNguoi(bandangchon);
                }
                TinhTongTien(bandangchon);
            }
            if (SttBan == 4)
            {
                string _mahoadon = mahoadon;
                if (btnBan4.BackColor == Color.LightPink)
                {
                    ThemVaoChiTietHoaDon(bandangchon, mahoadon_txt, mamon, soluong);
                }
                else
                {
                    TaoHoaDon(_mahoadon, USER);
                    ThemVaoChiTietHoaDon(bandangchon, _mahoadon, mamon, soluong);
                    CapNhatBanCoNguoi(bandangchon);
                }
                TinhTongTien(bandangchon);
            }
            if (SttBan == 5)
            {
                string _mahoadon = mahoadon;
                if (btnBan5.BackColor == Color.LightPink)
                {
                    ThemVaoChiTietHoaDon(bandangchon, mahoadon_txt, mamon, soluong);
                }
                else
                {
                    TaoHoaDon(_mahoadon, USER);
                    ThemVaoChiTietHoaDon(bandangchon, _mahoadon, mamon, soluong);
                    CapNhatBanCoNguoi(bandangchon);
                }
                TinhTongTien(bandangchon);
            }
            if (SttBan == 6)
            {
                string _mahoadon = mahoadon;
                if (btnBan6.BackColor == Color.LightPink)
                {
                    ThemVaoChiTietHoaDon(bandangchon, mahoadon_txt, mamon, soluong);
                }
                else
                {
                    TaoHoaDon(_mahoadon, USER);
                    ThemVaoChiTietHoaDon(bandangchon, _mahoadon, mamon, soluong);
                    CapNhatBanCoNguoi(bandangchon);
                }
                TinhTongTien(bandangchon);
            }
            if (SttBan == 7)
            {
                string _mahoadon = mahoadon;
                if (btnBan7.BackColor == Color.LightPink)
                {
                    ThemVaoChiTietHoaDon(bandangchon, mahoadon_txt, mamon, soluong);
                }
                else
                {
                    TaoHoaDon(_mahoadon, USER);
                    ThemVaoChiTietHoaDon(bandangchon, _mahoadon, mamon, soluong);
                    CapNhatBanCoNguoi(bandangchon);
                }
                TinhTongTien(bandangchon);
            }
            if (SttBan == 8)
            {
                string _mahoadon = mahoadon;
                if (btnBan8.BackColor == Color.LightPink)
                {
                    ThemVaoChiTietHoaDon(bandangchon, mahoadon_txt, mamon, soluong);
                }
                else
                {
                    TaoHoaDon(_mahoadon, USER);
                    ThemVaoChiTietHoaDon(bandangchon, _mahoadon, mamon, soluong);
                    CapNhatBanCoNguoi(bandangchon);
                }
                TinhTongTien(bandangchon);
            }
            if (SttBan == 9)
            {
                string _mahoadon = mahoadon;
                if (btnBan9.BackColor == Color.LightPink)
                {
                    ThemVaoChiTietHoaDon(bandangchon, mahoadon_txt, mamon, soluong);
                }
                else
                {
                    TaoHoaDon(_mahoadon, USER);
                    ThemVaoChiTietHoaDon(bandangchon, _mahoadon, mamon, soluong);
                    CapNhatBanCoNguoi(bandangchon);
                }
                TinhTongTien(bandangchon);
            }
            if (SttBan == 10)
            {
                string _mahoadon = mahoadon;
                if (btnBan10.BackColor == Color.LightPink)
                {
                    ThemVaoChiTietHoaDon(bandangchon, mahoadon_txt, mamon, soluong);
                }
                else
                {
                    TaoHoaDon(_mahoadon, USER);
                    ThemVaoChiTietHoaDon(bandangchon, _mahoadon, mamon, soluong);
                    CapNhatBanCoNguoi(bandangchon);
                }
                TinhTongTien(bandangchon);
            }

        }

        private void ThemVaoChiTietHoaDon(int sttBan, string mahd, string mamon, string soluong)
        {
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                string sql = "INSERT INTO CHITIETHOADON VALUES("+sttBan+",'"+mamon+"','"+mahd+"',"+soluong+")";
                cmd.CommandText = System.String.Concat(sql);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                LoadHoaDonBan(Convert.ToInt32(lbBanDangChon.Text));
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm vào chi tiết hóa đơn lỗi rồi !!!");
            }
        }

        private void CapNhatBanCoNguoi(int sttBan)
        {
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                string sql = "UPDATE BAN SET TRANGTHAI=N'Có người' WHERE STTBAN="+sttBan+" ";
                cmd.CommandText = System.String.Concat(sql);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                LoadTrangThaiBan();

                
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Không cập nhật được bàn có người lỗi rồi !!!");
            }
        }

        private void TaoHoaDon(string mahoadon, string manhanvien)
        {
            today = nam + "-" + thang + "-" + ngay;
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                
                string sql = "INSERT INTO HOADON VALUES('"+mahoadon+"','"+manhanvien+ "','"+today+"',N'Chưa thanh toán')";          //"+ DateTime.Now.ToString("yyyy-mm-dd")+"    
                cmd.CommandText = System.String.Concat(sql);
                
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                
                LoadHoaDonBan(Convert.ToInt32(lbBanDangChon.Text));
                MessageBox.Show("Đã tạo hóa đơn!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không tạo được hóa đơn lỗi rồi !!!");
            }

        }

        private void btnBan1_Click(object sender, EventArgs e)
        {
            LoadHoaDonBan(1);
            TinhTongTien(1);
        }
        private void btnBan2_Click(object sender, EventArgs e)
        {
            LoadHoaDonBan(2);
            TinhTongTien(2);
        }

        private void btnBan3_Click(object sender, EventArgs e)
        {
            LoadHoaDonBan(3);
            TinhTongTien(3);
        }

        private void btnBan4_Click(object sender, EventArgs e)
        {
            LoadHoaDonBan(4);
            TinhTongTien(4);
        }

        private void btnBan5_Click(object sender, EventArgs e)
        {
            LoadHoaDonBan(5);
            TinhTongTien(5);
        }

        private void btnBan6_Click(object sender, EventArgs e)
        {
            LoadHoaDonBan(6);
            TinhTongTien(6);
        }

        private void btnBan7_Click(object sender, EventArgs e)
        {
            LoadHoaDonBan(7);
            TinhTongTien(7);
        }

        private void btnBan8_Click(object sender, EventArgs e)
        {
            LoadHoaDonBan(8);
            TinhTongTien(8);
        }

        private void btnBan9_Click(object sender, EventArgs e)
        {
            LoadHoaDonBan(9);
            TinhTongTien(9);
        }

        private void btnBan10_Click(object sender, EventArgs e)
        {
            LoadHoaDonBan(10);
            TinhTongTien(10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(lbBanDangChon.Text.ToString()=="Chưa chọn bàn")
            {
                MessageBox.Show("Hãy chọn bàn !");
            }
            else ThemMonChoBan(Convert.ToInt32(lbBanDangChon.Text));
        }


        private void button2_Click(object sender, EventArgs e)
        {
            XoaMon();
            
            if (txtMaHoaDon.Text == "")
            {
                
                ResetLaiBan(Convert.ToInt32(lbBanDangChon.Text));     
            }
            TinhTongTien(Convert.ToInt32(lbBanDangChon.Text));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CẬP NHẬT HÓA ĐƠN");
        }

        private void cbThucUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayMaMon(cbThucUong.SelectedItem.ToString());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThucHienThanhToan(txtMaHoaDon.Text);
        }

        private void ThucHienThanhToan(string mahoadon)
        {
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                string sql = "UPDATE HOADON SET TRANGTHAIHOADON=N'Đã thanh toán' WHERE MAHOADON='"+mahoadon+"' ";         
                cmd.CommandText = System.String.Concat(sql);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                LoadHoaDonBan(Convert.ToInt32(lbBanDangChon.Text));
                TinhTongTien(Convert.ToInt32(lbBanDangChon.Text));
                ResetLaiBan(Convert.ToInt32(lbBanDangChon.Text));
                LoadTrangThaiBan();
                MessageBox.Show("Đã thanh toán!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thanh toán được !!!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fThongKe fthongke = new fThongKe();
            this.Hide();
            fthongke.ShowDialog();
            this.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ChuyenBan(Convert.ToInt32(cbBanChuyen.Value),txtMaHoaDon.Text);
        }

        private void ChuyenBan(int sttban,string mahoadon)
        {
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                string sql = "UPDATE CHITIETHOADON SET STTBAN="+sttban+" WHERE MAHOADON='"+mahoadon+"'";
                cmd.CommandText = System.String.Concat(sql);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                LoadHoaDonBan(Convert.ToInt32(lbBanDangChon.Text));
                TinhTongTien(Convert.ToInt32(lbBanDangChon.Text));
                ResetLaiBan(Convert.ToInt32(lbBanDangChon.Text));

                CapNhatBanChuyen(sttban);
                LoadTrangThaiBan();
                MessageBox.Show("Đã chuyển bàn!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không chuyển được !!!");
            }
        }

        private void CapNhatBanChuyen(int sttban)
        {
            string strConnectionString = "Data Source=GOON-CHAN;Initial Catalog=ICAFE;Integrated Security=True";
            SqlConnection conn = null;
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                string sql = "UPDATE BAN SET TRANGTHAI=N'Có người' WHERE STTBAN="+sttban+"";
                cmd.CommandText = System.String.Concat(sql);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                
            }
            catch (SqlException)
            {
                MessageBox.Show("Không cập nhật bàn chuyển được!!!");
            }
        }
    }
}
