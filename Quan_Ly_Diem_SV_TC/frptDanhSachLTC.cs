using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Diem_SV_TC
{
    public partial class frptDanhSachLTC : Form
    {
        private BindingSource bds_dspm = new BindingSource();
        public frptDanhSachLTC()
        {
            InitializeComponent();
        }

        private void frptDanhSachLTC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.NIENKHOA' table. You can move, or remove it, as needed.
            this.nkTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nkTableAdapter.Fill(this.DS.NIENKHOA);
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
                this.nkTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nkTableAdapter.Fill(this.DS.NIENKHOA);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            xrptDanhSachLTC rpt = new xrptDanhSachLTC(cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
            rpt.lblNienKhoa.Text = "Niên khóa: " + cmbNienKhoa.Text;
            rpt.lblHocKy.Text = "Học kỳ: " + cmbHocKy.Text;
            rpt.lblKhoa.Text = "KHOA: " + cmbKhoa.Text.ToUpper();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
