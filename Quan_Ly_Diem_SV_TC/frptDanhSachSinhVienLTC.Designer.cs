
namespace Quan_Ly_Diem_SV_TC
{
    partial class frptDanhSachSinhVienLTC
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
            this.btnXem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new Quan_Ly_Diem_SV_TC.DS();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.txtNhom = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.bdsNK = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.mhTableAdapter = new Quan_Ly_Diem_SV_TC.DSTableAdapters.MONHOCTableAdapter();
            this.nkTableAdapter = new Quan_Ly_Diem_SV_TC.DSTableAdapters.NIENKHOATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNK)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(431, 202);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(179, 41);
            this.btnXem.TabIndex = 43;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Môn học";
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataSource = this.bdsMH;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(644, 87);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(257, 28);
            this.cmbMonHoc.TabIndex = 41;
            this.cmbMonHoc.ValueMember = "MAMH";
            this.cmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbMonHoc_SelectedIndexChanged);
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Location = new System.Drawing.Point(929, 96);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(51, 20);
            this.lblMaMH.TabIndex = 40;
            this.lblMaMH.Text = "label2";
            // 
            // txtNhom
            // 
            this.txtNhom.Location = new System.Drawing.Point(644, 135);
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtNhom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtNhom.Properties.Mask.EditMask = "F0";
            this.txtNhom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNhom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNhom.Size = new System.Drawing.Size(150, 28);
            this.txtNhom.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nhóm";
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.DataSource = this.bdsNK;
            this.cmbNienKhoa.DisplayMember = "NIENKHOA";
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(204, 89);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(217, 28);
            this.cmbNienKhoa.TabIndex = 37;
            this.cmbNienKhoa.ValueMember = "NIENKHOA";
            // 
            // bdsNK
            // 
            this.bdsNK.DataMember = "NIENKHOA";
            this.bdsNK.DataSource = this.DS;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Niên khóa";
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHocKy.Location = new System.Drawing.Point(204, 143);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(217, 28);
            this.cmbHocKy.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Học kỳ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Khoa";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(369, 25);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(372, 28);
            this.cmbKhoa.TabIndex = 32;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // mhTableAdapter
            // 
            this.mhTableAdapter.ClearBeforeFill = true;
            // 
            // nkTableAdapter
            // 
            this.nkTableAdapter.ClearBeforeFill = true;
            // 
            // frptDanhSachSinhVienLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 549);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.lblMaMH);
            this.Controls.Add(this.txtNhom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbNienKhoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbHocKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKhoa);
            this.Name = "frptDanhSachSinhVienLTC";
            this.Text = "Xem danh sách sinh viên lớp tín chỉ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frptDanhSachSinhVienLTC_FormClosing);
            this.Load += new System.EventHandler(this.frptDanhSachSinhVienLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.Label lblMaMH;
        private DevExpress.XtraEditors.TextEdit txtNhom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsMH;
        private DSTableAdapters.MONHOCTableAdapter mhTableAdapter;
        private System.Windows.Forms.BindingSource bdsNK;
        private DSTableAdapters.NIENKHOATableAdapter nkTableAdapter;
    }
}