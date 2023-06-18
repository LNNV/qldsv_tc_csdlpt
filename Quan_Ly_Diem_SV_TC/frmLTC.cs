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
    public partial class frmLTC : Form
    {

        private BindingSource bds_dspm = new BindingSource();
        private string option = "";
        private int position = 0;
        private string makhoa = "";
        public frmLTC()
        {
            InitializeComponent();
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLTC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void loadData()
        {

            this.gvTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gvTableAdapter.Fill(this.DS.GIANGVIEN);
            this.mhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mhTableAdapter.Fill(this.DS.MONHOC);
            this.ltcTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ltcTableAdapter.Fill(this.DS.LOPTINCHI);
            this.dkTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dkTableAdapter.Fill(this.DS.DANGKY);
        }

        private void frmLTC_Load(object sender, EventArgs e)
        {
            loadData();
            this.bds_dspm.DataSource = Program.bds_dspm.DataSource;
            bds_dspm.Filter = "TENSERVER NOT LIKE '%SERVER3'";
            cmbKhoa.DataSource = bds_dspm;
            cmbKhoa.DisplayMember = "TENKHOA"; cmbKhoa.ValueMember = "TENSERVER";
            //cmbKhoa.SelectedIndex = 1;
            cmbKhoa.SelectedIndex = Program.khoaID;
            makhoa = ((DataRowView)bdsLTC[0])["MAKHOA"].ToString();
            if (Program.nhom == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
            btnUndo.Enabled = false;
            gbLTC.Enabled = false;
            ltcGridControl.Enabled = true;
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
                makhoa = ((DataRowView)bdsLTC[0])["MAKHOA"].ToString();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            option = "add";

            position = bdsLTC.Position;


            btnGhi.Enabled = btnUndo.Enabled = true;
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = false;
            cmbKhoa.Enabled = false;

            ltcGridControl.Enabled = false;
            gbLTC.Enabled = true;
            bdsLTC.AddNew();
            txtNienKhoa.Text = "";
            //txtHocKy.Text = "1";
            txtNhom.Text = "1";
            txtSVToiThieu.Text = "1";
            cmbHocKy.SelectedIndex = 1;
            cmbHocKy.SelectedIndex = 0;
            //cmbMaMH.SelectedIndex = 1;
            //cmbMaMH.SelectedIndex = 0;
            cmbMaMH.ItemIndex = 0;
            cmbMaGV.SelectedIndex = 1;
            cmbMaGV.SelectedIndex = 0;
            huyCheckEdit.Checked = false;
            huyCheckEdit.Enabled = false;
            txtMaKhoa.Text = makhoa;
            
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            errorProvider.Clear();
            ltcGridControl.Enabled = true;
            if (option == "add") bdsLTC.RemoveCurrent();

            bdsLTC.CancelEdit();

            loadData();

            if (position > 0)
            {
                bdsLTC.Position = position;
            }

            gbLTC.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            huyCheckEdit.Enabled = false;
            option = "";
            cmbKhoa.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp tín chỉ này vì Lớp đã có sinh viên đăng ký.", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa Lớp tín chỉ này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsLTC.RemoveCurrent();
                    this.ltcTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.ltcTableAdapter.Update(this.DS.LOPTINCHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Lớp.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.ltcTableAdapter.Fill(this.DS.LOPTINCHI);
                    return;
                }
            }
            if (bdsLTC.Count == 0) btnXoa.Enabled = false;
            btnLamMoi.Enabled = true;
            if (position > 0)
            {
                bdsLTC.Position = position;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            option = "update";

            position = bdsLTC.Position;

            ltcGridControl.Enabled = false;
            gbLTC.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = false;
            huyCheckEdit.Enabled = true;
            cmbKhoa.Enabled = false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                errorProvider.Clear();
                this.ltcTableAdapter.Fill(this.DS.LOPTINCHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
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

                        bdsLTC.EndEdit();
                        bdsLTC.ResetCurrentItem();
                        this.ltcTableAdapter.Connection.ConnectionString = Program.connstr;
                        ltcTableAdapter.Update(this.DS.LOPTINCHI);
                    }
                    catch (Exception ex)
                    {
                        //bdsLop.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnSua.Enabled = btnThoat.Enabled = true;
                    ltcGridControl.Enabled = true;
                    btnGhi.Enabled = btnUndo.Enabled = false;
                    gbLTC.Enabled = false;
                    cmbKhoa.Enabled = true;
                    huyCheckEdit.Enabled = false;
                    option = "";
                    errorProvider.Clear();
                }
                else return;
            }
            else
            {
                return;
            }
            if (position > 0) bdsLTC.Position = position;
        }

        private bool validateInput()
        {
            errorProvider.Clear();
            txtNienKhoa.Focus();
            if (txtNienKhoa.Text.Trim().Equals(""))
            {

                this.errorProvider.SetError(txtNienKhoa, "Mã lớp không được để trống !");
                return false;
            }
            int i = 0;
            //MessageBox.Show(txtNhom.Text.ToString().Trim());
            foreach (DataRowView dataRowView in bdsLTC)
            {
                if (dataRowView["NIENKHOA"].ToString().Equals(txtNienKhoa.Text.Trim()) &&
                    dataRowView["HOCKY"].ToString().Equals(cmbHocKy.SelectedItem.ToString()) &&
                    dataRowView["MAMH"].ToString().Trim().Equals(cmbMaMH.Text.ToString().Trim()) &&
                    dataRowView["NHOM"].ToString().Equals(txtNhom.Text.Trim()) &&
                    dataRowView["HUYLOP"].Equals(false) && i != bdsLTC.Position)
                {
                    //MessageBox.Show(dataRowView["NIENKHOA"].ToString());
                    //MessageBox.Show(dataRowView["HOCKY"].ToString());
                    //MessageBox.Show(dataRowView["MAMH"].ToString());
                    //MessageBox.Show(dataRowView["MAGV"].ToString());
                    //MessageBox.Show(dataRowView["NHOM"].ToString());
                    MessageBox.Show("Lớp tín chỉ này đã được đăng ký!", "", MessageBoxButtons.OK);
                    return false;
                }
                i++;
            }
            return true;
        }

        private void ltcGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //if (bdsLTC.Position > 0) position = bdsLTC.Position;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
