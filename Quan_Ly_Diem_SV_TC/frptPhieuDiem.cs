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
    public partial class frptPhieuDiem : Form
    {
        private BindingSource bds_dspm = new BindingSource();
        public frptPhieuDiem()
        {
            InitializeComponent();
        }

        private void frptPhieuDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sinhvienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sinhvienTableAdapter.Fill(this.dS.SINHVIEN);
            this.bds_dspm.DataSource = Program.bds_dspm.DataSource;
            bds_dspm.Filter = "TENSERVER NOT LIKE '%SERVER3'";
            cmbKhoa.DataSource = bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA"; cmbKhoa.ValueMember = "TENSERVER";
            //cmbKhoa.SelectedIndex = 1;
            cmbKhoa.SelectedIndex = Program.khoaID;
            if (Program.nhom == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
                if (Program.nhom == "SV")
                {
                    //lblSinhVien.Text = Program.hoten + "-" + Program.masv;
                    cmbMaSV.Text = Program.masv;
                    cmbMaSV.Enabled = false;
                }
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
                this.sinhvienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sinhvienTableAdapter.Fill(this.dS.SINHVIEN);
                cmbMaSV.Text = "[EditValue is null]";
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cmbMaSV.Text.Equals("[EditValue is null]"))
            {
                MessageBox.Show("Vui lòng chọn sinh viên!");
                return;
            }
            xrptPhieuDiem rpt = new xrptPhieuDiem(cmbMaSV.Text);
            rpt.lbHoTen.Text = Program.hoten;
            rpt.lbMaSV.Text = Program.masv;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
