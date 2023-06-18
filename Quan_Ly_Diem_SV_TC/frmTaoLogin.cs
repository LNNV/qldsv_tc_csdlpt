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
    public partial class frmTaoLogin : Form
    {
        public frmTaoLogin()
        {
            InitializeComponent();
        }

        private void LayDSNhom()
        {
            List<String> listNhom = new List<string>();
            if (Program.nhom == "PGV")
            {
                listNhom.Add("PGV");
                listNhom.Add("KHOA");
            }
            if (Program.nhom == "KHOA")
            {
                listNhom.Add("KHOA");
            }
            if (Program.nhom == "PKT")
            {
                listNhom.Add("PKT");
            }
            cmbNhom.DataSource = listNhom;
        }

        //private void LayDSMaGV(String query)
        //{
        //    DataTable dt = new DataTable();
        //    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
        //    SqlDataAdapter da = new SqlDataAdapter(query, Program.conn);
        //    da.Fill(dt);
        //    BindingSource bds = new BindingSource();
        //    bds.DataSource = dt;
        //    cmbMaGV.DataSource = bds;
        //    cmbMaGV.DisplayMember = "MAGV"; cmbMaGV.ValueMember = "MAGV";
        //}

        private void frmTaoLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
            LayDSNhom();
            //LayDSMaGV("Select MAGV from GIANGVIEN");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            String login = txtTaiKhoan.Text;
            String pass = txtPass.Text;
            String rePass = txtRePass.Text;
            String user = cmbMaGV.Text;
            String role = cmbNhom.SelectedItem.ToString();
            //MessageBox.Show(login + "\n" + pass + "\n" + user + "\n" + role);

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Vui lòng nhập tài khoản!");
                txtTaiKhoan.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                txtPass.Focus();
                return;
            }

            if (!pass.Equals(rePass))
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
                txtPass.Focus();
                return;
            }

            if (user.Equals("[EditValue is null]"))
            {
                MessageBox.Show("Vui lòng chọn giảng viên!");
                return;
            }

            String subLenh = " EXEC    @return_value = [dbo].[SP_TAOLOGIN] " +
                            " @LGNAME = N'" + login + "', " +
                            " @PASS = N'" + pass + "', " +
                            " @USERNAME = N'" + user + "', " +
                            " @ROLE = N'" + role + "' ";

            String strLenh = " DECLARE @return_value int " + subLenh +
                         " SELECT  'Return Value' = @return_value ";

            SqlDataReader dataReader = Program.ExecSqlDataReader(strLenh);
            int resultCheckLogin;

            if (dataReader == null) resultCheckLogin = -1;
            else
            {
                dataReader.Read();
                resultCheckLogin = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();
            }

            if (resultCheckLogin == -1)
            {
                MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (resultCheckLogin == 1)
            {
                MessageBox.Show("Tài khoản bị trùng !", "", MessageBoxButtons.OK);
            }
            else if (resultCheckLogin == 2)
            {
                MessageBox.Show("Giảng viên đã có tài khoản", "", MessageBoxButtons.OK);

            }
            else if (resultCheckLogin == 3)
            {
                MessageBox.Show("Lỗi thực thi trong cơ sơ dữ liệu !", "", MessageBoxButtons.OK);
            }
            else if (resultCheckLogin == 0)
            {
                MessageBox.Show("Tạo tài khoản thành công !", "", MessageBoxButtons.OK);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
