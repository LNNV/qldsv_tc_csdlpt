
namespace Quan_Ly_Diem_SV_TC
{
    partial class frmDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mALTCLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaiLTC = new System.Windows.Forms.Button();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.bdsNienKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new Quan_Ly_Diem_SV_TC.DS();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nienkhoaTableAdapter = new Quan_Ly_Diem_SV_TC.DSTableAdapters.NIENKHOATableAdapter();
            this.tableAdapterManager = new Quan_Ly_Diem_SV_TC.DSTableAdapters.TableAdapterManager();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.bdsDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.dangkyTableAdapter = new Quan_Ly_Diem_SV_TC.DSTableAdapters.DANGKYTableAdapter();
            this.bdsSP_SV_LAY_DS_LTC = new System.Windows.Forms.BindingSource(this.components);
            this.SP_SV_LAY_DS_LTCTableAdapter = new Quan_Ly_Diem_SV_TC.DSTableAdapters.SP_SV_LAY_DS_LTCTableAdapter();
            this.SP_SV_LAY_DS_LTCGridControl = new DevExpress.XtraGrid.GridControl();
            this.SP_SV_LAY_DS_LTCGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtMaLTC = new System.Windows.Forms.TextBox();
            mALTCLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNienKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_SV_LAY_DS_LTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_SV_LAY_DS_LTCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_SV_LAY_DS_LTCGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mALTCLabel
            // 
            mALTCLabel.AutoSize = true;
            mALTCLabel.Location = new System.Drawing.Point(66, 378);
            mALTCLabel.Name = "mALTCLabel";
            mALTCLabel.Size = new System.Drawing.Size(105, 20);
            mALTCLabel.TabIndex = 5;
            mALTCLabel.Text = "Mã lớp tín chỉ:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMaLop);
            this.panel1.Controls.Add(this.lblHoTen);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnTaiLTC);
            this.panel1.Controls.Add(this.cmbHocKy);
            this.panel1.Controls.Add(this.cmbNienKhoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1396, 122);
            this.panel1.TabIndex = 0;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(96, 54);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(51, 20);
            this.lblMaLop.TabIndex = 14;
            this.lblMaLop.Text = "label6";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(95, 20);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(51, 20);
            this.lblHoTen.TabIndex = 13;
            this.lblHoTen.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Họ và tên";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(898, 54);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 28);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaiLTC
            // 
            this.btnTaiLTC.Location = new System.Drawing.Point(879, 14);
            this.btnTaiLTC.Name = "btnTaiLTC";
            this.btnTaiLTC.Size = new System.Drawing.Size(113, 32);
            this.btnTaiLTC.TabIndex = 9;
            this.btnTaiLTC.Text = "Tải lớp tín chỉ";
            this.btnTaiLTC.UseVisualStyleBackColor = true;
            this.btnTaiLTC.Click += new System.EventHandler(this.btnTaiLTC_Click);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHocKy.Location = new System.Drawing.Point(613, 54);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(243, 28);
            this.cmbHocKy.TabIndex = 3;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataSource = this.bdsNienKhoa;
            this.cmbNienKhoa.DisplayMember = "NIENKHOA";
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(613, 17);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(243, 28);
            this.cmbNienKhoa.TabIndex = 2;
            this.cmbNienKhoa.ValueMember = "NIENKHOA";
            // 
            // bdsNienKhoa
            // 
            this.bdsNienKhoa.DataMember = "NIENKHOA";
            this.bdsNienKhoa.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Học kỳ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Niên khóa";
            // 
            // nienkhoaTableAdapter
            // 
            this.nienkhoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Quan_Ly_Diem_SV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(451, 372);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(122, 33);
            this.btnDangKy.TabIndex = 4;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // bdsDangKy
            // 
            this.bdsDangKy.DataMember = "DANGKY";
            this.bdsDangKy.DataSource = this.DS;
            // 
            // dangkyTableAdapter
            // 
            this.dangkyTableAdapter.ClearBeforeFill = true;
            // 
            // bdsSP_SV_LAY_DS_LTC
            // 
            this.bdsSP_SV_LAY_DS_LTC.DataMember = "SP_SV_LAY_DS_LTC";
            this.bdsSP_SV_LAY_DS_LTC.DataSource = this.DS;
            // 
            // SP_SV_LAY_DS_LTCTableAdapter
            // 
            this.SP_SV_LAY_DS_LTCTableAdapter.ClearBeforeFill = true;
            // 
            // SP_SV_LAY_DS_LTCGridControl
            // 
            this.SP_SV_LAY_DS_LTCGridControl.DataSource = this.bdsSP_SV_LAY_DS_LTC;
            this.SP_SV_LAY_DS_LTCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.SP_SV_LAY_DS_LTCGridControl.Location = new System.Drawing.Point(0, 122);
            this.SP_SV_LAY_DS_LTCGridControl.MainView = this.SP_SV_LAY_DS_LTCGridView;
            this.SP_SV_LAY_DS_LTCGridControl.Name = "SP_SV_LAY_DS_LTCGridControl";
            this.SP_SV_LAY_DS_LTCGridControl.Size = new System.Drawing.Size(1396, 220);
            this.SP_SV_LAY_DS_LTCGridControl.TabIndex = 5;
            this.SP_SV_LAY_DS_LTCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SP_SV_LAY_DS_LTCGridView});
            // 
            // SP_SV_LAY_DS_LTCGridView
            // 
            this.SP_SV_LAY_DS_LTCGridView.GridControl = this.SP_SV_LAY_DS_LTCGridControl;
            this.SP_SV_LAY_DS_LTCGridView.Name = "SP_SV_LAY_DS_LTCGridView";
            this.SP_SV_LAY_DS_LTCGridView.OptionsBehavior.ReadOnly = true;
            // 
            // txtMaLTC
            // 
            this.txtMaLTC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSP_SV_LAY_DS_LTC, "MALTC", true));
            this.txtMaLTC.Location = new System.Drawing.Point(177, 375);
            this.txtMaLTC.Name = "txtMaLTC";
            this.txtMaLTC.ReadOnly = true;
            this.txtMaLTC.Size = new System.Drawing.Size(251, 26);
            this.txtMaLTC.TabIndex = 6;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 543);
            this.Controls.Add(mALTCLabel);
            this.Controls.Add(this.txtMaLTC);
            this.Controls.Add(this.SP_SV_LAY_DS_LTCGridControl);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.panel1);
            this.Name = "frmDangKy";
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNienKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_SV_LAY_DS_LTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_SV_LAY_DS_LTCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_SV_LAY_DS_LTCGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsNienKhoa;
        private DSTableAdapters.NIENKHOATableAdapter nienkhoaTableAdapter;
        private System.Windows.Forms.Button btnTaiLTC;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.BindingSource bdsDangKy;
        private DSTableAdapters.DANGKYTableAdapter dangkyTableAdapter;
        private System.Windows.Forms.BindingSource bdsSP_SV_LAY_DS_LTC;
        private DSTableAdapters.SP_SV_LAY_DS_LTCTableAdapter SP_SV_LAY_DS_LTCTableAdapter;
        private DevExpress.XtraGrid.GridControl SP_SV_LAY_DS_LTCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView SP_SV_LAY_DS_LTCGridView;
        private System.Windows.Forms.TextBox txtMaLTC;
    }
}