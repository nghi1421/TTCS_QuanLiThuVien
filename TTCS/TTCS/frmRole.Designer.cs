namespace TTCS
{
    partial class frmRole
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label create_dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRole));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.quanLiThuVienDataSet = new TTCS.QuanLiThuVienDataSet();
            this.database_principalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database_principalsTableAdapter = new TTCS.QuanLiThuVienDataSetTableAdapters.database_principalsTableAdapter();
            this.tableAdapterManager = new TTCS.QuanLiThuVienDataSetTableAdapters.TableAdapterManager();
            this.database_principalsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreate_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxdb_sercurity = new System.Windows.Forms.CheckBox();
            this.checkBoxdb_owner = new System.Windows.Forms.CheckBox();
            this.checkBoxdb_denyw = new System.Windows.Forms.CheckBox();
            this.checkBoxdb_denyr = new System.Windows.Forms.CheckBox();
            this.checkBoxdb_ddladmin = new System.Windows.Forms.CheckBox();
            this.checkBoxdb_datawriter = new System.Windows.Forms.CheckBox();
            this.checkBoxdb_datareader = new System.Windows.Forms.CheckBox();
            this.checkBoxdb_backup = new System.Windows.Forms.CheckBox();
            this.checkBoxdb_access = new System.Windows.Forms.CheckBox();
            this.create_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new TTCS.QuanLiThuVienDataSetTableAdapters.DataTable1TableAdapter();
            this.dataTable1DataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameLabel = new System.Windows.Forms.Label();
            create_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_principalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_principalsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.create_dateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.create_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(34, 79);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 17);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "name:";
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(34, 134);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(82, 17);
            create_dateLabel.TabIndex = 2;
            create_dateLabel.Text = "create date:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7});
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem7, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem6, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Ghi";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Sửa";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Xóa";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Refresh";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Thoát";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Hủy";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem7.ImageOptions.SvgImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1331, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 507);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1331, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 448);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1331, 59);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 448);
            // 
            // quanLiThuVienDataSet
            // 
            this.quanLiThuVienDataSet.DataSetName = "QuanLiThuVienDataSet";
            this.quanLiThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database_principalsBindingSource
            // 
            this.database_principalsBindingSource.DataMember = "database_principals";
            this.database_principalsBindingSource.DataSource = this.quanLiThuVienDataSet;
            // 
            // database_principalsTableAdapter
            // 
            this.database_principalsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_PHIEUMUONTRATableAdapter = null;
            this.tableAdapterManager.CT_PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.CUONSACHTableAdapter = null;
            this.tableAdapterManager.database_principalsTableAdapter = null;
            this.tableAdapterManager.DataTable1TableAdapter = null;
            this.tableAdapterManager.DAUSACHTableAdapter = null;
            this.tableAdapterManager.DOCGIATableAdapter = null;
            this.tableAdapterManager.KETableAdapter = null;
            this.tableAdapterManager.LEPHITableAdapter = null;
            this.tableAdapterManager.NGANTableAdapter = null;
            this.tableAdapterManager.NHAXUATBANTableAdapter = null;
            this.tableAdapterManager.PHIEUMUONTRATableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.SANGTACTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.THELOAITableAdapter = null;
            this.tableAdapterManager.THUTHUTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TTCS.QuanLiThuVienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // database_principalsGridControl
            // 
            this.database_principalsGridControl.DataSource = this.database_principalsBindingSource;
            this.database_principalsGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.database_principalsGridControl.Location = new System.Drawing.Point(0, 59);
            this.database_principalsGridControl.MainView = this.gridView1;
            this.database_principalsGridControl.MenuManager = this.barManager1;
            this.database_principalsGridControl.Name = "database_principalsGridControl";
            this.database_principalsGridControl.Size = new System.Drawing.Size(1331, 182);
            this.database_principalsGridControl.TabIndex = 5;
            this.database_principalsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.database_principalsGridControl.Click += new System.EventHandler(this.database_principalsGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname,
            this.colcreate_date});
            this.gridView1.GridControl = this.database_principalsGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colname
            // 
            this.colname.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colname.AppearanceHeader.Options.UseFont = true;
            this.colname.Caption = "Tên role";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.ReadOnly = true;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            // 
            // colcreate_date
            // 
            this.colcreate_date.Caption = "Ngày tạo";
            this.colcreate_date.FieldName = "create_date";
            this.colcreate_date.Name = "colcreate_date";
            this.colcreate_date.Visible = true;
            this.colcreate_date.VisibleIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.checkBoxdb_sercurity);
            this.panelControl1.Controls.Add(this.checkBoxdb_owner);
            this.panelControl1.Controls.Add(this.checkBoxdb_denyw);
            this.panelControl1.Controls.Add(this.checkBoxdb_denyr);
            this.panelControl1.Controls.Add(this.checkBoxdb_ddladmin);
            this.panelControl1.Controls.Add(this.checkBoxdb_datawriter);
            this.panelControl1.Controls.Add(this.checkBoxdb_datareader);
            this.panelControl1.Controls.Add(this.checkBoxdb_backup);
            this.panelControl1.Controls.Add(this.checkBoxdb_access);
            this.panelControl1.Controls.Add(create_dateLabel);
            this.panelControl1.Controls.Add(this.create_dateDateEdit);
            this.panelControl1.Controls.Add(nameLabel);
            this.panelControl1.Controls.Add(this.nameTextEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 241);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(719, 266);
            this.panelControl1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Permissions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Role Name";
            // 
            // checkBoxdb_sercurity
            // 
            this.checkBoxdb_sercurity.AutoSize = true;
            this.checkBoxdb_sercurity.Location = new System.Drawing.Point(554, 120);
            this.checkBoxdb_sercurity.Name = "checkBoxdb_sercurity";
            this.checkBoxdb_sercurity.Size = new System.Drawing.Size(139, 21);
            this.checkBoxdb_sercurity.TabIndex = 12;
            this.checkBoxdb_sercurity.Text = "db_securityadmin";
            this.checkBoxdb_sercurity.UseVisualStyleBackColor = true;
            // 
            // checkBoxdb_owner
            // 
            this.checkBoxdb_owner.AutoSize = true;
            this.checkBoxdb_owner.Location = new System.Drawing.Point(554, 94);
            this.checkBoxdb_owner.Name = "checkBoxdb_owner";
            this.checkBoxdb_owner.Size = new System.Drawing.Size(92, 21);
            this.checkBoxdb_owner.TabIndex = 11;
            this.checkBoxdb_owner.Text = "db_owner";
            this.checkBoxdb_owner.UseVisualStyleBackColor = true;
            // 
            // checkBoxdb_denyw
            // 
            this.checkBoxdb_denyw.AutoSize = true;
            this.checkBoxdb_denyw.Location = new System.Drawing.Point(554, 66);
            this.checkBoxdb_denyw.Name = "checkBoxdb_denyw";
            this.checkBoxdb_denyw.Size = new System.Drawing.Size(146, 21);
            this.checkBoxdb_denyw.TabIndex = 10;
            this.checkBoxdb_denyw.Text = "db_denydatawriter";
            this.checkBoxdb_denyw.UseVisualStyleBackColor = true;
            // 
            // checkBoxdb_denyr
            // 
            this.checkBoxdb_denyr.AutoSize = true;
            this.checkBoxdb_denyr.Location = new System.Drawing.Point(379, 205);
            this.checkBoxdb_denyr.Name = "checkBoxdb_denyr";
            this.checkBoxdb_denyr.Size = new System.Drawing.Size(151, 21);
            this.checkBoxdb_denyr.TabIndex = 9;
            this.checkBoxdb_denyr.Text = "db_denydatareader";
            this.checkBoxdb_denyr.UseVisualStyleBackColor = true;
            // 
            // checkBoxdb_ddladmin
            // 
            this.checkBoxdb_ddladmin.AutoSize = true;
            this.checkBoxdb_ddladmin.Location = new System.Drawing.Point(379, 177);
            this.checkBoxdb_ddladmin.Name = "checkBoxdb_ddladmin";
            this.checkBoxdb_ddladmin.Size = new System.Drawing.Size(109, 21);
            this.checkBoxdb_ddladmin.TabIndex = 8;
            this.checkBoxdb_ddladmin.Text = "db_ddladmin";
            this.checkBoxdb_ddladmin.UseVisualStyleBackColor = true;
            // 
            // checkBoxdb_datawriter
            // 
            this.checkBoxdb_datawriter.AutoSize = true;
            this.checkBoxdb_datawriter.Location = new System.Drawing.Point(379, 149);
            this.checkBoxdb_datawriter.Name = "checkBoxdb_datawriter";
            this.checkBoxdb_datawriter.Size = new System.Drawing.Size(115, 21);
            this.checkBoxdb_datawriter.TabIndex = 7;
            this.checkBoxdb_datawriter.Text = "db_datawriter";
            this.checkBoxdb_datawriter.UseVisualStyleBackColor = true;
            // 
            // checkBoxdb_datareader
            // 
            this.checkBoxdb_datareader.AutoSize = true;
            this.checkBoxdb_datareader.Location = new System.Drawing.Point(379, 121);
            this.checkBoxdb_datareader.Name = "checkBoxdb_datareader";
            this.checkBoxdb_datareader.Size = new System.Drawing.Size(120, 21);
            this.checkBoxdb_datareader.TabIndex = 6;
            this.checkBoxdb_datareader.Text = "db_datareader";
            this.checkBoxdb_datareader.UseVisualStyleBackColor = true;
            // 
            // checkBoxdb_backup
            // 
            this.checkBoxdb_backup.AutoSize = true;
            this.checkBoxdb_backup.Location = new System.Drawing.Point(379, 94);
            this.checkBoxdb_backup.Name = "checkBoxdb_backup";
            this.checkBoxdb_backup.Size = new System.Drawing.Size(152, 21);
            this.checkBoxdb_backup.TabIndex = 5;
            this.checkBoxdb_backup.Text = "db_backupoperator";
            this.checkBoxdb_backup.UseVisualStyleBackColor = true;
            // 
            // checkBoxdb_access
            // 
            this.checkBoxdb_access.AutoSize = true;
            this.checkBoxdb_access.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxdb_access.Location = new System.Drawing.Point(379, 66);
            this.checkBoxdb_access.Name = "checkBoxdb_access";
            this.checkBoxdb_access.Size = new System.Drawing.Size(131, 21);
            this.checkBoxdb_access.TabIndex = 4;
            this.checkBoxdb_access.Text = "db_accessadmin";
            this.checkBoxdb_access.UseMnemonic = false;
            this.checkBoxdb_access.UseVisualStyleBackColor = true;
            // 
            // create_dateDateEdit
            // 
            this.create_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.database_principalsBindingSource, "create_date", true));
            this.create_dateDateEdit.EditValue = null;
            this.create_dateDateEdit.Location = new System.Drawing.Point(122, 131);
            this.create_dateDateEdit.MenuManager = this.barManager1;
            this.create_dateDateEdit.Name = "create_dateDateEdit";
            this.create_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.create_dateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.create_dateDateEdit.Size = new System.Drawing.Size(129, 22);
            this.create_dateDateEdit.TabIndex = 3;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.database_principalsBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(87, 76);
            this.nameTextEdit.MenuManager = this.barManager1;
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(164, 22);
            this.nameTextEdit.TabIndex = 1;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "FK_database_principals_DataTable1";
            this.dataTable1BindingSource.DataSource = this.database_principalsBindingSource;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1DataGridView
            // 
            this.dataTable1DataGridView.AutoGenerateColumns = false;
            this.dataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.memberof});
            this.dataTable1DataGridView.DataSource = this.dataTable1BindingSource;
            this.dataTable1DataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataTable1DataGridView.Location = new System.Drawing.Point(719, 241);
            this.dataTable1DataGridView.Name = "dataTable1DataGridView";
            this.dataTable1DataGridView.RowHeadersWidth = 51;
            this.dataTable1DataGridView.RowTemplate.Height = 24;
            this.dataTable1DataGridView.Size = new System.Drawing.Size(612, 266);
            this.dataTable1DataGridView.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemQuyen,
            this.btnXoaQuyen});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 52);
            // 
            // btnThemQuyen
            // 
            this.btnThemQuyen.Name = "btnThemQuyen";
            this.btnThemQuyen.Size = new System.Drawing.Size(115, 24);
            this.btnThemQuyen.Text = "Thêm";
            // 
            // btnXoaQuyen
            // 
            this.btnXoaQuyen.Name = "btnXoaQuyen";
            this.btnXoaQuyen.Size = new System.Drawing.Size(115, 24);
            this.btnXoaQuyen.Text = "Xóa";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên role";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // memberof
            // 
            this.memberof.DataPropertyName = "memberof";
            this.memberof.HeaderText = "Quyền";
            this.memberof.MinimumWidth = 6;
            this.memberof.Name = "memberof";
            this.memberof.ReadOnly = true;
            this.memberof.Width = 125;
            // 
            // frmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 532);
            this.Controls.Add(this.dataTable1DataGridView);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.database_principalsGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmRole";
            this.Text = "Quản lí role";
            this.Load += new System.EventHandler(this.frmRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_principalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_principalsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.create_dateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.create_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource database_principalsBindingSource;
        private QuanLiThuVienDataSet quanLiThuVienDataSet;
        private QuanLiThuVienDataSetTableAdapters.database_principalsTableAdapter database_principalsTableAdapter;
        private QuanLiThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl database_principalsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private QuanLiThuVienDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridView dataTable1DataGridView;
        private DevExpress.XtraEditors.DateEdit create_dateDateEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colcreate_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxdb_sercurity;
        private System.Windows.Forms.CheckBox checkBoxdb_owner;
        private System.Windows.Forms.CheckBox checkBoxdb_denyw;
        private System.Windows.Forms.CheckBox checkBoxdb_denyr;
        private System.Windows.Forms.CheckBox checkBoxdb_ddladmin;
        private System.Windows.Forms.CheckBox checkBoxdb_datawriter;
        private System.Windows.Forms.CheckBox checkBoxdb_datareader;
        private System.Windows.Forms.CheckBox checkBoxdb_backup;
        private System.Windows.Forms.CheckBox checkBoxdb_access;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemQuyen;
        private System.Windows.Forms.ToolStripMenuItem btnXoaQuyen;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberof;
    }
}