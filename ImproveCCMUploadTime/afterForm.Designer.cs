namespace ImproveCCMUploadTime
{
    partial class AfterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfterForm));
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this._imageListSmall = new DevExpress.Utils.ImageCollection(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this._mainGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this._statusComboBoxImagesRepositoryItem = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this._colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colHost = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colDBHost = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colPrimaryHost = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colSecondaryHost = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colPrimaryDBHost = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colSecondaryDBHost = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colDesiredState = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colLastChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this._colHasHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this._repositoryItemImageCbState = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this._imageListLarge = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._imageListSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._mainGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._statusComboBoxImagesRepositoryItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._repositoryItemImageCbState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._imageListLarge)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName});
            this.treeList1.DataSource = null;
            this.treeList1.Location = new System.Drawing.Point(13, 13);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsView.ShowColumns = false;
            this.treeList1.OptionsView.ShowHorzLines = false;
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.Size = new System.Drawing.Size(171, 470);
            this.treeList1.StateImageList = this._imageListSmall;
            this.treeList1.TabIndex = 0;
            this.treeList1.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.treeList1_GetStateImage);
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.treeList1.VirtualTreeGetChildNodes += new DevExpress.XtraTreeList.VirtualTreeGetChildNodesEventHandler(this.treeList1_VirtualTreeGetChildNodes);
            this.treeList1.VirtualTreeGetCellValue += new DevExpress.XtraTreeList.VirtualTreeGetCellValueEventHandler(this.treeList1_VirtualTreeGetCellValue);
            // 
            // colName
            // 
            this.colName.Caption = "treeListColumn1";
            this.colName.FieldName = "name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // _imageListSmall
            // 
            this._imageListSmall.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("_imageListSmall.ImageStream")));
            this._imageListSmall.TransparentColor = System.Drawing.Color.Magenta;
            this._imageListSmall.Images.SetKeyName(0, "0 blank");
            this._imageListSmall.Images.SetKeyName(1, "1 GSR gui_server");
            this._imageListSmall.Images.SetKeyName(2, "2 GCS");
            this._imageListSmall.Images.SetKeyName(3, "3 BIM");
            this._imageListSmall.Images.SetKeyName(4, "4 Forecast");
            this._imageListSmall.Images.SetKeyName(5, "5.bmp");
            this._imageListSmall.Images.SetKeyName(6, "6 SelfService");
            this._imageListSmall.Images.SetKeyName(7, "7.bmp");
            this._imageListSmall.Images.SetKeyName(8, "8 Agent");
            this._imageListSmall.Images.SetKeyName(9, "9 CM");
            this._imageListSmall.Images.SetKeyName(10, "10.bmp");
            this._imageListSmall.Images.SetKeyName(11, "11.bmp");
            this._imageListSmall.Images.SetKeyName(12, "12.bmp");
            this._imageListSmall.Images.SetKeyName(13, "13.bmp");
            this._imageListSmall.Images.SetKeyName(14, "14.bmp");
            this._imageListSmall.Images.SetKeyName(15, "15 ActionDown");
            this._imageListSmall.Images.SetKeyName(16, "16 ActionUp");
            this._imageListSmall.Images.SetKeyName(17, "17 ActionRecycle");
            this._imageListSmall.Images.SetKeyName(18, "18 ActionIgnored");
            this._imageListSmall.Images.SetKeyName(19, "19 ActionDelete");
            this._imageListSmall.Images.SetKeyName(20, "20 ControlM_Server");
            this._imageListSmall.Images.SetKeyName(21, "21 ControlM_EmComponent");
            this._imageListSmall.Images.SetKeyName(22, "22 Properties");
            this._imageListSmall.Images.SetKeyName(23, "23 GridStatusError");
            this._imageListSmall.Images.SetKeyName(24, "24 GridStatusExclamationMark");
            this._imageListSmall.Images.SetKeyName(25, "25 GridStatusWarning");
            this._imageListSmall.Images.SetKeyName(26, "26 GridStatusUnavailable");
            this._imageListSmall.Images.SetKeyName(27, "27.bmp");
            this._imageListSmall.Images.SetKeyName(28, "28.bmp");
            this._imageListSmall.Images.SetKeyName(29, "29 ControlShell");
            this._imageListSmall.Images.SetKeyName(30, "30 ControlMServerSecurity");
            this._imageListSmall.Images.SetKeyName(31, "31 Parameters");
            this._imageListSmall.Images.SetKeyName(32, "32 TreeStatusError");
            this._imageListSmall.Images.SetKeyName(33, "33.bmp");
            this._imageListSmall.Images.SetKeyName(34, "34 TreeStatusOK");
            this._imageListSmall.Images.SetKeyName(35, "35 Refresh");
            this._imageListSmall.Images.SetKeyName(36, "36 IOAGATE");
            this._imageListSmall.Images.SetKeyName(37, "37 CTMSApplServer");
            this._imageListSmall.Images.SetKeyName(38, "38 CTMSGlobalMon");
            this._imageListSmall.Images.SetKeyName(39, "39 CTMSLocalMon");
            this._imageListSmall.Images.SetKeyName(40, "40 CTMSCMEMMon");
            this._imageListSmall.Images.SetKeyName(41, "41 Gateway");
            this._imageListSmall.Images.SetKeyName(42, "42 StatusbarOK");
            this._imageListSmall.Images.SetKeyName(43, "43 StatusbarNotOk");
            this._imageListSmall.Images.SetKeyName(44, "44 RJX");
            this._imageListSmall.Images.SetKeyName(45, "45 SecurityRunAs");
            this._imageListSmall.Images.SetKeyName(46, "46.bmp");
            this._imageListSmall.Images.SetKeyName(47, "47.bmp");
            this._imageListSmall.Images.SetKeyName(48, "48 FILE_TRANS");
            this._imageListSmall.Images.SetKeyName(49, "49 WebServer");
            this._imageListSmall.Images.SetKeyName(50, "50 CTMLoadBalancer");
            this._imageListSmall.Images.SetKeyName(51, "51 None");
            this._imageListSmall.Images.SetKeyName(52, "52 New");
            this._imageListSmall.Images.SetKeyName(53, "53 ActionResults");
            this._imageListSmall.Images.SetKeyName(54, "54 Export");
            this._imageListSmall.Images.SetKeyName(55, "55 Options");
            this._imageListSmall.Images.SetKeyName(56, "56 Help");
            this._imageListSmall.Images.SetKeyName(57, "57 AFT");
            this._imageListSmall.Images.SetKeyName(58, "58 ManageSSL");
            this._imageListSmall.Images.SetKeyName(59, "59 OneLevel");
            this._imageListSmall.Images.SetKeyName(60, "60 ShowAll");
            this._imageListSmall.Images.SetKeyName(61, "61 ExceptionAlerts");
            this._imageListSmall.Images.SetKeyName(62, "62 RemoveOldAlerts");
            this._imageListSmall.Images.SetKeyName(63, "63 ActionStarting");
            this._imageListSmall.Images.SetKeyName(64, "64 ActionStopping");
            this._imageListSmall.Images.SetKeyName(65, "65 ManagePause");
            this._imageListSmall.Images.SetKeyName(66, "66 SecurityAuthorizations");
            this._imageListSmall.Images.SetKeyName(67, "67 Database");
            this._imageListSmall.Images.SetKeyName(68, "68 RemoteSettings");
            this._imageListSmall.Images.SetKeyName(69, "69 HostManager");
            this._imageListSmall.Images.SetKeyName(70, "70 AgentLog");
            this._imageListSmall.Images.SetKeyName(71, "71 DiagnosticsData");
            this._imageListSmall.Images.SetKeyName(72, "72 GroupByComponent");
            this._imageListSmall.Images.SetKeyName(73, "73 GroupByHost");
            this._imageListSmall.Images.SetKeyName(74, "74 ShoutDestination");
            this._imageListSmall.Images.SetKeyName(75, "75 AgentsDeploy");
            this._imageListSmall.Images.SetKeyName(76, "76 Debug");
            this._imageListSmall.Images.SetKeyName(77, "77 SSHKeys");
            this._imageListSmall.Images.SetKeyName(78, "78 CMS");
            this._imageListSmall.Images.SetKeyName(79, "79 EM Server");
            this._imageListSmall.Images.SetKeyName(80, "80 Naming Service");
            this._imageListSmall.Images.SetKeyName(81, "81 CTM Promote");
            this._imageListSmall.Images.SetKeyName(82, "82 TreeStatusWarning");
            this._imageListSmall.Images.SetKeyName(83, "83 TreeStatusInfo");
            this._imageListSmall.Images.SetKeyName(84, "HASetAsPrimary");
            this._imageListSmall.Images.SetKeyName(85, "HAStartReplication");
            this._imageListSmall.Images.SetKeyName(86, "HASwitchToSyncReplication");
            this._imageListSmall.Images.SetKeyName(87, "HA on Server");
            this._imageListSmall.Images.SetKeyName(88, "HA on EM");
            this._imageListSmall.Images.SetKeyName(89, "HA on Database");
            this._imageListSmall.Images.SetKeyName(90, "Component with HA");
            this._imageListSmall.Images.SetKeyName(91, "UsageAlerts16.png");
            this._imageListSmall.Images.SetKeyName(92, "UsageAlerts32.png");
            this._imageListSmall.Images.SetKeyName(93, "Web Launch");
            this._imageListSmall.Images.SetKeyName(94, "HAFallBackToPrimary");
            this._imageListSmall.Images.SetKeyName(95, "HAFailOverToSecondary");
            this._imageListSmall.Images.SetKeyName(96, "ClientDeploy");
            this._imageListSmall.Images.SetKeyName(97, "ArchiveIcon16.png");
            this._imageListSmall.Images.SetKeyName(101, "WebserverDBL16.png");
            this._imageListSmall.Images.SetKeyName(102, "CompiMode.png");
            this._imageListSmall.Images.SetKeyName(103, "StatusBArOrangeWarning.png");
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(199, 13);
            this.gridControl1.MainView = this._mainGrid;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this._repositoryItemImageCbState,
            this._statusComboBoxImagesRepositoryItem});
            this.gridControl1.Size = new System.Drawing.Size(905, 470);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._mainGrid});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // _mainGrid
            // 
            this._mainGrid.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this._mainGrid.Appearance.EvenRow.Options.UseBackColor = true;
            this._mainGrid.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this._mainGrid.Appearance.OddRow.Options.UseBackColor = true;
            this._mainGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Status,
            this._colType,
            this._colName,
            this._colHost,
            this._colDBHost,
            this._colPrimaryHost,
            this._colSecondaryHost,
            this._colPrimaryDBHost,
            this._colSecondaryDBHost,
            this._colState,
            this._colDesiredState,
            this._colMessage,
            this._colLastChecked,
            this._colOS,
            this._colVersion,
            this._colHasHA});
            this._mainGrid.GridControl = this.gridControl1;
            this._mainGrid.Name = "_mainGrid";
            this._mainGrid.OptionsSelection.EnableAppearanceFocusedCell = false;
            this._mainGrid.OptionsSelection.MultiSelect = true;
            this._mainGrid.OptionsView.ColumnAutoWidth = false;
            this._mainGrid.OptionsView.EnableAppearanceEvenRow = true;
            this._mainGrid.OptionsView.EnableAppearanceOddRow = true;
            this._mainGrid.OptionsView.ShowAutoFilterRow = true;
            this._mainGrid.OptionsView.ShowGroupPanel = false;
            this._mainGrid.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this._colType, DevExpress.Data.ColumnSortOrder.Ascending)});
            this._mainGrid.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this._mainGrid_CustomUnboundColumnData);
            // 
            // Status
            // 
            this.Status.AppearanceCell.Options.UseTextOptions = true;
            this.Status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Status.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Status.AppearanceHeader.Options.UseTextOptions = true;
            this.Status.Caption = "Status";
            this.Status.ColumnEdit = this._statusComboBoxImagesRepositoryItem;
            this.Status.Name = "Status";
            this.Status.OptionsColumn.AllowEdit = false;
            this.Status.Visible = true;
            this.Status.VisibleIndex = 0;
            this.Status.Width = 43;
            // 
            // _statusComboBoxImagesRepositoryItem
            // 
            this._statusComboBoxImagesRepositoryItem.AutoHeight = false;
            this._statusComboBoxImagesRepositoryItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._statusComboBoxImagesRepositoryItem.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this._statusComboBoxImagesRepositoryItem.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("OK", "OK", 42),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Information", "Information", 24),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Warning", "Warning", 25),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Error", "Error", 23)});
            this._statusComboBoxImagesRepositoryItem.Name = "_statusComboBoxImagesRepositoryItem";
            this._statusComboBoxImagesRepositoryItem.SmallImages = this._imageListSmall;
            // 
            // _colType
            // 
            this._colType.Caption = "Type";
            this._colType.Name = "_colType";
            this._colType.OptionsColumn.AllowEdit = false;
            this._colType.Visible = true;
            this._colType.VisibleIndex = 1;
            this._colType.Width = 169;
            // 
            // _colName
            // 
            this._colName.Caption = "Name";
            this._colName.Name = "_colName";
            this._colName.OptionsColumn.AllowEdit = false;
            this._colName.Visible = true;
            this._colName.VisibleIndex = 2;
            this._colName.Width = 169;
            // 
            // _colHost
            // 
            this._colHost.Caption = "Running On";
            this._colHost.Name = "_colHost";
            this._colHost.OptionsColumn.AllowEdit = false;
            this._colHost.Visible = true;
            this._colHost.VisibleIndex = 3;
            this._colHost.Width = 169;
            // 
            // _colDBHost
            // 
            this._colDBHost.Caption = "DB Running On";
            this._colDBHost.Name = "_colDBHost";
            this._colDBHost.OptionsColumn.AllowEdit = false;
            this._colDBHost.Width = 84;
            // 
            // _colPrimaryHost
            // 
            this._colPrimaryHost.Caption = "Primary Host";
            this._colPrimaryHost.Name = "_colPrimaryHost";
            this._colPrimaryHost.OptionsColumn.AllowEdit = false;
            this._colPrimaryHost.Width = 84;
            // 
            // _colSecondaryHost
            // 
            this._colSecondaryHost.Caption = "Secondary Host";
            this._colSecondaryHost.Name = "_colSecondaryHost";
            this._colSecondaryHost.OptionsColumn.AllowEdit = false;
            this._colSecondaryHost.Width = 84;
            // 
            // _colPrimaryDBHost
            // 
            this._colPrimaryDBHost.Caption = "Primary DB Host";
            this._colPrimaryDBHost.Name = "_colPrimaryDBHost";
            this._colPrimaryDBHost.OptionsColumn.AllowEdit = false;
            this._colPrimaryDBHost.Width = 84;
            // 
            // _colSecondaryDBHost
            // 
            this._colSecondaryDBHost.Caption = "Secondary DB Host";
            this._colSecondaryDBHost.Name = "_colSecondaryDBHost";
            this._colSecondaryDBHost.OptionsColumn.AllowEdit = false;
            this._colSecondaryDBHost.Width = 84;
            // 
            // _colState
            // 
            this._colState.Caption = "State";
            this._colState.Name = "_colState";
            this._colState.OptionsColumn.AllowEdit = false;
            this._colState.Visible = true;
            this._colState.VisibleIndex = 4;
            this._colState.Width = 78;
            // 
            // _colDesiredState
            // 
            this._colDesiredState.Caption = "Desired State";
            this._colDesiredState.Name = "_colDesiredState";
            this._colDesiredState.OptionsColumn.AllowEdit = false;
            this._colDesiredState.Visible = true;
            this._colDesiredState.VisibleIndex = 5;
            this._colDesiredState.Width = 78;
            // 
            // _colMessage
            // 
            this._colMessage.Caption = "Message";
            this._colMessage.Name = "_colMessage";
            this._colMessage.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this._colMessage.Visible = true;
            this._colMessage.VisibleIndex = 6;
            this._colMessage.Width = 120;
            // 
            // _colLastChecked
            // 
            this._colLastChecked.Caption = "Last Checked";
            this._colLastChecked.Name = "_colLastChecked";
            this._colLastChecked.OptionsColumn.AllowEdit = false;
            this._colLastChecked.Width = 120;
            // 
            // _colOS
            // 
            this._colOS.Caption = "Operating System";
            this._colOS.Name = "_colOS";
            this._colOS.OptionsColumn.AllowEdit = false;
            this._colOS.Width = 200;
            // 
            // _colVersion
            // 
            this._colVersion.Caption = "Version";
            this._colVersion.Name = "_colVersion";
            this._colVersion.OptionsColumn.AllowEdit = false;
            this._colVersion.Visible = true;
            this._colVersion.VisibleIndex = 7;
            this._colVersion.Width = 45;
            // 
            // _colHasHA
            // 
            this._colHasHA.Caption = "Has HA";
            this._colHasHA.Name = "_colHasHA";
            this._colHasHA.OptionsColumn.AllowEdit = false;
            this._colHasHA.Width = 45;
            // 
            // _repositoryItemImageCbState
            // 
            this._repositoryItemImageCbState.AutoHeight = false;
            this._repositoryItemImageCbState.Name = "_repositoryItemImageCbState";
            // 
            // _imageListLarge
            // 
            this._imageListLarge.ImageSize = new System.Drawing.Size(32, 32);
            this._imageListLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("_imageListLarge.ImageStream")));
            this._imageListLarge.TransparentColor = System.Drawing.Color.Magenta;
            this._imageListLarge.Images.SetKeyName(0, "None32");
            this._imageListLarge.Images.SetKeyName(1, "New32");
            this._imageListLarge.Images.SetKeyName(2, "Properties32");
            this._imageListLarge.Images.SetKeyName(3, "Parameters32");
            this._imageListLarge.Images.SetKeyName(4, "BIM32");
            this._imageListLarge.Images.SetKeyName(5, "AFT32");
            this._imageListLarge.Images.SetKeyName(6, "WebServer32");
            this._imageListLarge.Images.SetKeyName(7, "ActionRecycle32");
            this._imageListLarge.Images.SetKeyName(8, "Database32");
            this._imageListLarge.Images.SetKeyName(9, "CM32");
            this._imageListLarge.Images.SetKeyName(10, "ControlShell32");
            this._imageListLarge.Images.SetKeyName(11, "AgentsDeploy32");
            this._imageListLarge.Images.SetKeyName(12, "Authorizations32");
            this._imageListLarge.Images.SetKeyName(13, "ControlMServerSecurity32");
            this._imageListLarge.Images.SetKeyName(14, "GroupByComponent32");
            this._imageListLarge.Images.SetKeyName(15, "GroupByHost32");
            this._imageListLarge.Images.SetKeyName(16, "OneLevel32");
            this._imageListLarge.Images.SetKeyName(17, "ShowAll32");
            this._imageListLarge.Images.SetKeyName(18, "Debug32");
            this._imageListLarge.Images.SetKeyName(19, "ExceptionAlerts32");
            this._imageListLarge.Images.SetKeyName(20, "Refresh32");
            this._imageListLarge.Images.SetKeyName(21, "HAFallBackToPrimary");
            this._imageListLarge.Images.SetKeyName(22, "HAFailOverToSecondary");
            this._imageListLarge.Images.SetKeyName(23, "ActionUp32");
            this._imageListLarge.Images.SetKeyName(24, "HASetAsPrimary");
            this._imageListLarge.Images.SetKeyName(25, "HAStartReplication");
            this._imageListLarge.Images.SetKeyName(26, "HASwitchToSyncReplication");
            this._imageListLarge.Images.SetKeyName(27, "ClientDeploy");
            this._imageListLarge.Images.SetKeyName(28, "ArchiveIcon.png");
            this._imageListLarge.Images.SetKeyName(31, "WebserverDBL32.png");
            this._imageListLarge.Images.SetKeyName(32, "CompatibilityModeIconLarge.png");
            // 
            // AfterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 504);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.treeList1);
            this.Name = "AfterForm";
            this.Text = "afterForm";
            this.Load += new System.EventHandler(this.AfterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._imageListSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._mainGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._statusComboBoxImagesRepositoryItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._repositoryItemImageCbState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._imageListLarge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView _mainGrid;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn _colType;
        private DevExpress.XtraGrid.Columns.GridColumn _colName;
        private DevExpress.XtraGrid.Columns.GridColumn _colHost;
        private DevExpress.XtraGrid.Columns.GridColumn _colDBHost;
        private DevExpress.XtraGrid.Columns.GridColumn _colPrimaryHost;
        private DevExpress.XtraGrid.Columns.GridColumn _colSecondaryHost;
        private DevExpress.XtraGrid.Columns.GridColumn _colPrimaryDBHost;
        private DevExpress.XtraGrid.Columns.GridColumn _colSecondaryDBHost;
        private DevExpress.XtraGrid.Columns.GridColumn _colState;
        private DevExpress.XtraGrid.Columns.GridColumn _colDesiredState;
        private DevExpress.XtraGrid.Columns.GridColumn _colMessage;
        private DevExpress.XtraGrid.Columns.GridColumn _colLastChecked;
        private DevExpress.XtraGrid.Columns.GridColumn _colOS;
        private DevExpress.XtraGrid.Columns.GridColumn _colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn _colHasHA;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox _repositoryItemImageCbState;
        private DevExpress.Utils.ImageCollection _imageListSmall;
        private DevExpress.Utils.ImageCollection _imageListLarge;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox _statusComboBoxImagesRepositoryItem;
    }
}