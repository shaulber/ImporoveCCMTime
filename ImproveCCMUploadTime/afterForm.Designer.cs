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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this._mainGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this._colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._mainGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._repositoryItemImageCbState)).BeginInit();
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
            this.treeList1.TabIndex = 0;
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
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Location = new System.Drawing.Point(199, 13);
            this.gridControl1.MainView = this._mainGrid;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this._repositoryItemImageCbState});
            this.gridControl1.Size = new System.Drawing.Size(905, 470);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this._mainGrid});
            // 
            // _mainGrid
            // 
            this._mainGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._colStatus,
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
            // 
            // _colStatus
            // 
            this._colStatus.Caption = "Status";
            this._colStatus.Name = "_colStatus";
            this._colStatus.OptionsColumn.AllowEdit = false;
            this._colStatus.Visible = true;
            this._colStatus.VisibleIndex = 0;
            this._colStatus.Width = 43;
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
            // AfterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 504);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.treeList1);
            this.Name = "AfterForm";
            this.Text = "afterForm";
            this.Load += new System.EventHandler(this.AfterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._mainGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._repositoryItemImageCbState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView _mainGrid;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn _colStatus;
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
    }
}