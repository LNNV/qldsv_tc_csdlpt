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

namespace Quan_Ly_Diem_SV_TC
{
    public partial class frmDangKy : Form
    {
        string malop = "";
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.DANGKY' table. You can move, or remove it, as needed.
            this.dangkyTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dangkyTableAdapter.Fill(this.DS.DANGKY);
            // TODO: This line of code loads data into the 'dS.NIENKHOA' table. You can move, or remove it, as needed.
            this.nienkhoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nienkhoaTableAdapter.Fill(this.DS.NIENKHOA);
            lblHoTen.Text = Program.hoten;
            String strlenh = "select MALOP from SINHVIEN where MASV='" + Program.masv + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh);

            if (Program.myReader == null) return;

            Program.myReader.Read();
            try
            {
                malop = Program.myReader.GetString(0);

            }
            catch (Exception ex)
            {
                //MessageBox.Show(strlenh);
                MessageBox.Show("Lỗi lấy thông tin sinh viên!", "", MessageBoxButtons.OK);
                return;
            }
            Program.myReader.Close();
            Program.conn.Close();
            lblMaLop.Text = malop;
        }


        private void btnTaiLTC_Click(object sender, EventArgs e)
        {
            try
            {
                this.SP_SV_LAY_DS_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SP_SV_LAY_DS_LTCTableAdapter.Fill(this.DS.SP_SV_LAY_DS_LTC, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtMaLTC.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn lớp tín chỉ!");
                return;
            }
           foreach (DataRowView row in bdsDangKy)
           {
                if (row["MALTC"].ToString().Equals(txtMaLTC.Text.Trim()) && row["MASV"].ToString().Equals(Program.masv))
                {
                    MessageBox.Show("Bạn đã đăng ký lớp tín chỉ này rồi!");
                    return;
                }
           }
           if (MessageBox.Show("Xác nhận đăng ký", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
           {
                try
                {
                    SqlParameter maltcPara = new SqlParameter();
                    maltcPara.SqlDbType = SqlDbType.Int;
                    maltcPara.ParameterName = "@maltc";
                    maltcPara.Value = int.Parse(txtMaLTC.Text.Trim());
                    SqlParameter masvPara = new SqlParameter();
                    masvPara.SqlDbType = SqlDbType.NChar;
                    masvPara.ParameterName = "@masv";
                    masvPara.Value = Program.masv;
                    Program.KetNoi();
                    SqlCommand sqlcmd = new SqlCommand("SP_DANG_KY_LTC", Program.conn);
                    sqlcmd.Parameters.Clear();
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(maltcPara);
                    sqlcmd.Parameters.Add(masvPara);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký thành công!");
                    this.dangkyTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dangkyTableAdapter.Fill(this.DS.DANGKY);
                    this.SP_SV_LAY_DS_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SP_SV_LAY_DS_LTCTableAdapter.Fill(this.DS.SP_SV_LAY_DS_LTC, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
           } 
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
