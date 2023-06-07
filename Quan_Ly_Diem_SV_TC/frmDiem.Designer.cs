
namespace Quan_Ly_Diem_SV_TC
{
    partial class frmDiem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.bdsNK = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new Quan_Ly_Diem_SV_TC.DS();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.mhTableAdapter = new Quan_Ly_Diem_SV_TC.DSTableAdapters.MONHOCTableAdapter();
            this.SP_LAY_DS_LTCTableAdapter = new Quan_Ly_Diem_SV_TC.DSTableAdapters.SP_LAY_DS_LTCTableAdapter();
            this.tableAdapterManager = new Quan_Ly_Diem_SV_TC.DSTableAdapters.TableAdapterManager();
            this.nkTableAdapter = new Quan_Ly_Diem_SV_TC.DSTableAdapters.NIENKHOATableAdapter();
            this.bdsSP_LAY_DS_LTC = new System.Windows.Forms.BindingSource(this.components);
            this.SP_LAY_DS_LTCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DS_SV_LTCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_LAY_DS_LTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_LAY_DS_LTCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_SV_LTCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbNienKhoa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnGhi);
            this.panel1.Controls.Add(this.btnNhap);
            this.panel1.Controls.Add(this.btnBatDau);
            this.panel1.Controls.Add(this.cmbHocKy);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbKhoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 194);
            this.panel1.TabIndex = 0;
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataSource = this.bdsNK;
            this.cmbNienKhoa.DisplayMember = "NIENKHOA";
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(128, 77);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(372, 28);
            this.cmbNienKhoa.TabIndex = 13;
            this.cmbNienKhoa.ValueMember = "NIENKHOA";
            // 
            // bdsNK
            // 
            this.bdsNK.DataMember = "NIENKHOA";
            this.bdsNK.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Niên khóa";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1039, 23);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 32);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(914, 23);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(97, 32);
            this.btnGhi.TabIndex = 10;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(791, 23);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(97, 32);
            this.btnNhap.TabIndex = 9;
            this.btnNhap.Text = "Nhập điểm";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(637, 23);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(122, 32);
            this.btnBatDau.TabIndex = 8;
            this.btnBatDau.Text = "Tải lớp tín chỉ";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHocKy.Location = new System.Drawing.Point(128, 131);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(139, 28);
            this.cmbHocKy.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Học kỳ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khoa";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(128, 26);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(372, 28);
            this.cmbKhoa.TabIndex = 0;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.DS;
            // 
            // mhTableAdapter
            // 
            this.mhTableAdapter.ClearBeforeFill = true;
            // 
            // SP_LAY_DS_LTCTableAdapter
            // 
            this.SP_LAY_DS_LTCTableAdapter.ClearBeforeFill = true;
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
            // nkTableAdapter
            // 
            this.nkTableAdapter.ClearBeforeFill = true;
            // 
            // bdsSP_LAY_DS_LTC
            // 
            this.bdsSP_LAY_DS_LTC.DataMember = "SP_LAY_DS_LTC";
            this.bdsSP_LAY_DS_LTC.DataSource = this.DS;
            // 
            // SP_LAY_DS_LTCGridControl
            // 
            this.SP_LAY_DS_LTCGridControl.DataSource = this.bdsSP_LAY_DS_LTC;
            this.SP_LAY_DS_LTCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.SP_LAY_DS_LTCGridControl.Location = new System.Drawing.Point(0, 194);
            this.SP_LAY_DS_LTCGridControl.MainView = this.gridView1;
            this.SP_LAY_DS_LTCGridControl.Name = "SP_LAY_DS_LTCGridControl";
            this.SP_LAY_DS_LTCGridControl.Size = new System.Drawing.Size(1342, 220);
            this.SP_LAY_DS_LTCGridControl.TabIndex = 2;
            this.SP_LAY_DS_LTCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.SP_LAY_DS_LTCGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // DS_SV_LTCGridControl
            // 
            this.DS_SV_LTCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_SV_LTCGridControl.Location = new System.Drawing.Point(0, 414);
            this.DS_SV_LTCGridControl.MainView = this.gridView2;
            this.DS_SV_LTCGridControl.Name = "DS_SV_LTCGridControl";
            this.DS_SV_LTCGridControl.Size = new System.Drawing.Size(1342, 200);
            this.DS_SV_LTCGridControl.TabIndex = 3;
            this.DS_SV_LTCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.DS_SV_LTCGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanged);
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 635);
            this.Controls.Add(this.DS_SV_LTCGridControl);
            this.Controls.Add(this.SP_LAY_DS_LTCGridControl);
            this.Controls.Add(this.panel1);
            this.Name = "frmDiem";
            this.Text = "Điểm";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSP_LAY_DS_LTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_LAY_DS_LTCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_SV_LTCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label label5;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsMH;
        private DSTableAdapters.MONHOCTableAdapter mhTableAdapter;
        private DSTableAdapters.SP_LAY_DS_LTCTableAdapter SP_LAY_DS_LTCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsNK;
        private DSTableAdapters.NIENKHOATableAdapter nkTableAdapter;
        private System.Windows.Forms.BindingSource bdsSP_LAY_DS_LTC;
        private DevExpress.XtraGrid.GridControl SP_LAY_DS_LTCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl DS_SV_LTCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}