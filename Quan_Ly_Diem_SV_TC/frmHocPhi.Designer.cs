
namespace Quan_Ly_Diem_SV_TC
{
    partial class frmHocPhi
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
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label hOCPHILabel;
            System.Windows.Forms.Label mASVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocPhi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.DS = new Quan_Ly_Diem_SV_TC.DS();
            this.tableAdapterManager = new Quan_Ly_Diem_SV_TC.DSTableAdapters.TableAdapterManager();
            this.hpTableAdapter = new Quan_Ly_Diem_SV_TC.DSTableAdapters.HOCPHITableAdapter();
            this.bdsHP = new System.Windows.Forms.BindingSource(this.components);
            this.hpGridControl = new DevExpress.XtraGrid.GridControl();
            this.hpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCANDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cthpGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextCTHP = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemCTHP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaCTHP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaCTHP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUndoCTHP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiCTHP = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsCTHP = new System.Windows.Forms.BindingSource(this.components);
            this.cthpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbNhap = new System.Windows.Forms.GroupBox();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.txtHocPhi = new DevExpress.XtraEditors.TextEdit();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.cthpTableAdapter = new Quan_Ly_Diem_SV_TC.DSTableAdapters.CT_DONGHOCPHITableAdapter();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            hOCPHILabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cthpGridControl)).BeginInit();
            this.contextCTHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cthpGridView)).BeginInit();
            this.gbNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(12, 28);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(96, 20);
            nIENKHOALabel.TabIndex = 0;
            nIENKHOALabel.Text = "NIENKHOA:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(39, 62);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(69, 20);
            hOCKYLabel.TabIndex = 2;
            hOCKYLabel.Text = "HOCKY:";
            // 
            // hOCPHILabel
            // 
            hOCPHILabel.AutoSize = true;
            hOCPHILabel.Enabled = false;
            hOCPHILabel.Location = new System.Drawing.Point(33, 96);
            hOCPHILabel.Name = "hOCPHILabel";
            hOCPHILabel.Size = new System.Drawing.Size(75, 20);
            hOCPHILabel.TabIndex = 4;
            hOCPHILabel.Text = "HOCPHI:";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(49, 130);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(59, 20);
            mASVLabel.TabIndex = 6;
            mASVLabel.Text = "MASV:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTen);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.cmbMaSV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 100);
            this.panel1.TabIndex = 0;
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Location = new System.Drawing.Point(182, 60);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(0, 20);
            this.labelTen.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(78, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã sinh viên";
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(182, 25);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(284, 28);
            this.cmbMaSV.TabIndex = 0;
            this.cmbMaSV.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnGhi,
            this.btnUndo,
            this.btnLamMoi,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Enabled = false;
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Enabled = false;
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Enabled = false;
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Enabled = false;
            this.btnUndo.Id = 5;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Enabled = false;
            this.btnLamMoi.Id = 6;
            this.btnLamMoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLamMoi.ImageOptions.SvgImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1267, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 623);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1267, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 589);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1267, 34);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(0, 589);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = this.hpTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Quan_Ly_Diem_SV_TC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hpTableAdapter
            // 
            this.hpTableAdapter.ClearBeforeFill = true;
            // 
            // bdsHP
            // 
            this.bdsHP.DataMember = "HOCPHI";
            this.bdsHP.DataSource = this.DS;
            // 
            // hpGridControl
            // 
            this.hpGridControl.DataSource = this.bdsHP;
            this.hpGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.hpGridControl.Location = new System.Drawing.Point(0, 134);
            this.hpGridControl.MainView = this.hpGridView;
            this.hpGridControl.Name = "hpGridControl";
            this.hpGridControl.Size = new System.Drawing.Size(1267, 220);
            this.hpGridControl.TabIndex = 2;
            this.hpGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.hpGridView});
            // 
            // hpGridView
            // 
            this.hpGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colDADONG,
            this.colCANDONG});
            this.hpGridView.CustomizationFormBounds = new System.Drawing.Rectangle(972, 497, 377, 383);
            this.hpGridView.GridControl = this.hpGridControl;
            this.hpGridView.Name = "hpGridView";
            this.hpGridView.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.AutoComplete;
            this.hpGridView.OptionsView.ShowGroupPanel = false;
            this.hpGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.hpGridView_CustomUnboundColumnData);
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 30;
            this.colMASV.Name = "colMASV";
            this.colMASV.Width = 112;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 30;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            this.colNIENKHOA.Width = 112;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 30;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            this.colHOCKY.Width = 112;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 30;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            this.colHOCPHI.Width = 112;
            // 
            // colDADONG
            // 
            this.colDADONG.Caption = "DADONG";
            this.colDADONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDADONG.FieldName = "DADONG";
            this.colDADONG.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDADONG.MinWidth = 30;
            this.colDADONG.Name = "colDADONG";
            this.colDADONG.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colDADONG.Visible = true;
            this.colDADONG.VisibleIndex = 3;
            this.colDADONG.Width = 112;
            // 
            // colCANDONG
            // 
            this.colCANDONG.Caption = "CANDONG";
            this.colCANDONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCANDONG.FieldName = "CANDONG";
            this.colCANDONG.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCANDONG.MinWidth = 30;
            this.colCANDONG.Name = "colCANDONG";
            this.colCANDONG.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colCANDONG.Visible = true;
            this.colCANDONG.VisibleIndex = 4;
            this.colCANDONG.Width = 112;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cthpGridControl);
            this.panel2.Controls.Add(this.gbNhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1267, 269);
            this.panel2.TabIndex = 3;
            // 
            // cthpGridControl
            // 
            this.cthpGridControl.ContextMenuStrip = this.contextCTHP;
            this.cthpGridControl.DataSource = this.bdsCTHP;
            this.cthpGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cthpGridControl.Location = new System.Drawing.Point(371, 0);
            this.cthpGridControl.MainView = this.cthpGridView;
            this.cthpGridControl.Name = "cthpGridControl";
            this.cthpGridControl.Size = new System.Drawing.Size(896, 269);
            this.cthpGridControl.TabIndex = 1;
            this.cthpGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cthpGridView});
            // 
            // contextCTHP
            // 
            this.contextCTHP.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextCTHP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemCTHP,
            this.btnSuaCTHP,
            this.btnXoaCTHP,
            this.toolStripSeparator1,
            this.btnUndoCTHP,
            this.btnGhiCTHP});
            this.contextCTHP.Name = "contextSinhVien";
            this.contextCTHP.ShowImageMargin = false;
            this.contextCTHP.Size = new System.Drawing.Size(152, 170);
            // 
            // btnThemCTHP
            // 
            this.btnThemCTHP.Name = "btnThemCTHP";
            this.btnThemCTHP.Size = new System.Drawing.Size(151, 32);
            this.btnThemCTHP.Text = "Thêm CTHP";
            this.btnThemCTHP.Click += new System.EventHandler(this.btnThemCTHP_Click);
            // 
            // btnSuaCTHP
            // 
            this.btnSuaCTHP.Name = "btnSuaCTHP";
            this.btnSuaCTHP.Size = new System.Drawing.Size(151, 32);
            this.btnSuaCTHP.Text = "Sửa CTHP";
            this.btnSuaCTHP.Click += new System.EventHandler(this.btnSuaCTHP_Click);
            // 
            // btnXoaCTHP
            // 
            this.btnXoaCTHP.Name = "btnXoaCTHP";
            this.btnXoaCTHP.Size = new System.Drawing.Size(151, 32);
            this.btnXoaCTHP.Text = "Xóa CTHP";
            this.btnXoaCTHP.Click += new System.EventHandler(this.btnXoaCTHP_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // btnUndoCTHP
            // 
            this.btnUndoCTHP.Name = "btnUndoCTHP";
            this.btnUndoCTHP.Size = new System.Drawing.Size(151, 32);
            this.btnUndoCTHP.Text = "Phục hồi";
            this.btnUndoCTHP.Click += new System.EventHandler(this.btnUndoCTHP_Click);
            // 
            // btnGhiCTHP
            // 
            this.btnGhiCTHP.Name = "btnGhiCTHP";
            this.btnGhiCTHP.Size = new System.Drawing.Size(151, 32);
            this.btnGhiCTHP.Text = "Ghi";
            this.btnGhiCTHP.Click += new System.EventHandler(this.btnGhiCTHP_Click);
            // 
            // bdsCTHP
            // 
            this.bdsCTHP.DataMember = "FK_CT_DONGHOCPHI_HOCPHI";
            this.bdsCTHP.DataSource = this.bdsHP;
            // 
            // cthpGridView
            // 
            this.cthpGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV1,
            this.colNIENKHOA1,
            this.colHOCKY1,
            this.colNGAYDONG,
            this.colSOTIENDONG});
            this.cthpGridView.CustomizationFormBounds = new System.Drawing.Rectangle(972, 497, 377, 383);
            this.cthpGridView.GridControl = this.cthpGridControl;
            this.cthpGridView.Name = "cthpGridView";
            this.cthpGridView.OptionsBehavior.ReadOnly = true;
            this.cthpGridView.OptionsView.ShowGroupPanel = false;
            this.cthpGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.cthpGridView_FocusedRowChanged);
            // 
            // colMASV1
            // 
            this.colMASV1.FieldName = "MASV";
            this.colMASV1.MinWidth = 30;
            this.colMASV1.Name = "colMASV1";
            this.colMASV1.Width = 112;
            // 
            // colNIENKHOA1
            // 
            this.colNIENKHOA1.FieldName = "NIENKHOA";
            this.colNIENKHOA1.MinWidth = 30;
            this.colNIENKHOA1.Name = "colNIENKHOA1";
            this.colNIENKHOA1.Width = 112;
            // 
            // colHOCKY1
            // 
            this.colHOCKY1.FieldName = "HOCKY";
            this.colHOCKY1.MinWidth = 30;
            this.colHOCKY1.Name = "colHOCKY1";
            this.colHOCKY1.Width = 112;
            // 
            // colNGAYDONG
            // 
            this.colNGAYDONG.FieldName = "NGAYDONG";
            this.colNGAYDONG.MinWidth = 30;
            this.colNGAYDONG.Name = "colNGAYDONG";
            this.colNGAYDONG.Visible = true;
            this.colNGAYDONG.VisibleIndex = 0;
            this.colNGAYDONG.Width = 112;
            // 
            // colSOTIENDONG
            // 
            this.colSOTIENDONG.FieldName = "SOTIENDONG";
            this.colSOTIENDONG.MinWidth = 30;
            this.colSOTIENDONG.Name = "colSOTIENDONG";
            this.colSOTIENDONG.Visible = true;
            this.colSOTIENDONG.VisibleIndex = 1;
            this.colSOTIENDONG.Width = 112;
            // 
            // gbNhap
            // 
            this.gbNhap.Controls.Add(mASVLabel);
            this.gbNhap.Controls.Add(this.txtMaSV);
            this.gbNhap.Controls.Add(hOCPHILabel);
            this.gbNhap.Controls.Add(this.txtHocPhi);
            this.gbNhap.Controls.Add(hOCKYLabel);
            this.gbNhap.Controls.Add(this.cmbHocKy);
            this.gbNhap.Controls.Add(nIENKHOALabel);
            this.gbNhap.Controls.Add(this.txtNienKhoa);
            this.gbNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbNhap.Enabled = false;
            this.gbNhap.Location = new System.Drawing.Point(0, 0);
            this.gbNhap.Name = "gbNhap";
            this.gbNhap.Size = new System.Drawing.Size(371, 269);
            this.gbNhap.TabIndex = 0;
            this.gbNhap.TabStop = false;
            this.gbNhap.Text = "Nhập thông tin học phí";
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHP, "MASV", true));
            this.txtMaSV.Enabled = false;
            this.txtMaSV.Location = new System.Drawing.Point(114, 127);
            this.txtMaSV.MenuManager = this.barManager1;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(233, 28);
            this.txtMaSV.TabIndex = 7;
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHP, "HOCPHI", true));
            this.txtHocPhi.Location = new System.Drawing.Point(114, 93);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Properties.Mask.EditMask = "c0";
            this.txtHocPhi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtHocPhi.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtHocPhi.Size = new System.Drawing.Size(233, 28);
            this.txtHocPhi.TabIndex = 5;
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHP, "HOCKY", true));
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbHocKy.Location = new System.Drawing.Point(114, 59);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(233, 28);
            this.cmbHocKy.TabIndex = 3;
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHP, "NIENKHOA", true));
            this.txtNienKhoa.Location = new System.Drawing.Point(114, 25);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(233, 28);
            this.txtNienKhoa.TabIndex = 1;
            // 
            // cthpTableAdapter
            // 
            this.cthpTableAdapter.ClearBeforeFill = true;
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1267, 34);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 589);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.hpGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmHocPhi";
            this.Text = "Học phí";
            this.Load += new System.EventHandler(this.frmHocPhi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cthpGridControl)).EndInit();
            this.contextCTHP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cthpGridView)).EndInit();
            this.gbNhap.ResumeLayout(false);
            this.gbNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DS DS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbMaSV;
        private System.Windows.Forms.Label labelTen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DSTableAdapters.HOCPHITableAdapter hpTableAdapter;
        private System.Windows.Forms.BindingSource bdsHP;
        private DevExpress.XtraGrid.GridControl hpGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView hpGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbNhap;
        private DevExpress.XtraEditors.TextEdit txtHocPhi;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
        private System.Windows.Forms.BindingSource bdsCTHP;
        private DSTableAdapters.CT_DONGHOCPHITableAdapter cthpTableAdapter;
        private DevExpress.XtraGrid.GridControl cthpGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView cthpGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA1;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDONG;
        //private DevExpress.XtraBars.BarButtonItem btnThem;
        //private DevExpress.XtraBars.BarButtonItem btnXoa;
        //private DevExpress.XtraBars.BarButtonItem btnSua;
        //private DevExpress.XtraBars.BarButtonItem btnUndo;
        //private DevExpress.XtraBars.BarButtonItem btnGhi;
        //private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        //private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraGrid.Columns.GridColumn colDADONG;
        private DevExpress.XtraGrid.Columns.GridColumn colCANDONG;
        private System.Windows.Forms.ContextMenuStrip contextCTHP;
        private System.Windows.Forms.ToolStripMenuItem btnThemCTHP;
        private System.Windows.Forms.ToolStripMenuItem btnSuaCTHP;
        private System.Windows.Forms.ToolStripMenuItem btnXoaCTHP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnUndoCTHP;
        private System.Windows.Forms.ToolStripMenuItem btnGhiCTHP;
    }
}