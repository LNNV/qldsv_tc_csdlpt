using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Quan_Ly_Diem_SV_TC
{
    public partial class xrptPhieuDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public xrptPhieuDiem()
        {
            
        }
        public xrptPhieuDiem(string masv)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = masv;
            this.sqlDataSource1.Fill();
        }

    }
}
