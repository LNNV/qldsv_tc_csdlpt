using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmHocPhi : Form
    {
        private string option = "";
        private int position = 0;
        private int positionCT = 0;
        private int oldCTHP = 0;
        DataTable dt_sv = new DataTable();
        public frmHocPhi()
        {
            InitializeComponent();
        }

        private void LayDSSV()
        {
            String query = "Select MASV, HO, TEN from SINHVIEN";
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, Program.conn);
            da.Fill(dt_sv);
            cmbMaSV.DataSource = dt_sv;
            cmbMaSV.DisplayMember = "MASV"; cmbMaSV.ValueMember = "MASV";
            cmbMaSV.SelectedIndex = 1; cmbMaSV.SelectedIndex = 0;
        }

        private void loadData()
        {
            // TODO: This line of code loads data into the 'dS.CT_DONGHOCPHI' table. You can move, or remove it, as needed.
            this.cthpTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cthpTableAdapter.Fill(this.DS.CT_DONGHOCPHI);
            this.hpTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hpTableAdapter.Fill(this.DS.HOCPHI);
        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            
            loadData();
            LayDSSV();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
            btnUndo.Enabled = false;
            gbNhap.Enabled = false;
            hpGridControl.Enabled = true;
            cmbMaSV.Enabled = true;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaSV.SelectedValue.ToString() == "System.Data.DataRowView") return;
            foreach (DataRow row in dt_sv.Rows)
            {
                if (row["MASV"].ToString().Equals(cmbMaSV.SelectedValue.ToString()))
                {
                    labelTen.Text = row["HO"].ToString() + " " + row["TEN"].ToString();
                    break;
                }
            }
            bdsHP.Filter = "MASV LIKE '" + cmbMaSV.SelectedValue.ToString() + "'";
            //int i = 0;
            //foreach (DataRowView row in bdsHP)
            //{
            //    int daDong = 0;
            //    foreach(DataRowView rowCT in bdsCTHP)
            //    {
            //        if (row["MASV"].ToString().Equals(rowCT["MASV"].ToString()) && row["NIENKHOA"].ToString().Equals(rowCT["NIENKHOA"].ToString()) && row["HOCKY"].ToString().Equals(rowCT["HOCKY"].ToString()))
            //            daDong += int.Parse(rowCT["SOTIENDONG"].ToString());
            //    }

            //    hpGridView.SetRowCellValue(i, "DADONG", 0);
            //    hpGridView.SetRowCellValue(i, "CANDONG", int.Parse(row["HOCPHI"].ToString()) - daDong);

            //    i++;
            //}
            //MessageBox.Show(bdsHP.Count.ToString());
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Them
            option = "add";

            position = bdsHP.Position;

            btnGhi.Enabled = btnUndo.Enabled = true;
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = false;
            cmbMaSV.Enabled = false;

            hpGridControl.Enabled = false;
            gbNhap.Enabled = true;
            bdsHP.AddNew();
            txtNienKhoa.Text = "";
            cmbHocKy.SelectedIndex = 1;
            cmbHocKy.SelectedIndex = 0;
            txtMaSV.Text = cmbMaSV.Text;
            txtHocPhi.Text = "0";
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Thoat
            this.Close();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hpGridControl.Enabled = true;
            if (option == "add") bdsHP.RemoveCurrent();
            bdsHP.CancelEdit();
            loadData();

            if (position > 0)
            {
                bdsHP.Position = position;
            }

            gbNhap.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            option = "";
            cmbMaSV.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTHP.Count > 0)
            {
                MessageBox.Show("Không thể xóa học phí này vì đã có chi tết học phí.", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa học phí này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsHP.RemoveCurrent();
                    this.hpTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.hpTableAdapter.Update(this.DS.HOCPHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Lớp.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.hpTableAdapter.Fill(this.DS.HOCPHI);
                    return;
                }
            }
            if (bdsHP.Count == 0) btnXoa.Enabled = false;
            btnLamMoi.Enabled = true;
            if (position > 0)
            {
                bdsHP.Position = position;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = this.validateInput();
            //Console.WriteLine(check);
            if (check)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm == DialogResult.OK)
                {
                    try
                    {

                        bdsHP.EndEdit();
                        bdsHP.ResetCurrentItem();
                        this.hpTableAdapter.Connection.ConnectionString = Program.connstr;
                        hpTableAdapter.Update(this.DS.HOCPHI);
                    }
                    catch (Exception ex)
                    {
                        //bdsLop.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnSua.Enabled = btnThoat.Enabled = true;
                    hpGridControl.Enabled = true;
                    btnGhi.Enabled = btnUndo.Enabled = false;
                    gbNhap.Enabled = false;
                    cmbMaSV.Enabled = true;
                    option = "";
                }
            }
            else
            {
                return;
            }
            if (position > 0) bdsHP.Position = position;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            option = "update";
            //oldMaLop = txtMaLop.Text.Trim();
            //oldTenLop = txtTenLop.Text.Trim();

            position = bdsHP.Position;

            hpGridControl.Enabled = false;
            gbNhap.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = false;
            cmbMaSV.Enabled = false;
        }

        private bool validateInput()
        {
            //MessageBox.Show(position.ToString());
            if (txtHocPhi.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtHocPhi, "Học phí không được để trống !");
                return false;
            }
            if (txtNienKhoa.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtNienKhoa, "Niên khóa không được để trống !");
                return false;
            }
            int pos = 0;
            foreach (DataRowView row in bdsHP)
            {
                if (pos != bdsHP.Position)
                {
                    if (row["NIENKHOA"].ToString().Equals(txtNienKhoa.Text.Trim()) && row["HOCKY"].ToString().Equals(cmbHocKy.Text))
                    {
                        MessageBox.Show("Sinh viên này đã có học phí ở niên khóa và học kỳ này rồi!");
                        return false;
                    }
                }
                pos++;
            }
            return true;
        }

        private int getDaDong(GridView view, int i)
        {
            DataTable dt = new DataTable();
            string query = "select * from CT_DONGHOCPHI";
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, Program.conn);
            da.Fill(dt);
            int daDong = 0;
            DataRowView row = (DataRowView)bdsHP[i];
            foreach (DataRow rowCT in dt.Rows)
            {
                if (row["MASV"].ToString().Equals(rowCT["MASV"].ToString()) && row["NIENKHOA"].ToString().Equals(rowCT["NIENKHOA"].ToString()) && row["HOCKY"].ToString().Equals(rowCT["HOCKY"].ToString()))
                    daDong += int.Parse(rowCT["SOTIENDONG"].ToString());
            }
            return daDong;
        }

        private int getCanDong(GridView view, int i)
        {
            DataTable dt = new DataTable();
            string query = "select * from CT_DONGHOCPHI";
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, Program.conn);
            da.Fill(dt);
            int daDong = 0;
            DataRowView row = (DataRowView)bdsHP[i];
            foreach (DataRow rowCT in dt.Rows)
            {
                if (row["MASV"].ToString().Equals(rowCT["MASV"].ToString()) && row["NIENKHOA"].ToString().Equals(rowCT["NIENKHOA"].ToString()) && row["HOCKY"].ToString().Equals(rowCT["HOCKY"].ToString()))
                    daDong += int.Parse(rowCT["SOTIENDONG"].ToString());
            }
            if (String.IsNullOrEmpty(row["HOCPHI"].ToString())) return 0;
            return int.Parse(row["HOCPHI"].ToString()) - daDong;
        }


        private void hpGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "DADONG" && e.IsGetData)
                e.Value = getDaDong(view, e.ListSourceRowIndex);
            if (e.Column.FieldName == "CANDONG" && e.IsGetData)
                e.Value = getCanDong(view, e.ListSourceRowIndex);
        }

        private void btnThemCTHP_Click(object sender, EventArgs e)
        {
            cthpGridView.OptionsBehavior.ReadOnly = false;
            btnGhiCTHP.Enabled = btnUndoCTHP.Enabled = true;
            btnXoaCTHP.Enabled = btnThemCTHP.Enabled = btnSuaCTHP.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnUndo.Enabled = btnGhi.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = false;

            cmbMaSV.Enabled = false;

            hpGridControl.Enabled = false;

            bdsCTHP.AddNew();

            cthpGridView.SetFocusedRowCellValue("NGAYDONG", "");
            cthpGridView.SetFocusedRowCellValue("SOTIENDONG", "0");

            positionCT = bdsCTHP.Position;
        }

        private void btnSuaCTHP_Click(object sender, EventArgs e)
        {
            cthpGridView.OptionsBehavior.ReadOnly = false;
            option = "update";

            oldCTHP = int.Parse(this.cthpGridView.GetRowCellValue(positionCT, "SOTIENDONG").ToString());

            positionCT = bdsCTHP.Position;

            btnGhiCTHP.Enabled = btnUndoCTHP.Enabled = true;
            btnXoaCTHP.Enabled = btnThemCTHP.Enabled = btnSuaCTHP.Enabled = btnThoat.Enabled = false;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnUndo.Enabled = btnGhi.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = false;

            cmbMaSV.Enabled = false;
            hpGridControl.Enabled = false;
        }

        private void btnXoaCTHP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa chi tiết học phí này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsCTHP.RemoveCurrent();
                    this.cthpTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cthpTableAdapter.Update(this.DS.CT_DONGHOCPHI);
                    this.bdsCTHP.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                    hpGridView.RefreshRow(position);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa chi tiết học phí.\nBạn hãy xem lại\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private bool validateCT()
        {
            string date = this.cthpGridView.GetRowCellValue(positionCT, "NGAYDONG").ToString();
            string amount = this.cthpGridView.GetRowCellValue(positionCT, "SOTIENDONG").ToString();
            if (string.IsNullOrEmpty(date) || string.IsNullOrEmpty(amount))
            {
                MessageBox.Show("Field không được để trống!");
                return false;
            }
            if (amount.Equals("0"))
            {
                MessageBox.Show("Hãy nhập số tiền đóng");
                return false;
            }
            if (int.Parse(amount) > int.Parse(hpGridView.GetFocusedRowCellValue("CANDONG").ToString()) && !option.Equals("update")) {
                MessageBox.Show("Không thể đóng nhiều hơn số tiền cần đống");
                return false;
            }
            if (int.Parse(amount) - oldCTHP > int.Parse(hpGridView.GetFocusedRowCellValue("CANDONG").ToString()) && option.Equals("update"))
            {
                MessageBox.Show("Không thể đóng nhiều hơn số tiền cần đống");
                return false;
            }
            int i = 0;
            foreach (DataRowView row in bdsCTHP)
            {
                if (positionCT != i)
                {
                    if (date.Equals(row["NGAYDONG"]))
                    {
                        MessageBox.Show("Sinh viên đã đóng học phí của kỳ này niên khóa này vào ngày này rồi!");
                        return false;
                    }
                }
                i++;
            }
            return true;
        }

        private void btnGhiCTHP_Click(object sender, EventArgs e)
        {
            bool check = validateCT();
            if (check)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm == DialogResult.OK)
                {
                    try
                    {

                        bdsCTHP.EndEdit();
                        bdsCTHP.ResetCurrentItem();
                        this.cthpTableAdapter.Connection.ConnectionString = Program.connstr;
                        cthpTableAdapter.Update(this.DS.CT_DONGHOCPHI);
                        hpGridView.RefreshRow(position);
                        
                    }
                    catch (Exception ex)
                    {
                        //bdsLop.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    cthpGridView.OptionsBehavior.ReadOnly = true;

                    btnGhiCTHP.Enabled = btnUndoCTHP.Enabled = false;
                    btnXoaCTHP.Enabled = btnThemCTHP.Enabled = btnSuaCTHP.Enabled = btnThoat.Enabled = true;

                    btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnSua.Enabled = btnThoat.Enabled = true;
                    hpGridControl.Enabled = true;
                    btnGhi.Enabled = btnUndo.Enabled = false;
                    gbNhap.Enabled = false;
                    cmbMaSV.Enabled = true;
                    option = "";
                }
            }
            else return;
        }

        private void btnUndoCTHP_Click(object sender, EventArgs e)
        {
            cthpGridView.OptionsBehavior.ReadOnly = true;
            hpGridControl.Enabled = true;
            //if (option == "add") bdsLop.RemoveCurrent();
            bdsCTHP.CancelEdit();

            loadData();

            if (positionCT > 0)
            {
                bdsCTHP.Position = positionCT;
            }

            btnGhiCTHP.Enabled = btnUndoCTHP.Enabled = false;
            btnXoaCTHP.Enabled = btnThemCTHP.Enabled = btnSuaCTHP.Enabled = btnThoat.Enabled = true;

            gbNhap.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            option = "";
            cmbMaSV.Enabled = true;
        }

        private void cthpGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            positionCT = bdsCTHP.Position;
        }
    }
}
