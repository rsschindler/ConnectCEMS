namespace ConnectToCEMSDatabase
{
    partial class MediaBagAdd
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
            System.Windows.Forms.Label locationNumberLabel;
            System.Windows.Forms.Label mediaBagNumberLabel;
            System.Windows.Forms.Label cellPhoneLabel;
            System.Windows.Forms.Label palmPilotLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaBagAdd));
            this.txtElectionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.electionIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.electionIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.txtLocationNumber = new System.Windows.Forms.TextBox();
            this.txtMediaBagNumber = new System.Windows.Forms.TextBox();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.txtPalmPilot = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblLocationCount = new System.Windows.Forms.Label();
            locationNumberLabel = new System.Windows.Forms.Label();
            mediaBagNumberLabel = new System.Windows.Forms.Label();
            cellPhoneLabel = new System.Windows.Forms.Label();
            palmPilotLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaBagScanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_MediaBagScanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_MediaBagScanBindingNavigator)).BeginInit();
            this.report_MediaBagScanBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // locationNumberLabel
            // 
            locationNumberLabel.AutoSize = true;
            locationNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationNumberLabel.Location = new System.Drawing.Point(82, 88);
            locationNumberLabel.Name = "locationNumberLabel";
            locationNumberLabel.Size = new System.Drawing.Size(136, 17);
            locationNumberLabel.TabIndex = 4;
            locationNumberLabel.Text = "Location Number:";
            // 
            // mediaBagNumberLabel
            // 
            mediaBagNumberLabel.AutoSize = true;
            mediaBagNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mediaBagNumberLabel.Location = new System.Drawing.Point(72, 120);
            mediaBagNumberLabel.Name = "mediaBagNumberLabel";
            mediaBagNumberLabel.Size = new System.Drawing.Size(150, 17);
            mediaBagNumberLabel.TabIndex = 6;
            mediaBagNumberLabel.Text = "Media Bag Number:";
            // 
            // cellPhoneLabel
            // 
            cellPhoneLabel.AutoSize = true;
            cellPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cellPhoneLabel.Location = new System.Drawing.Point(112, 157);
            cellPhoneLabel.Name = "cellPhoneLabel";
            cellPhoneLabel.Size = new System.Drawing.Size(91, 17);
            cellPhoneLabel.TabIndex = 8;
            cellPhoneLabel.Text = "Cell Phone:";
            // 
            // palmPilotLabel
            // 
            palmPilotLabel.AutoSize = true;
            palmPilotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            palmPilotLabel.Location = new System.Drawing.Point(117, 188);
            palmPilotLabel.Name = "palmPilotLabel";
            palmPilotLabel.Size = new System.Drawing.Size(85, 17);
            palmPilotLabel.TabIndex = 10;
            palmPilotLabel.Text = "Palm Pilot:";
            // 
            // txtElectionID
            // 
            this.txtElectionID.AcceptsReturn = true;
            this.txtElectionID.AcceptsTab = true;
            this.txtElectionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElectionID.Location = new System.Drawing.Point(224, 29);
            this.txtElectionID.MaxLength = 3;
            this.txtElectionID.Name = "txtElectionID";
            this.txtElectionID.Size = new System.Drawing.Size(108, 26);
            this.txtElectionID.TabIndex = 0;
            this.txtElectionID.Leave += new System.EventHandler(this.txtElectionID_LostFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Enter ElectionID:";
            // 
            // mediaBagScanDataSet
            // 
            this.mediaBagScanDataSet.DataSetName = "MediaBagScanDataSet";
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
            this.report_MediaBagScanBindingNavigator.Size = new System.Drawing.Size(355, 25);
            this.report_MediaBagScanBindingNavigator.TabIndex = 2;
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
            // 
            // electionIDToolStripLabel
            // 
            this.electionIDToolStripLabel.Name = "electionIDToolStripLabel";
            this.electionIDToolStripLabel.Size = new System.Drawing.Size(63, 22);
            this.electionIDToolStripLabel.Text = "ElectionID:";
            // 
            // electionIDToolStripTextBox
            // 
            this.electionIDToolStripTextBox.Name = "electionIDToolStripTextBox";
            this.electionIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // *****   NOTE!  MODIFIED ALL FIELD Designers so could scan whole field to allow manual tab to next control for field validation  ****
            // txtLocationNumber  
            // 
            this.txtLocationNumber.AcceptsReturn = true;
            this.txtLocationNumber.AcceptsTab = true;
            this.txtLocationNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.report_MediaBagScanBindingSource, "LocationNumber", true));
            this.txtLocationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationNumber.Location = new System.Drawing.Point(232, 85);
            this.txtLocationNumber.MaxLength = 3;
            this.txtLocationNumber.Name = "txtLocationNumber";
            this.txtLocationNumber.Size = new System.Drawing.Size(100, 23);
            this.txtLocationNumber.TabIndex = 1;
            this.txtLocationNumber.TextChanged += new System.EventHandler(this.txtLocationNumber_LostFocus);
            this.txtLocationNumber.Leave += new System.EventHandler(this.txtLocationNumber_LostFocus);
            // 
            // txtMediaBagNumber
            // 
            this.txtMediaBagNumber.AcceptsReturn = true;
            this.txtMediaBagNumber.AcceptsTab = true;
            this.txtMediaBagNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.report_MediaBagScanBindingSource, "MediaBagNumber", true));
            this.txtMediaBagNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaBagNumber.Location = new System.Drawing.Point(232, 117);
            this.txtMediaBagNumber.MaxLength = 10;
            this.txtMediaBagNumber.Name = "txtMediaBagNumber";
            this.txtMediaBagNumber.Size = new System.Drawing.Size(100, 23);
            this.txtMediaBagNumber.TabIndex = 2;
            this.txtMediaBagNumber.Leave += new System.EventHandler(this.txtMediaBagNumber_LostFocus);
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.AcceptsReturn = true;
            this.txtCellPhone.AcceptsTab = true;
            this.txtCellPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.report_MediaBagScanBindingSource, "CellPhone", true));
            this.txtCellPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellPhone.Location = new System.Drawing.Point(232, 150);
            this.txtCellPhone.MaxLength = 10;
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(100, 23);
            this.txtCellPhone.TabIndex = 3;
            this.txtCellPhone.Leave += new System.EventHandler(this.txtCellPhone_TextChanged);
            // 
            // txtPalmPilot
            // 
            this.txtPalmPilot.AcceptsReturn = true;
            this.txtPalmPilot.AcceptsTab = true;
            this.txtPalmPilot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.report_MediaBagScanBindingSource, "PalmPilot", true));
            this.txtPalmPilot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalmPilot.Location = new System.Drawing.Point(232, 185);
            this.txtPalmPilot.MaxLength = 10;
            this.txtPalmPilot.Name = "txtPalmPilot";
            this.txtPalmPilot.ShortcutsEnabled = false;
            this.txtPalmPilot.Size = new System.Drawing.Size(100, 23);
            this.txtPalmPilot.TabIndex = 4;
            this.txtPalmPilot.Tag = "";
            this.txtPalmPilot.Leave += new System.EventHandler(this.txtPalmPilot_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(257, 311);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(355, 346);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 353;
            this.lineShape1.Y1 = 63;
            this.lineShape1.Y2 = 63;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(115, 261);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 7;
            // 
            // lblLocationCount
            // 
            this.lblLocationCount.AutoSize = true;
            this.lblLocationCount.Location = new System.Drawing.Point(27, 264);
            this.lblLocationCount.Name = "lblLocationCount";
            this.lblLocationCount.Size = new System.Drawing.Size(82, 13);
            this.lblLocationCount.TabIndex = 15;
            this.lblLocationCount.Text = "Location Count:";
            // 
            // MediaBagAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 346);
            this.Controls.Add(this.lblLocationCount);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(palmPilotLabel);
            this.Controls.Add(this.txtPalmPilot);
            this.Controls.Add(cellPhoneLabel);
            this.Controls.Add(this.txtCellPhone);
            this.Controls.Add(mediaBagNumberLabel);
            this.Controls.Add(this.txtMediaBagNumber);
            this.Controls.Add(locationNumberLabel);
            this.Controls.Add(this.txtLocationNumber);
            this.Controls.Add(this.report_MediaBagScanBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtElectionID);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "MediaBagAdd";
            this.Text = "MediaBagAdd";
            ((System.ComponentModel.ISupportInitialize)(this.mediaBagScanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_MediaBagScanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_MediaBagScanBindingNavigator)).EndInit();
            this.report_MediaBagScanBindingNavigator.ResumeLayout(false);
            this.report_MediaBagScanBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElectionID;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.ToolStripLabel electionIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox electionIDToolStripTextBox;
        private System.Windows.Forms.TextBox txtLocationNumber;
        private System.Windows.Forms.TextBox txtMediaBagNumber;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.TextBox txtPalmPilot;
        private System.Windows.Forms.Button btnExit;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblLocationCount;
    }
}