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
    public partial class frmDiem : Form
    {
        private String maLTC = "";
        private BindingSource bds_dspm = new BindingSource();
        private DataTable dt_sv_ltc = new DataTable();

        public frmDiem()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            // TODO: This line of code loads data into the 'dS.NIENKHOA' table. You can move, or remove it, as needed.
            this.nkTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nkTableAdapter.Fill(this.DS.NIENKHOA);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.

            this.mhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mhTableAdapter.Fill(this.DS.MONHOC);
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            loadData();
            this.bds_dspm.DataSource = Program.bds_dspm.DataSource;
            bds_dspm.Filter = "TENSERVER NOT LIKE '%SERVER3'";
            cmbKhoa.DataSource = bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA"; cmbKhoa.ValueMember = "TENSERVER";
            //cmbKhoa.SelectedIndex = 1;
            cmbKhoa.SelectedIndex = Program.khoaID;
            cmbHocKy.SelectedIndex = 0;
            if (Program.nhom == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return;

            Program.servername = cmbKhoa.SelectedValue.ToString();
            Console.WriteLine(Program.servername);

            if (Program.khoaID == cmbKhoa.SelectedIndex)
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            else
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nốt về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                loadData();
            }
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            try
            {
                this.SP_LAY_DS_LTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SP_LAY_DS_LTCTableAdapter.Fill(this.DS.SP_LAY_DS_LTC, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
                //MessageBox.Show(cmbNienKhoa.Text + " " + cmbHocKy.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            maLTC = ((DataRowView)bdsSP_LAY_DS_LTC[bdsSP_LAY_DS_LTC.Position])["MALTC"].ToString();
            string strlenh = "exec SP_LAY_DS_SV_LTC " + maLTC;
            dt_sv_ltc = Program.ExecSqlDataTable(strlenh);
            dt_sv_ltc.Columns.Add("DIEM_HM");

            foreach (DataRow row in dt_sv_ltc.Rows)
            {
                float cc = 0, gk = 0, ck = 0;
                bool check = false;
                if (row["DIEM_CC"].ToString() != "")
                {
                    cc = float.Parse(row["DIEM_CC"].ToString());
                    check = true;
                }
                if (row["DIEM_GK"].ToString() != "")
                {
                    gk = float.Parse(row["DIEM_GK"].ToString());
                    check = true;
                }
                if (row["DIEM_CK"].ToString() != "")
                {
                    ck = float.Parse(row["DIEM_CK"].ToString());
                    check = true;
                }
                if (check)
                {
                    float hm = (float)(cc * 0.1 + gk * 0.3 + ck * 0.6);
                    row["DIEM_HM"] = hm;
                }
            }
            foreach (DataColumn col in dt_sv_ltc.Columns)
            {
                if (col.ColumnName.Equals("MASV") || col.ColumnName.Equals("HOTENSV") || col.ColumnName.Equals("DIEM_HM"))
                    col.ReadOnly = true;
            }
            DS_SV_LTCGridControl.DataSource = dt_sv_ltc;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALTC", typeof(int));
            dt.Columns.Add("MASV", typeof(string));
            dt.Columns.Add("DIEM_CC", typeof(float));
            dt.Columns.Add("DIEM_GK", typeof(float));
            dt.Columns.Add("DIEM_CK", typeof(float));
            int maLTC_int = int.Parse(maLTC);
            foreach (DataRow dataRow in dt_sv_ltc.Rows)
            {
                dt.Rows.Add(maLTC_int, dataRow["MASV"], dataRow["DIEM_CC"], dataRow["DIEM_GK"], dataRow["DIEM_CK"]);
            }
            try
            {
                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Structured;
                para.TypeName = "dbo.TYPE_DANGKY";
                para.ParameterName = "@DIEMTHI";
                para.Value = dt;
                Program.KetNoi();

                SqlCommand sqlcmd = new SqlCommand("SP_UPDATE_DIEM", Program.conn);
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(para);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Nhập điểm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            foreach (DataColumn col in dt_sv_ltc.Columns)
            {
                if (col.ColumnName.Equals("DIEM_HM"))
                    col.ReadOnly = false;
            }
            foreach (DataRow row in dt_sv_ltc.Rows)
            {
                float cc = 0, gk = 0, ck = 0;
                bool check = false;
                if (row["DIEM_CC"].ToString() != "")
                {
                    cc = float.Parse(row["DIEM_CC"].ToString());
                    check = true;
                }
                if (row["DIEM_GK"].ToString() != "")
                {
                    gk = float.Parse(row["DIEM_GK"].ToString());
                    check = true;
                }
                if (row["DIEM_CK"].ToString() != "")
                {
                    ck = float.Parse(row["DIEM_CK"].ToString());
                    check = true;
                }
                if (check)
                {
                    float hm = (float)(cc * 0.1 + gk * 0.3 + ck * 0.6);
                    row["DIEM_HM"] = hm;
                }
            }
            foreach (DataColumn col in dt_sv_ltc.Columns)
            {
                if (col.ColumnName.Equals("DIEM_HM"))
                    col.ReadOnly = true;
            }
        }
    }
}
