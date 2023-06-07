using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Diem_SV_TC
{
    public partial class frmDangNhap : Form
    {

        private SqlConnection conn_publisher = new SqlConnection();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void dangNhapGV()
        {
            Program.mlogin = txtTaiKhoan.Text;
            Program.password = txtMatKhau.Text;
            Program.servername = cmbKhoa.SelectedValue.ToString();
            Program.khoaID = cmbKhoa.SelectedIndex;

            

            if (Program.KetNoi() == 0)
            {
                return;
            }

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            String strlenh = "exec SP_Lay_Thong_Tin_GV_Tu_Login '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            if (Program.myReader == null) return;

            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\nBạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                Program.hoten = Program.myReader.GetString(1);
                Program.nhom = Program.myReader.GetString(2);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("---> Lỗi: " + ex.ToString());
                MessageBox.Show("Login bạn nhập không có quyền truy cập vào chương trình", "", MessageBoxButtons.OK);
                return;
            }

            Program.myReader.Close();
            Program.conn.Close();

            Program.frmChinh.labelMaGV.Text = "MÃ GIẢNG VIÊN: " + Program.username.Trim();
            Program.frmChinh.labelHoTen.Text = "HỌ VÀ TÊN: " + Program.hoten.Trim();
            Program.frmChinh.labelNhom.Text = "NHÓM: " + Program.nhom.Trim();

            Program.frmChinh.btnTaoLogin.Enabled = true;

            if (Program.nhom == "PKT")
            {
                Program.frmChinh.btnLop.Enabled = false;
                Program.frmChinh.btnSinhVien.Enabled = false;
                Program.frmChinh.btnMonHoc.Enabled = false;
                Program.frmChinh.btnLTC.Enabled = false;
                Program.frmChinh.btnDiem.Enabled = false;
                Program.frmChinh.btnHocPhi.Enabled = true;
                Program.frmChinh.btnDangKyLTC.Enabled = false;
                Program.frmChinh.btnBangDiemLTC.Enabled = false;
                Program.frmChinh.btnDSLTC.Enabled = false;
                Program.frmChinh.btnDSSVLTC.Enabled = false;
                Program.frmChinh.btnPhieuDiem.Enabled = false;
                Program.frmChinh.btnDSHocPhi.Enabled = true;
                Program.frmChinh.btnDiemTongKet.Enabled = false;
                Program.frmChinh.btnDangXuat.Enabled = true;
                Program.frmChinh.btnDangNhap.Enabled = false;
            } else
            {
                Program.frmChinh.btnLop.Enabled = true;
                Program.frmChinh.btnSinhVien.Enabled = true;
                Program.frmChinh.btnMonHoc.Enabled = true;
                Program.frmChinh.btnLTC.Enabled = true;
                Program.frmChinh.btnDiem.Enabled = true;
                Program.frmChinh.btnHocPhi.Enabled = false;
                Program.frmChinh.btnDangKyLTC.Enabled = false;
                Program.frmChinh.btnBangDiemLTC.Enabled = true;
                Program.frmChinh.btnDSLTC.Enabled = true;
                Program.frmChinh.btnDSSVLTC.Enabled = true;
                Program.frmChinh.btnPhieuDiem.Enabled = true;
                Program.frmChinh.btnDSHocPhi.Enabled = false;
                Program.frmChinh.btnDiemTongKet.Enabled = true;
                Program.frmChinh.btnDangXuat.Enabled = true;
                Program.frmChinh.btnDangNhap.Enabled = false;
            }

            this.Close();
        }

        private void dangNhapSV()
        {
            Program.mlogin = "loginsv";
            Program.password = "1408";
            Program.servername = cmbKhoa.SelectedValue.ToString();

            if (Program.KetNoi() == 0)
            {
                return;
            }

            String strlenh = "exec SP_Lay_Thong_Tin_SV '" + txtTaiKhoan.Text + "', '" + txtMatKhau.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh);

            if (Program.myReader == null) return;

            Program.myReader.Read();
            try
            {
                Program.hoten = Program.myReader.GetString(0);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(strlenh);
                MessageBox.Show("Lỗi đăng nhập! \nKiểm tra lại mã sinh viên và mật khẩu.", "", MessageBoxButtons.OK);
                return;
            }


            Program.masv = txtTaiKhoan.Text.ToUpper();
            Program.passwordSV = txtMatKhau.Text;
            Program.nhom = "SV";

            Program.myReader.Close();
            Program.conn.Close();

            Program.frmChinh.labelMaGV.Text = "MÃ SINH VIÊN: " + Program.masv.Trim();
            Program.frmChinh.labelHoTen.Text = "HỌ VÀ TÊN: " + Program.hoten.Trim();
            Program.frmChinh.labelNhom.Text = "NHÓM: " + Program.nhom.Trim();

            Program.frmChinh.btnTaoLogin.Enabled = false;
            Program.frmChinh.btnLop.Enabled = false;
            Program.frmChinh.btnSinhVien.Enabled = false;
            Program.frmChinh.btnMonHoc.Enabled = false;
            Program.frmChinh.btnLTC.Enabled = false;
            Program.frmChinh.btnDiem.Enabled = false;
            Program.frmChinh.btnHocPhi.Enabled = false;
            Program.frmChinh.btnDangKyLTC.Enabled = true;
            Program.frmChinh.btnBangDiemLTC.Enabled = false;
            Program.frmChinh.btnDSLTC.Enabled = false;
            Program.frmChinh.btnDSSVLTC.Enabled = false;
            Program.frmChinh.btnPhieuDiem.Enabled = true;
            Program.frmChinh.btnDSHocPhi.Enabled = false;
            Program.frmChinh.btnDiemTongKet.Enabled = false;
            Program.frmChinh.btnDangXuat.Enabled = true;
            Program.frmChinh.btnDangNhap.Enabled = false;
            this.Close();
        }

        private void LayDSPM(string query)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA"; cmbKhoa.ValueMember = "TENSERVER";
        }

        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open) conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return 0;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("select * from Get_Subscribes");
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được trống", "Lỗi đăng nhập", MessageBoxButtons.OK);

                // trỏ con trỏ chuột về ô user...
                txtTaiKhoan.Focus();
                return;
            }
            if (cbSinhVien.Checked == true)
            {
                dangNhapSV();
                
            }
            else
            {
                dangNhapGV();
                
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSinhVien.Checked)
            {
                labelTaiKhoan.Text = "Mã sinh viên";
            } 
            else
            {
                labelTaiKhoan.Text = "Tài khoản";
            }
        }
    }
}
