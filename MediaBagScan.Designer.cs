namespace ConnectToCEMSDatabase
{
    partial class MediaBagScan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaBagScan));
            this.mediaBagScanDataSet = new ConnectToCEMSDatabase.MediaBagScanDataSet();
            this.report_MediaBagScanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report_MediaBagScanTableAdapter = new ConnectToCEMSDatabase.MediaBagScanDataSetTableAdapters.Report_MediaBagScanTableAdapter();
            this.tableAdapterManager = new ConnectToCEMSDatabase.MediaBagScanDataSetTableAdapters.TableAdapterManager();
            this.report_MediaBagScanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.report_MediaBagScanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.report_MediaBagScanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtElectionID = new System.Windows.Forms.TextBox();
            this.lblElectionID = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaBagScanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_MediaBagScanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_MediaBagScanBindingNavigator)).BeginInit();
            this.report_MediaBagScanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report_MediaBagScanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mediaBagScanDataSet
            // 
            this.mediaBagScanDataSet.DataSetName = "MediaBagScanDataSet";
            this.mediaBagScanDataSet.EnforceConstraints = false;
            this.mediaBagScanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report_MediaBagScanBindingSource
            // 
            this.report_MediaBagScanBindingSource.DataMember = "Report_MediaBagScan";
            this.report_MediaBagScanBindingSource.DataSource = this.mediaBagScanDataSet;
            // 
            // report_MediaBagScanTableAdapter
            // 
            this.report_MediaBagScanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = ConnectToCEMSDatabase.MediaBagScanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // report_MediaBagScanBindingNavigator
            // 
            this.report_MediaBagScanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.report_MediaBagScanBindingNavigator.BindingSource = this.report_MediaBagScanBindingSource;
            this.report_MediaBagScanBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.report_MediaBagScanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.report_MediaBagScanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.report_MediaBagScanBindingNavigatorSaveItem});
            this.report_MediaBagScanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.report_MediaBagScanBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.report_MediaBagScanBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.report_MediaBagScanBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.report_MediaBagScanBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.report_MediaBagScanBindingNavigator.Name = "report_MediaBagScanBindingNavigator";
            this.report_MediaBagScanBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.report_MediaBagScanBindingNavigator.Size = new System.Drawing.Size(1039, 25);
            this.report_MediaBagScanBindingNavigator.TabIndex = 0;
            this.report_MediaBagScanBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // report_MediaBagScanBindingNavigatorSaveItem
            // 
            this.report_MediaBagScanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.report_MediaBagScanBindingNavigatorSaveItem.Enabled = false;
            this.report_MediaBagScanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("report_MediaBagScanBindingNavigatorSaveItem.Image")));
            this.report_MediaBagScanBindingNavigatorSaveItem.Name = "report_MediaBagScanBindingNavigatorSaveItem";
            this.report_MediaBagScanBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.report_MediaBagScanBindingNavigatorSaveItem.Text = "Save Data";
            this.report_MediaBagScanBindingNavigatorSaveItem.Click += new System.EventHandler(this.report_MediaBagScanBindingNavigatorSaveItem_Click);
            // 
            // report_MediaBagScanDataGridView
            // 
            this.report_MediaBagScanDataGridView.AutoGenerateColumns = false;
            this.report_MediaBagScanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.report_MediaBagScanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.report_MediaBagScanDataGridView.DataSource = this.report_MediaBagScanBindingSource;
            this.report_MediaBagScanDataGridView.Location = new System.Drawing.Point(12, 75);
            this.report_MediaBagScanDataGridView.Name = "report_MediaBagScanDataGridView";
            this.report_MediaBagScanDataGridView.Size = new System.Drawing.Size(992, 224);
            this.report_MediaBagScanDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ElectionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ElectionID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LocationID";
            this.dataGridViewTextBoxColumn2.HeaderText = "LocationID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MediaBagNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "MediaBagNumber";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CellPhone";
            this.dataGridViewTextBoxColumn4.HeaderText = "CellPhone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PalmPilot";
            this.dataGridViewTextBoxColumn5.HeaderText = "PalmPilot";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ModifiedUser";
            this.dataGridViewTextBoxColumn6.HeaderText = "ModifiedUser";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LocationNumber";
            this.dataGridViewTextBoxColumn7.HeaderText = "LocationNumber";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RegisteredVoters";
            this.dataGridViewTextBoxColumn8.HeaderText = "RegisteredVoters";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // txtElectionID
            // 
            this.txtElectionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElectionID.Location = new System.Drawing.Point(215, 39);
            this.txtElectionID.Name = "txtElectionID";
            this.txtElectionID.Size = new System.Drawing.Size(100, 26);
            this.txtElectionID.TabIndex = 3;
            this.txtElectionID.TextChanged += new System.EventHandler(this.txtElectionID_TextChanged);
            // 
            // lblElectionID
            // 
            this.lblElectionID.AutoSize = true;
            this.lblElectionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectionID.Location = new System.Drawing.Point(12, 42);
            this.lblElectionID.Name = "lblElectionID";
            this.lblElectionID.Size = new System.Drawing.Size(197, 20);
            this.lblElectionID.TabIndex = 4;
            this.lblElectionID.Text = "Enter Valid ElectionID: ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(883, 306);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MediaBagScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 338);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblElectionID);
            this.Controls.Add(this.txtElectionID);
            this.Controls.Add(this.report_MediaBagScanDataGridView);
            this.Controls.Add(this.report_MediaBagScanBindingNavigator);
            this.Name = "MediaBagScan";
            this.Text = "MediaBagScan";
            ((System.ComponentModel.ISupportInitialize)(this.mediaBagScanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_MediaBagScanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_MediaBagScanBindingNavigator)).EndInit();
            this.report_MediaBagScanBindingNavigator.ResumeLayout(false);
            this.report_MediaBagScanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report_MediaBagScanDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MediaBagScanDataSet mediaBagScanDataSet;
        private System.Windows.Forms.BindingSource report_MediaBagScanBindingSource;
        private MediaBagScanDataSetTableAdapters.Report_MediaBagScanTableAdapter report_MediaBagScanTableAdapter;
        private MediaBagScanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator report_MediaBagScanBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton report_MediaBagScanBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView report_MediaBagScanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox txtElectionID;
        private System.Windows.Forms.Label lblElectionID;
        private System.Windows.Forms.Button btnExit;
    }
}