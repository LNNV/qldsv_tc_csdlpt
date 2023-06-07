﻿using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Quan_Ly_Diem_SV_TC
{
    public partial class xrptDanhSachLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public xrptDanhSachLTC()
        {
        }
        public xrptDanhSachLTC(string nienKhoa, int hocKy)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKy;
        }

    }
}
