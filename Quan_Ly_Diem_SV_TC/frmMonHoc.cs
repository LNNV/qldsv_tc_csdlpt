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
    public partial class frmMonHoc : Form
    {
        private int position = 0;
        private string option = "";
        private string oldMaMH = "";
        private string oldTenMH = "";
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void loadData()
        {
            this.mhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mhTableAdapter.Fill(this.DS.MONHOC);
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.LOPTINCHI' table. You can move, or remove it, as needed.
            this.ltcTableAdapter.Fill(this.DS.LOPTINCHI);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            loadData();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = true;
            btnUndo.Enabled = btnGhi.Enabled = false;
            gbMonHoc.Enabled = false;
            mhGridControl.Enabled = true;
        }

        private bool ValidateInfoMONHOC()
        {
            errorProvider.Clear();

            // TODO : Check khoảng trống ở textField
            if (txtMaMH.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtMaMH, "Mã môn học không được để trống!");
                return false;
            }
            if (txtTenMH.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtTenMH, "Tên môn học không được để trống");
                return false;
            }


            if (option == "add")
            {
                //TODO: Check mã môn học có tồn tại chưa
                string query1 = "DECLARE  @return_value int \n"
                            + "EXEC @return_value = SP_CHECKID \n"
                            + "@Code = N'" + txtMaMH.Text + "',@Type = N'MAMONHOC' \n"
                            + "SELECT 'Return Value' = @return_value";

                int resultMa = Program.CheckDataHelper(query1);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultMa == 1)
                {
                    this.errorProvider.SetError(txtMaMH, "Mã môn học đã tồn tại!");
                    return false;
                }

                // TODO : Check tên môn học có tồn tại chưa
                string query2 = "DECLARE  @return_value int \n"
                            + "EXEC @return_value = SP_CHECKNAME \n"
                            + "@Name = N'" + txtTenMH.Text + "',@Type = N'TENMONHOC' \n"
                            + "SELECT 'Return Value' = @return_value";

                int resultTen = Program.CheckDataHelper(query2);
                if (resultTen == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultTen == 1)
                {
                    this.errorProvider.SetError(txtTenMH, "Tên môn học đã tồn tại!");
                    return false;
                }
            }

            if (option == "update")
            {
                if (!this.txtMaMH.Text.Trim().ToString().Equals(oldMaMH))// Nếu mã môn học thay đổi so với ban đầu
                {
                    //TODO: Check mã môn học có tồn tại chưa
                    string query1 = "DECLARE  @return_value int \n"
                                + "EXEC @return_value = SP_CHECKID \n"
                                + "@Code = N'" + txtMaMH.Text + "',@Type = N'MAMONHOC' \n"
                                + "SELECT 'Return Value' = @return_value";

                    int resultMa = Program.CheckDataHelper(query1);
                    if (resultMa == -1)
                    {
                        MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultMa == 1)
                    {
                        this.errorProvider.SetError(txtMaMH, "Mã môn học đã tồn tại!");
                        return false;
                    }
                }
                if (!this.txtTenMH.Text.Trim().ToString().Equals(oldTenMH))// Nếu tên môn học thay đổi so với ban đầu
                {
                    // TODO : Check tên môn học có tồn tại chưa
                    string query2 = "DECLARE  @return_value int \n"
                                + "EXEC @return_value = SP_CHECKNAME \n"
                                + "@Name = N'" + txtTenMH.Text + "',@Type = N'TENMONHOC' \n"
                                + "SELECT 'Return Value' = @return_value";

                    int resultTen = Program.CheckDataHelper(query2);
                    if (resultTen == -1)
                    {
                        MessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultTen == 1)
                    {
                        this.errorProvider.SetError(txtTenMH, "Tên môn học đã tồn tại!");
                        return false;
                    }
                }
            }

            return true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            option = "add";

            btnGhi.Enabled = btnUndo.Enabled = true;
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = false;

            mhGridControl.Enabled = false;
            gbMonHoc.Enabled = true;

            bdsMH.AddNew();

            txtMaMH.Text = "";
            txtTenMH.Text = "";
            txtSoTietLT.Text = "0";
            txtSoTietTH.Text = "0";
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLTC.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì có lớp tín chỉ của môn học này.", "", MessageBoxButtons.OK);
                return;
            } else
            {
                try
                {
                    bdsMH.RemoveCurrent();
                    this.mhTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mhTableAdapter.Update(this.DS.MONHOC);
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.mhTableAdapter.Fill(this.DS.MONHOC);
                    return;
                }
                if (bdsMH.Count == 0) btnXoa.Enabled = false;
                btnLamMoi.Enabled = true;
                if (position > 0)
                {
                    bdsMH.Position = position;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            option = "update";
            oldMaMH = txtMaMH.Text.Trim();
            oldTenMH = txtTenMH.Text.Trim();

            position = bdsMH.Position;

            mhGridControl.Enabled = false;
            gbMonHoc.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mhGridControl.Enabled = true;
            if (option == "add") bdsMH.RemoveCurrent();
            bdsMH.CancelEdit();

            loadData();

            if (position > 0)
            {
                bdsLTC.Position = position;
            }

            gbMonHoc.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            option = "";
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = this.ValidateInfoMONHOC();
            //Console.WriteLine(check);
            if (check)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm == DialogResult.OK)
                {
                    try
                    {

                        bdsMH.EndEdit();
                        bdsMH.ResetCurrentItem();
                        this.mhTableAdapter.Connection.ConnectionString = Program.connstr;
                        mhTableAdapter.Update(this.DS.MONHOC);
                    }
                    catch (Exception ex)
                    {
                        //bdsLop.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnSua.Enabled = btnThoat.Enabled = true;
                    mhGridControl.Enabled = true;
                    btnGhi.Enabled = btnUndo.Enabled = false;
                    gbMonHoc.Enabled = false;
                    option = "";
                }
            }
            else
            {
                return;
            }
            if (position > 0) bdsMH.Position = position;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.mhTableAdapter.Fill(this.DS.MONHOC);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void mhGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //if (bdsMH.Position > 0) position = bdsMH.Position;
        }
    }
}
