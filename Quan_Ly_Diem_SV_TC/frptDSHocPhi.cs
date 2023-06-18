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
    public partial class frptDSHocPhi : Form
    {
        public frptDSHocPhi()
        {
            InitializeComponent();
        }

        private void frptDSHocPhi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.NIENKHOAHOCPHI' table. You can move, or remove it, as needed.
            this.nkTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nkTableAdapter.Fill(this.DS.NIENKHOAHOCPHI);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lopTableAdapter.Fill(this.DS.LOP);
            cmbHocKy.SelectedIndex = 1;
            cmbHocKy.SelectedIndex = 0;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            String khoa = "";
            xrptDSHocPhi rpt = new xrptDSHocPhi(cmbLop.Text, cmbNienKhoa.Text, int.Parse(cmbHocKy.Text));
            //MessageBox.Show(cmbLop.SelectedValue.ToString());
            if (cmbLop.SelectedValue.ToString().Trim().Equals("CNTT")) khoa = "Công nghệ thông tin";
            else khoa = "Viễn thông";
            rpt.lblKhoa.Text = "KHOA: " + khoa.ToUpper();
            rpt.lbLop.Text = "MÃ LỚP: " + cmbLop.Text;
            rpt.lblNienKhoa.Text = "Niên khóa: " + cmbNienKhoa.Text;
            rpt.lblHocKy.Text = "Học kỳ: " + cmbHocKy.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
