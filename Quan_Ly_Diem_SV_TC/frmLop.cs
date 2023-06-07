using DevExpress.XtraEditors.Controls;
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
    public partial class frmLop : Form
    {
        private BindingSource bds_dspm = new BindingSource();
        private int position = 0;
        private string makhoa = "";
        private string option = "";
        private string oldMaLop = "";
        private string oldTenLop = "";

        public frmLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void loadData()
        {
            DS.EnforceConstraints = false;
            this.lopTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sinhvienTableAdapter.Connection.ConnectionString = Program.connstr;

            this.lopTableAdapter.Fill(this.DS.LOP);
            this.sinhvienTableAdapter.Fill(this.DS.SINHVIEN);
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            
            loadData();
            errorProvider.Clear();
            this.bds_dspm.DataSource = Program.bds_dspm.DataSource;
            bds_dspm.Filter = "TENSERVER NOT LIKE '%SERVER3'";
            cmbKhoa.DataSource = bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA"; cmbKhoa.ValueMember = "TENSERVER";
            //cmbKhoa.SelectedIndex = 1;
            cmbKhoa.SelectedIndex = Program.khoaID;
            makhoa = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();
            if (Program.nhom == "PGV")
            {
                cmbKhoa.Enabled = true;  
            } else
            {
                cmbKhoa.Enabled = false;
            }
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
            btnUndo.Enabled = false;
            gbLop.Enabled = false;
            lopGridControl.Enabled = true;

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
            } else
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nốt về chi nhánh mới", "", MessageBoxButtons.OK);
            } else
            {
                loadData();
                makhoa = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            option = "add";

            position = bdsLop.Position;

            btnGhi.Enabled = btnUndo.Enabled = true;
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = false;
            cmbKhoa.Enabled = false;

            lopGridControl.Enabled = false;
            gbLop.Enabled = true;
            bdsLop.AddNew();
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtKhoaHoc.Text = "";
            txtMaKhoa.Text = makhoa;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lopGridControl.Enabled = true;
            if (option == "add") bdsLop.RemoveCurrent();
            bdsLop.CancelEdit();
            loadData();

            if (position > 0)
            {
                bdsLop.Position = position;
            }

            gbLop.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            option = "";
            cmbKhoa.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSV.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì Lớp đã có sinh viên.", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa Lớp này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsLop.RemoveCurrent();
                    this.lopTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lopTableAdapter.Update(this.DS.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Lớp.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.lopTableAdapter.Fill(this.DS.LOP);
                    return;
                }
            }
            if (bdsLop.Count == 0) btnXoa.Enabled = false;
            btnLamMoi.Enabled = true;
            if (position > 0)
            {
                bdsLop.Position = position;
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
                        
                        bdsLop.EndEdit();
                        bdsLop.ResetCurrentItem();
                        this.lopTableAdapter.Connection.ConnectionString = Program.connstr;
                        lopTableAdapter.Update(this.DS.LOP);
                    }
                    catch (Exception ex)
                    {
                        //bdsLop.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnSua.Enabled = btnThoat.Enabled = true;
                    lopGridControl.Enabled = true;
                    btnGhi.Enabled = btnUndo.Enabled = false;
                    gbLop.Enabled = false;
                    cmbKhoa.Enabled = true;
                    option = "";
                }
            }
            else
            {
                return;
            }
            if (position > 0) bdsLop.Position = position;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            option = "update";
            oldMaLop = txtMaLop.Text.Trim();
            oldTenLop = txtTenLop.Text.Trim();

            position = bdsLop.Position;

            lopGridControl.Enabled = false;
            gbLop.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled  = true;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = false;
            cmbKhoa.Enabled = false;
        }
        
        private bool validateInput()
        {
            
            errorProvider.Clear();
            if (txtMaLop.Text.Trim().Equals(""))
            {

                this.errorProvider.SetError(txtMaLop, "Mã lớp không được để trống !");
                return false;
            }
            if (txtTenLop.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtTenLop, "Tên lớp không được để trống !");
                return false;
            }
            if (txtKhoaHoc.Text.Trim().Equals(""))
            {
                this.errorProvider.SetError(txtKhoaHoc, "Khóa học không được để trống !");
                return false;
            }
            if (option == "add")
            {
                string query1 = "DECLARE  @return_value int \n"
                            + "EXEC  @return_value = SP_CHECKID \n"
                            + "@Code = N'" + txtMaLop.Text + "',@Type = N'MALOP' \n"
                            + "SELECT  'Return Value' = @return_value ";
                int resultMa = Program.CheckDataHelper(query1);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultMa == 1)
                {
                    this.errorProvider.SetError(txtMaLop, "Mã lớp đã tồn tại ở Khoa hiên tại !");
                    return false;
                }
                if (resultMa == 2)
                {
                    this.errorProvider.SetError(txtMaLop, "Mã lớp đã tồn tại ở Khoa khác !");
                    return false;
                }

                string query2 = "DECLARE @return_value int \n"
                               + "EXEC @return_value = SP_CHECKNAME \n"
                               + "@Name = N'" + txtTenLop.Text + "', @Type = N'TENLOP' \n"
                               + "SELECT 'Return Value' = @return_value ";
                int resultTen = Program.CheckDataHelper(query2);
                if (resultTen == -1)
                {
                    MessageBox.Show("Lỗi kết nối với Database. Mời bạn xem lại !", "", MessageBoxButtons.OK);
                    this.Close();
                }
                if (resultTen == 1)
                {
                    this.errorProvider.SetError(txtTenLop, "Tên lớp đã có rồi !");
                    return false;
                }
                if (resultTen == 2)
                {
                    this.errorProvider.SetError(txtTenLop, "Tên lớp đã tồn tại ở Khoa khác !");
                    return false;
                }
            }
            if (option == "update")
            {
                if (!this.txtMaLop.Text.Trim().ToString().Equals(oldMaLop))// Nếu mã lớp thay đổi so với ban đầu
                {
                    //TODO: Check mã lớp có tồn tại chưa
                    string query1 = "DECLARE  @return_value int \n"
                                + "EXEC  @return_value = SP_CHECKID \n"
                                + "@Code = N'" + txtMaLop.Text + "',@Type = N'MALOP' \n"
                                + "SELECT  'Return Value' = @return_value ";

                    int resultMa = Program.CheckDataHelper(query1);
                    if (resultMa == -1)
                    {
                        MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultMa == 1)
                    {
                        this.errorProvider.SetError(txtMaLop, "Mã lớp đã tồn tại ở Khoa hiên tại !");
                        return false;
                    }
                    if (resultMa == 2)
                    {
                        this.errorProvider.SetError(txtMaLop, "Mã lớp đã tồn tại ở Khoa khác !");
                        return false;
                    }
                }
                if (!this.txtTenLop.Text.Trim().ToString().Equals(oldTenLop))
                {
                    // TODO : Check tên lớp có tồn tại chưa
                    string query2 = "DECLARE @return_value int \n"
                                   + "EXEC @return_value = SP_CHECKNAME \n"
                                   + "@Name = N'" + txtTenLop.Text + "', @Type = N'TENLOP' \n"
                                   + "SELECT 'Return Value' = @return_value ";
                    int resultTen = Program.CheckDataHelper(query2);
                    if (resultTen == -1)
                    {
                        MessageBox.Show("Lỗi kết nối với Database. Mời bạn xem lại !", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    if (resultTen == 1)
                    {
                        this.errorProvider.SetError(txtTenLop, "Tên lớp đã có rồi !");
                        return false;
                    }
                    if (resultTen == 2)
                    {
                        this.errorProvider.SetError(txtTenLop, "Tên lớp đã tồn tại ở Khoa khác !");
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lopTableAdapter.Fill(this.DS.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void gridViewLop_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            
        }

        private void gridViewLop_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //if (bdsLop.Position > 0) position = bdsLop.Position;
        }
    }
}
