namespace TTCS
{
    partial class frmTK
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
            System.Windows.Forms.Label nHOMLabel1;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.quanLiThuVienDataSet = new TTCS.QuanLiThuVienDataSet();
            this.sysloginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sysloginsTableAdapter = new TTCS.QuanLiThuVienDataSetTableAdapters.sysloginsTableAdapter();
            this.tableAdapterManager = new TTCS.QuanLiThuVienDataSetTableAdapters.TableAdapterManager();
            this.sysloginsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreatedate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.nHOMCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.txtMK = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            nameLabel = new System.Windows.Forms.Label();
            nHOMLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysloginsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysloginsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(397, 93);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(68, 17);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Tên login:";
            // 
            // nHOMLabel1
            // 
            nHOMLabel1.AutoSize = true;
            nHOMLabel1.Location = new System.Drawing.Point(650, 93);
            nHOMLabel1.Name = "nHOMLabel1";
            nHOMLabel1.Size = new System.Drawing.Size(51, 17);
            nHOMLabel1.TabIndex = 7;
            nHOMLabel1.Text = "NHOM:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
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
            this.barManager1.MainMenu = this.bar2;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Ghi";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Sửa";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1181, 58);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 976);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1181, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 58);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 918);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1181, 58);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 918);
            // 
            // quanLiThuVienDataSet
            // 
            this.quanLiThuVienDataSet.DataSetName = "QuanLiThuVienDataSet";
            this.quanLiThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sysloginsBindingSource
            // 
            this.sysloginsBindingSource.DataMember = "syslogins";
            this.sysloginsBindingSource.DataSource = this.quanLiThuVienDataSet;
            // 
            // sysloginsTableAdapter
            // 
            this.sysloginsTableAdapter.ClearBeforeFill = true;
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
            // sysloginsGridControl
            // 
            this.sysloginsGridControl.DataSource = this.sysloginsBindingSource;
            this.sysloginsGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sysloginsGridControl.Location = new System.Drawing.Point(0, 58);
            this.sysloginsGridControl.MainView = this.gridView1;
            this.sysloginsGridControl.MenuManager = this.barManager1;
            this.sysloginsGridControl.Name = "sysloginsGridControl";
            this.sysloginsGridControl.Size = new System.Drawing.Size(1181, 528);
            this.sysloginsGridControl.TabIndex = 5;
            this.sysloginsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname,
            this.colNHOM,
            this.colcreatedate});
            this.gridView1.GridControl = this.sysloginsGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick_1);
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // colname
            // 
            this.colname.Caption = "Tài khoản";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            // 
            // colNHOM
            // 
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 1;
            // 
            // colcreatedate
            // 
            this.colcreatedate.Caption = "Ngày tạo";
            this.colcreatedate.FieldName = "createdate";
            this.colcreatedate.Name = "colcreatedate";
            this.colcreatedate.Visible = true;
            this.colcreatedate.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(nHOMLabel1);
            this.panelControl1.Controls.Add(this.nHOMCheckedListBox);
            this.panelControl1.Controls.Add(this.txtMK);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(nameLabel);
            this.panelControl1.Controls.Add(this.nameTextEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 770);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1181, 206);
            this.panelControl1.TabIndex = 6;
            // 
            // nHOMCheckedListBox
            // 
            this.nHOMCheckedListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sysloginsBindingSource, "NHOM", true));
            this.nHOMCheckedListBox.FormattingEnabled = true;
            this.nHOMCheckedListBox.Location = new System.Drawing.Point(707, 84);
            this.nHOMCheckedListBox.Name = "nHOMCheckedListBox";
            this.nHOMCheckedListBox.Size = new System.Drawing.Size(120, 94);
            this.nHOMCheckedListBox.TabIndex = 8;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(471, 124);
            this.txtMK.MenuManager = this.barManager1;
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(100, 22);
            this.txtMK.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông tin Login";
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sysloginsBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(471, 90);
            this.nameTextEdit.MenuManager = this.barManager1;
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(100, 22);
            this.nameTextEdit.TabIndex = 1;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Refresh";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Thoát";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Hủy";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // frmTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 1001);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.sysloginsGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTK";
            this.Text = "frmTK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysloginsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysloginsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource sysloginsBindingSource;
        private QuanLiThuVienDataSet quanLiThuVienDataSet;
        private QuanLiThuVienDataSetTableAdapters.sysloginsTableAdapter sysloginsTableAdapter;
        private QuanLiThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl sysloginsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colcreatedate;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtMK;
        private System.Windows.Forms.CheckedListBox nHOMCheckedListBox;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
    }
}