namespace DatabaseAssignment11
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label staff_IDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phone_Label;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.workersTab = new System.Windows.Forms.TabPage();
            this.clientTab = new System.Windows.Forms.TabPage();
            this.cPSC285S23BDataSet = new DatabaseAssignment11.CPSC285S23BDataSet();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerTableAdapter = new DatabaseAssignment11.CPSC285S23BDataSetTableAdapters.WorkerTableAdapter();
            this.tableAdapterManager = new DatabaseAssignment11.CPSC285S23BDataSetTableAdapters.TableAdapterManager();
            this.workerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.workerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.staff_IDTextBox = new System.Windows.Forms.TextBox();
            this.phone_TextBox = new System.Windows.Forms.TextBox();
            this.CBStaffName = new System.Windows.Forms.ComboBox();
            this.cPSC285S23BDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.workerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lblScheduleDuration = new System.Windows.Forms.Label();
            this.rbCurrentDay = new System.Windows.Forms.RadioButton();
            this.rbNextWeek = new System.Windows.Forms.RadioButton();
            this.rbNextMonth = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            staff_IDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phone_Label = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.workersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPSC285S23BDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingNavigator)).BeginInit();
            this.workerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPSC285S23BDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.workersTab);
            this.tabControl1.Controls.Add(this.clientTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // workersTab
            // 
            this.workersTab.Controls.Add(this.dataGridView1);
            this.workersTab.Controls.Add(this.rbNextMonth);
            this.workersTab.Controls.Add(this.rbNextWeek);
            this.workersTab.Controls.Add(this.rbCurrentDay);
            this.workersTab.Controls.Add(this.lblScheduleDuration);
            this.workersTab.Controls.Add(this.CBStaffName);
            this.workersTab.Controls.Add(staff_IDLabel);
            this.workersTab.Controls.Add(this.staff_IDTextBox);
            this.workersTab.Controls.Add(nameLabel);
            this.workersTab.Controls.Add(phone_Label);
            this.workersTab.Controls.Add(this.phone_TextBox);
            this.workersTab.Location = new System.Drawing.Point(4, 22);
            this.workersTab.Name = "workersTab";
            this.workersTab.Padding = new System.Windows.Forms.Padding(3);
            this.workersTab.Size = new System.Drawing.Size(792, 424);
            this.workersTab.TabIndex = 0;
            this.workersTab.Text = "workers";
            this.workersTab.UseVisualStyleBackColor = true;
            // 
            // clientTab
            // 
            this.clientTab.Location = new System.Drawing.Point(4, 22);
            this.clientTab.Name = "clientTab";
            this.clientTab.Padding = new System.Windows.Forms.Padding(3);
            this.clientTab.Size = new System.Drawing.Size(792, 424);
            this.clientTab.TabIndex = 1;
            this.clientTab.Text = "clients";
            this.clientTab.UseVisualStyleBackColor = true;
            // 
            // cPSC285S23BDataSet
            // 
            this.cPSC285S23BDataSet.DataSetName = "CPSC285S23BDataSet";
            this.cPSC285S23BDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.cPSC285S23BDataSet;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DatabaseAssignment11.CPSC285S23BDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkerTableAdapter = this.workerTableAdapter;
            // 
            // workerBindingNavigator
            // 
            this.workerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.workerBindingNavigator.BindingSource = this.workerBindingSource;
            this.workerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.workerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.workerBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.workerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.workerBindingNavigatorSaveItem});
            this.workerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.workerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.workerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.workerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.workerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.workerBindingNavigator.Name = "workerBindingNavigator";
            this.workerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.workerBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.workerBindingNavigator.TabIndex = 1;
            this.workerBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // workerBindingNavigatorSaveItem
            // 
            this.workerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.workerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("workerBindingNavigatorSaveItem.Image")));
            this.workerBindingNavigatorSaveItem.Name = "workerBindingNavigatorSaveItem";
            this.workerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.workerBindingNavigatorSaveItem.Text = "Save Data";
            this.workerBindingNavigatorSaveItem.Click += new System.EventHandler(this.workerBindingNavigatorSaveItem_Click_1);
            // 
            // staff_IDLabel
            // 
            staff_IDLabel.AutoSize = true;
            staff_IDLabel.Location = new System.Drawing.Point(41, 25);
            staff_IDLabel.Name = "staff_IDLabel";
            staff_IDLabel.Size = new System.Drawing.Size(46, 13);
            staff_IDLabel.TabIndex = 0;
            staff_IDLabel.Text = "Staff ID:";
            // 
            // staff_IDTextBox
            // 
            this.staff_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerBindingSource, "Staff_ID", true));
            this.staff_IDTextBox.Location = new System.Drawing.Point(95, 22);
            this.staff_IDTextBox.Name = "staff_IDTextBox";
            this.staff_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.staff_IDTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(41, 51);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // phone_Label
            // 
            phone_Label.AutoSize = true;
            phone_Label.Location = new System.Drawing.Point(41, 77);
            phone_Label.Name = "phone_Label";
            phone_Label.Size = new System.Drawing.Size(48, 13);
            phone_Label.TabIndex = 4;
            phone_Label.Text = "Phone#:";
            // 
            // phone_TextBox
            // 
            this.phone_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerBindingSource, "Phone#", true));
            this.phone_TextBox.Location = new System.Drawing.Point(95, 74);
            this.phone_TextBox.Name = "phone_TextBox";
            this.phone_TextBox.Size = new System.Drawing.Size(100, 20);
            this.phone_TextBox.TabIndex = 5;
            // 
            // CBStaffName
            // 
            this.CBStaffName.DataSource = this.workerBindingSource2;
            this.CBStaffName.DisplayMember = "Name";
            this.CBStaffName.FormattingEnabled = true;
            this.CBStaffName.Location = new System.Drawing.Point(95, 48);
            this.CBStaffName.Name = "CBStaffName";
            this.CBStaffName.Size = new System.Drawing.Size(121, 21);
            this.CBStaffName.TabIndex = 6;
            // 
            // cPSC285S23BDataSetBindingSource
            // 
            this.cPSC285S23BDataSetBindingSource.DataSource = this.cPSC285S23BDataSet;
            this.cPSC285S23BDataSetBindingSource.Position = 0;
            // 
            // workerBindingSource1
            // 
            this.workerBindingSource1.DataMember = "Worker";
            this.workerBindingSource1.DataSource = this.cPSC285S23BDataSetBindingSource;
            // 
            // workerBindingSource2
            // 
            this.workerBindingSource2.DataMember = "Worker";
            this.workerBindingSource2.DataSource = this.cPSC285S23BDataSet;
            // 
            // lblScheduleDuration
            // 
            this.lblScheduleDuration.AutoSize = true;
            this.lblScheduleDuration.Location = new System.Drawing.Point(437, 25);
            this.lblScheduleDuration.Name = "lblScheduleDuration";
            this.lblScheduleDuration.Size = new System.Drawing.Size(95, 13);
            this.lblScheduleDuration.TabIndex = 7;
            this.lblScheduleDuration.Text = "Schedule Duration";
            // 
            // rbCurrentDay
            // 
            this.rbCurrentDay.AutoSize = true;
            this.rbCurrentDay.Location = new System.Drawing.Point(440, 46);
            this.rbCurrentDay.Name = "rbCurrentDay";
            this.rbCurrentDay.Size = new System.Drawing.Size(81, 17);
            this.rbCurrentDay.TabIndex = 8;
            this.rbCurrentDay.TabStop = true;
            this.rbCurrentDay.Text = "Current Day";
            this.rbCurrentDay.UseVisualStyleBackColor = true;
            this.rbCurrentDay.CheckedChanged += new System.EventHandler(this.rbCurrentDay_CheckedChanged);
            // 
            // rbNextWeek
            // 
            this.rbNextWeek.AutoSize = true;
            this.rbNextWeek.Location = new System.Drawing.Point(440, 69);
            this.rbNextWeek.Name = "rbNextWeek";
            this.rbNextWeek.Size = new System.Drawing.Size(79, 17);
            this.rbNextWeek.TabIndex = 9;
            this.rbNextWeek.TabStop = true;
            this.rbNextWeek.Text = "Next Week";
            this.rbNextWeek.UseVisualStyleBackColor = true;
            this.rbNextWeek.CheckedChanged += new System.EventHandler(this.rbNextWeek_CheckedChanged);
            // 
            // rbNextMonth
            // 
            this.rbNextMonth.AutoSize = true;
            this.rbNextMonth.Location = new System.Drawing.Point(440, 92);
            this.rbNextMonth.Name = "rbNextMonth";
            this.rbNextMonth.Size = new System.Drawing.Size(80, 17);
            this.rbNextMonth.TabIndex = 10;
            this.rbNextMonth.TabStop = true;
            this.rbNextMonth.Text = "Next Month";
            this.rbNextMonth.UseVisualStyleBackColor = true;
            this.rbNextMonth.CheckedChanged += new System.EventHandler(this.rbNextMonth_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 209);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.workerBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.workersTab.ResumeLayout(false);
            this.workersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPSC285S23BDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingNavigator)).EndInit();
            this.workerBindingNavigator.ResumeLayout(false);
            this.workerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPSC285S23BDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage workersTab;
        private System.Windows.Forms.TabPage clientTab;

        #endregion

        private CPSC285S23BDataSet cPSC285S23BDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private CPSC285S23BDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private CPSC285S23BDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator workerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton workerBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox CBStaffName;
        private System.Windows.Forms.BindingSource workerBindingSource2;
        private System.Windows.Forms.TextBox staff_IDTextBox;
        private System.Windows.Forms.TextBox phone_TextBox;
        private System.Windows.Forms.BindingSource cPSC285S23BDataSetBindingSource;
        private System.Windows.Forms.BindingSource workerBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbNextMonth;
        private System.Windows.Forms.RadioButton rbNextWeek;
        private System.Windows.Forms.RadioButton rbCurrentDay;
        private System.Windows.Forms.Label lblScheduleDuration;
    }
}

