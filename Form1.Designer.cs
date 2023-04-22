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
            System.Windows.Forms.Label client_IDLabel;
            System.Windows.Forms.Label clientNameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label staff_IDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phone_Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.workersTab = new System.Windows.Forms.TabPage();
            this.workerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.wbindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cPSC285S23BDataSet = new DatabaseAssignment11.CPSC285S23BDataSet();
            this.wbindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.wbindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.wbindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.wbindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.wbindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.wbindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.wbindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.wbindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.wbindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.wbindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.workerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbNextMonth = new System.Windows.Forms.RadioButton();
            this.rbNextWeek = new System.Windows.Forms.RadioButton();
            this.rbCurrentDay = new System.Windows.Forms.RadioButton();
            this.lblScheduleDuration = new System.Windows.Forms.Label();
            this.CBStaffName = new System.Windows.Forms.ComboBox();
            this.workerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.staff_IDTextBox = new System.Windows.Forms.TextBox();
            this.phone_TextBox = new System.Windows.Forms.TextBox();
            this.clientTab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.classDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientNameCmbBox = new System.Windows.Forms.ComboBox();
            this.clientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.cbindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cbindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.cbindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cbindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.cbindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.cbindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cbindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.cbindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.cbindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.cbindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.client_IDTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.clientTableAdapter = new DatabaseAssignment11.CPSC285S23BDataSetTableAdapters.ClientTableAdapter();
            this.classTableAdapter = new DatabaseAssignment11.CPSC285S23BDataSetTableAdapters.ClassTableAdapter();
            this.workerTableAdapter = new DatabaseAssignment11.CPSC285S23BDataSetTableAdapters.WorkerTableAdapter();
            this.tableAdapterManager = new DatabaseAssignment11.CPSC285S23BDataSetTableAdapters.TableAdapterManager();
            this.cPSC285S23BDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            client_IDLabel = new System.Windows.Forms.Label();
            clientNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            staff_IDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phone_Label = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.workersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingNavigator)).BeginInit();
            this.workerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPSC285S23BDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource2)).BeginInit();
            this.clientTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).BeginInit();
            this.clientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPSC285S23BDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // client_IDLabel
            // 
            client_IDLabel.AutoSize = true;
            client_IDLabel.Location = new System.Drawing.Point(28, 76);
            client_IDLabel.Name = "client_IDLabel";
            client_IDLabel.Size = new System.Drawing.Size(99, 25);
            client_IDLabel.TabIndex = 0;
            client_IDLabel.Text = "Client ID:";
            // 
            // clientNameLabel
            // 
            clientNameLabel.AutoSize = true;
            clientNameLabel.Location = new System.Drawing.Point(28, 113);
            clientNameLabel.Name = "clientNameLabel";
            clientNameLabel.Size = new System.Drawing.Size(74, 25);
            clientNameLabel.TabIndex = 2;
            clientNameLabel.Text = "Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(28, 150);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(89, 25);
            genderLabel.TabIndex = 4;
            genderLabel.Text = "Gender:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(28, 187);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(56, 25);
            ageLabel.TabIndex = 6;
            ageLabel.Text = "Age:";
            // 
            // staff_IDLabel
            // 
            staff_IDLabel.AutoSize = true;
            staff_IDLabel.Location = new System.Drawing.Point(29, 72);
            staff_IDLabel.Name = "staff_IDLabel";
            staff_IDLabel.Size = new System.Drawing.Size(88, 25);
            staff_IDLabel.TabIndex = 0;
            staff_IDLabel.Text = "Staff ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(29, 109);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(74, 25);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // phone_Label
            // 
            phone_Label.AutoSize = true;
            phone_Label.Location = new System.Drawing.Point(29, 148);
            phone_Label.Name = "phone_Label";
            phone_Label.Size = new System.Drawing.Size(92, 25);
            phone_Label.TabIndex = 4;
            phone_Label.Text = "Phone#:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.workersTab);
            this.tabControl1.Controls.Add(this.clientTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1290, 988);
            this.tabControl1.TabIndex = 0;
            // 
            // workersTab
            // 
            this.workersTab.Controls.Add(this.workerBindingNavigator);
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
            this.workersTab.Location = new System.Drawing.Point(8, 39);
            this.workersTab.Margin = new System.Windows.Forms.Padding(6);
            this.workersTab.Name = "workersTab";
            this.workersTab.Padding = new System.Windows.Forms.Padding(6);
            this.workersTab.Size = new System.Drawing.Size(1274, 941);
            this.workersTab.TabIndex = 0;
            this.workersTab.Text = "workers";
            this.workersTab.UseVisualStyleBackColor = true;
            // 
            // workerBindingNavigator
            // 
            this.workerBindingNavigator.AddNewItem = this.wbindingNavigatorAddNewItem;
            this.workerBindingNavigator.BindingSource = this.workerBindingSource;
            this.workerBindingNavigator.CountItem = this.wbindingNavigatorCountItem;
            this.workerBindingNavigator.DeleteItem = this.wbindingNavigatorDeleteItem;
            this.workerBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.workerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.wbindingNavigatorMoveFirstItem, this.wbindingNavigatorMovePreviousItem, this.wbindingNavigatorSeparator, this.wbindingNavigatorPositionItem, this.wbindingNavigatorCountItem, this.wbindingNavigatorSeparator1, this.wbindingNavigatorMoveNextItem, this.wbindingNavigatorMoveLastItem, this.wbindingNavigatorSeparator2, this.wbindingNavigatorAddNewItem, this.wbindingNavigatorDeleteItem, this.workerBindingNavigatorSaveItem });
            this.workerBindingNavigator.Location = new System.Drawing.Point(9, 6);
            this.workerBindingNavigator.MoveFirstItem = this.wbindingNavigatorMoveFirstItem;
            this.workerBindingNavigator.MoveLastItem = this.wbindingNavigatorMoveLastItem;
            this.workerBindingNavigator.MoveNextItem = this.wbindingNavigatorMoveNextItem;
            this.workerBindingNavigator.MovePreviousItem = this.wbindingNavigatorMovePreviousItem;
            this.workerBindingNavigator.Name = "workerBindingNavigator";
            this.workerBindingNavigator.PositionItem = this.wbindingNavigatorPositionItem;
            this.workerBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.workerBindingNavigator.Size = new System.Drawing.Size(314, 35);
            this.workerBindingNavigator.Stretch = true;
            this.workerBindingNavigator.TabIndex = 1;
            this.workerBindingNavigator.Text = "bindingNavigator1";
            // 
            // wbindingNavigatorAddNewItem
            // 
            this.wbindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wbindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("wbindingNavigatorAddNewItem.Image")));
            this.wbindingNavigatorAddNewItem.Name = "wbindingNavigatorAddNewItem";
            this.wbindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.wbindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 32);
            this.wbindingNavigatorAddNewItem.Text = "Add new";
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.cPSC285S23BDataSet;
            // 
            // cPSC285S23BDataSet
            // 
            this.cPSC285S23BDataSet.DataSetName = "CPSC285S23BDataSet";
            this.cPSC285S23BDataSet.Namespace = "http://tempuri.org/CPSC285S23BDataSet.xsd";
            this.cPSC285S23BDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wbindingNavigatorCountItem
            // 
            this.wbindingNavigatorCountItem.Name = "wbindingNavigatorCountItem";
            this.wbindingNavigatorCountItem.Size = new System.Drawing.Size(71, 32);
            this.wbindingNavigatorCountItem.Text = "of {0}";
            this.wbindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // wbindingNavigatorDeleteItem
            // 
            this.wbindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wbindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("wbindingNavigatorDeleteItem.Image")));
            this.wbindingNavigatorDeleteItem.Name = "wbindingNavigatorDeleteItem";
            this.wbindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.wbindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 32);
            this.wbindingNavigatorDeleteItem.Text = "Delete";
            // 
            // wbindingNavigatorMoveFirstItem
            // 
            this.wbindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wbindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("wbindingNavigatorMoveFirstItem.Image")));
            this.wbindingNavigatorMoveFirstItem.Name = "wbindingNavigatorMoveFirstItem";
            this.wbindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.wbindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 32);
            this.wbindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // wbindingNavigatorMovePreviousItem
            // 
            this.wbindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wbindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("wbindingNavigatorMovePreviousItem.Image")));
            this.wbindingNavigatorMovePreviousItem.Name = "wbindingNavigatorMovePreviousItem";
            this.wbindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.wbindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 32);
            this.wbindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // wbindingNavigatorSeparator
            // 
            this.wbindingNavigatorSeparator.Name = "wbindingNavigatorSeparator";
            this.wbindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // wbindingNavigatorPositionItem
            // 
            this.wbindingNavigatorPositionItem.AccessibleName = "Position";
            this.wbindingNavigatorPositionItem.AutoSize = false;
            this.wbindingNavigatorPositionItem.Name = "wbindingNavigatorPositionItem";
            this.wbindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.wbindingNavigatorPositionItem.Text = "0";
            this.wbindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // wbindingNavigatorSeparator1
            // 
            this.wbindingNavigatorSeparator1.Name = "wbindingNavigatorSeparator1";
            this.wbindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // wbindingNavigatorMoveNextItem
            // 
            this.wbindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wbindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("wbindingNavigatorMoveNextItem.Image")));
            this.wbindingNavigatorMoveNextItem.Name = "wbindingNavigatorMoveNextItem";
            this.wbindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.wbindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 32);
            this.wbindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // wbindingNavigatorMoveLastItem
            // 
            this.wbindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wbindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("wbindingNavigatorMoveLastItem.Image")));
            this.wbindingNavigatorMoveLastItem.Name = "wbindingNavigatorMoveLastItem";
            this.wbindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.wbindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 32);
            this.wbindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // wbindingNavigatorSeparator2
            // 
            this.wbindingNavigatorSeparator2.Name = "wbindingNavigatorSeparator2";
            this.wbindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // workerBindingNavigatorSaveItem
            // 
            this.workerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.workerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("workerBindingNavigatorSaveItem.Image")));
            this.workerBindingNavigatorSaveItem.Name = "workerBindingNavigatorSaveItem";
            this.workerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 32);
            this.workerBindingNavigatorSaveItem.Text = "Save Data";
            this.workerBindingNavigatorSaveItem.Click += new System.EventHandler(this.workerBindingNavigatorSaveItem_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1256, 605);
            this.dataGridView1.TabIndex = 11;
            // 
            // rbNextMonth
            // 
            this.rbNextMonth.AutoSize = true;
            this.rbNextMonth.Location = new System.Drawing.Point(1017, 227);
            this.rbNextMonth.Name = "rbNextMonth";
            this.rbNextMonth.Size = new System.Drawing.Size(153, 29);
            this.rbNextMonth.TabIndex = 10;
            this.rbNextMonth.TabStop = true;
            this.rbNextMonth.Text = "Next Month";
            this.rbNextMonth.UseVisualStyleBackColor = true;
            this.rbNextMonth.CheckedChanged += new System.EventHandler(this.rbNextMonth_CheckedChanged);
            // 
            // rbNextWeek
            // 
            this.rbNextWeek.AutoSize = true;
            this.rbNextWeek.Location = new System.Drawing.Point(1017, 178);
            this.rbNextWeek.Name = "rbNextWeek";
            this.rbNextWeek.Size = new System.Drawing.Size(148, 29);
            this.rbNextWeek.TabIndex = 9;
            this.rbNextWeek.TabStop = true;
            this.rbNextWeek.Text = "Next Week";
            this.rbNextWeek.UseVisualStyleBackColor = true;
            this.rbNextWeek.CheckedChanged += new System.EventHandler(this.rbNextWeek_CheckedChanged);
            // 
            // rbCurrentDay
            // 
            this.rbCurrentDay.AutoSize = true;
            this.rbCurrentDay.Location = new System.Drawing.Point(1017, 132);
            this.rbCurrentDay.Name = "rbCurrentDay";
            this.rbCurrentDay.Size = new System.Drawing.Size(158, 29);
            this.rbCurrentDay.TabIndex = 8;
            this.rbCurrentDay.TabStop = true;
            this.rbCurrentDay.Text = "Current Day";
            this.rbCurrentDay.UseVisualStyleBackColor = true;
            this.rbCurrentDay.CheckedChanged += new System.EventHandler(this.rbCurrentDay_CheckedChanged);
            // 
            // lblScheduleDuration
            // 
            this.lblScheduleDuration.AutoSize = true;
            this.lblScheduleDuration.Location = new System.Drawing.Point(1017, 80);
            this.lblScheduleDuration.Name = "lblScheduleDuration";
            this.lblScheduleDuration.Size = new System.Drawing.Size(189, 25);
            this.lblScheduleDuration.TabIndex = 7;
            this.lblScheduleDuration.Text = "Schedule Duration";
            // 
            // CBStaffName
            // 
            this.CBStaffName.DataSource = this.workerBindingSource2;
            this.CBStaffName.DisplayMember = "Name";
            this.CBStaffName.FormattingEnabled = true;
            this.CBStaffName.Location = new System.Drawing.Point(156, 106);
            this.CBStaffName.Name = "CBStaffName";
            this.CBStaffName.Size = new System.Drawing.Size(212, 33);
            this.CBStaffName.TabIndex = 6;
            // 
            // workerBindingSource2
            // 
            this.workerBindingSource2.DataMember = "Worker";
            this.workerBindingSource2.DataSource = this.cPSC285S23BDataSet;
            // 
            // staff_IDTextBox
            // 
            this.staff_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerBindingSource, "Staff_ID", true));
            this.staff_IDTextBox.Location = new System.Drawing.Point(156, 69);
            this.staff_IDTextBox.Name = "staff_IDTextBox";
            this.staff_IDTextBox.Size = new System.Drawing.Size(212, 31);
            this.staff_IDTextBox.TabIndex = 1;
            // 
            // phone_TextBox
            // 
            this.phone_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerBindingSource, "Phone#", true));
            this.phone_TextBox.Location = new System.Drawing.Point(156, 145);
            this.phone_TextBox.Name = "phone_TextBox";
            this.phone_TextBox.Size = new System.Drawing.Size(212, 31);
            this.phone_TextBox.TabIndex = 5;
            // 
            // clientTab
            // 
            this.clientTab.Controls.Add(this.button2);
            this.clientTab.Controls.Add(this.button1);
            this.clientTab.Controls.Add(this.classDataGridView);
            this.clientTab.Controls.Add(this.clientNameCmbBox);
            this.clientTab.Controls.Add(this.clientBindingNavigator);
            this.clientTab.Controls.Add(client_IDLabel);
            this.clientTab.Controls.Add(this.client_IDTextBox);
            this.clientTab.Controls.Add(clientNameLabel);
            this.clientTab.Controls.Add(genderLabel);
            this.clientTab.Controls.Add(this.genderTextBox);
            this.clientTab.Controls.Add(ageLabel);
            this.clientTab.Controls.Add(this.ageTextBox);
            this.clientTab.Location = new System.Drawing.Point(8, 39);
            this.clientTab.Margin = new System.Windows.Forms.Padding(6);
            this.clientTab.Name = "clientTab";
            this.clientTab.Padding = new System.Windows.Forms.Padding(6);
            this.clientTab.Size = new System.Drawing.Size(1274, 941);
            this.clientTab.TabIndex = 1;
            this.clientTab.Text = "clients";
            this.clientTab.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(911, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add Class";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(911, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Client";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // classDataGridView
            // 
            this.classDataGridView.AutoGenerateColumns = false;
            this.classDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dataGridViewTextBoxColumn1, this.dataGridViewTextBoxColumn2, this.dataGridViewTextBoxColumn3, this.dataGridViewTextBoxColumn4, this.dataGridViewTextBoxColumn5 });
            this.classDataGridView.DataSource = this.classBindingSource;
            this.classDataGridView.Location = new System.Drawing.Point(38, 277);
            this.classDataGridView.Name = "classDataGridView";
            this.classDataGridView.RowHeadersWidth = 82;
            this.classDataGridView.RowTemplate.Height = 33;
            this.classDataGridView.Size = new System.Drawing.Size(1406, 471);
            this.classDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Class_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Class_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StartTime";
            this.dataGridViewTextBoxColumn3.HeaderText = "StartTime";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Staff_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Staff_ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Client_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Client_ID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class_Client_Client_ID_fk";
            this.classBindingSource.DataSource = this.clientBindingSource;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.cPSC285S23BDataSet;
            // 
            // clientNameCmbBox
            // 
            this.clientNameCmbBox.DataSource = this.clientBindingSource;
            this.clientNameCmbBox.DisplayMember = "Name";
            this.clientNameCmbBox.FormattingEnabled = true;
            this.clientNameCmbBox.Location = new System.Drawing.Point(133, 110);
            this.clientNameCmbBox.Name = "clientNameCmbBox";
            this.clientNameCmbBox.Size = new System.Drawing.Size(264, 33);
            this.clientNameCmbBox.TabIndex = 8;
            // 
            // clientBindingNavigator
            // 
            this.clientBindingNavigator.AddNewItem = this.cbindingNavigatorAddNewItem;
            this.clientBindingNavigator.BindingSource = this.clientBindingSource;
            this.clientBindingNavigator.CountItem = this.cbindingNavigatorCountItem;
            this.clientBindingNavigator.DeleteItem = this.cbindingNavigatorDeleteItem;
            this.clientBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.clientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.cbindingNavigatorMoveFirstItem, this.cbindingNavigatorMovePreviousItem, this.cbindingNavigatorSeparator, this.cbindingNavigatorPositionItem, this.cbindingNavigatorCountItem, this.cbindingNavigatorSeparator1, this.cbindingNavigatorMoveNextItem, this.cbindingNavigatorMoveLastItem, this.cbindingNavigatorSeparator2, this.cbindingNavigatorAddNewItem, this.cbindingNavigatorDeleteItem, this.clientBindingNavigatorSaveItem });
            this.clientBindingNavigator.Location = new System.Drawing.Point(17, 6);
            this.clientBindingNavigator.MoveFirstItem = this.cbindingNavigatorMoveFirstItem;
            this.clientBindingNavigator.MoveLastItem = this.cbindingNavigatorMoveLastItem;
            this.clientBindingNavigator.MoveNextItem = this.cbindingNavigatorMoveNextItem;
            this.clientBindingNavigator.MovePreviousItem = this.cbindingNavigatorMovePreviousItem;
            this.clientBindingNavigator.Name = "clientBindingNavigator";
            this.clientBindingNavigator.PositionItem = this.cbindingNavigatorPositionItem;
            this.clientBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.clientBindingNavigator.Size = new System.Drawing.Size(314, 39);
            this.clientBindingNavigator.TabIndex = 1;
            this.clientBindingNavigator.Text = "bindingNavigator1";
            // 
            // cbindingNavigatorAddNewItem
            // 
            this.cbindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cbindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("cbindingNavigatorAddNewItem.Image")));
            this.cbindingNavigatorAddNewItem.Name = "cbindingNavigatorAddNewItem";
            this.cbindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.cbindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 36);
            this.cbindingNavigatorAddNewItem.Text = "Add new";
            // 
            // cbindingNavigatorCountItem
            // 
            this.cbindingNavigatorCountItem.Name = "cbindingNavigatorCountItem";
            this.cbindingNavigatorCountItem.Size = new System.Drawing.Size(71, 36);
            this.cbindingNavigatorCountItem.Text = "of {0}";
            this.cbindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // cbindingNavigatorDeleteItem
            // 
            this.cbindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cbindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("cbindingNavigatorDeleteItem.Image")));
            this.cbindingNavigatorDeleteItem.Name = "cbindingNavigatorDeleteItem";
            this.cbindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.cbindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 36);
            this.cbindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cbindingNavigatorMoveFirstItem
            // 
            this.cbindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cbindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("cbindingNavigatorMoveFirstItem.Image")));
            this.cbindingNavigatorMoveFirstItem.Name = "cbindingNavigatorMoveFirstItem";
            this.cbindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.cbindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 36);
            this.cbindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // cbindingNavigatorMovePreviousItem
            // 
            this.cbindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cbindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("cbindingNavigatorMovePreviousItem.Image")));
            this.cbindingNavigatorMovePreviousItem.Name = "cbindingNavigatorMovePreviousItem";
            this.cbindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.cbindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 36);
            this.cbindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // cbindingNavigatorSeparator
            // 
            this.cbindingNavigatorSeparator.Name = "cbindingNavigatorSeparator";
            this.cbindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // cbindingNavigatorPositionItem
            // 
            this.cbindingNavigatorPositionItem.AccessibleName = "Position";
            this.cbindingNavigatorPositionItem.AutoSize = false;
            this.cbindingNavigatorPositionItem.Name = "cbindingNavigatorPositionItem";
            this.cbindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.cbindingNavigatorPositionItem.Text = "0";
            this.cbindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // cbindingNavigatorSeparator1
            // 
            this.cbindingNavigatorSeparator1.Name = "cbindingNavigatorSeparator1";
            this.cbindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // cbindingNavigatorMoveNextItem
            // 
            this.cbindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cbindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("cbindingNavigatorMoveNextItem.Image")));
            this.cbindingNavigatorMoveNextItem.Name = "cbindingNavigatorMoveNextItem";
            this.cbindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.cbindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 36);
            this.cbindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // cbindingNavigatorMoveLastItem
            // 
            this.cbindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cbindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("cbindingNavigatorMoveLastItem.Image")));
            this.cbindingNavigatorMoveLastItem.Name = "cbindingNavigatorMoveLastItem";
            this.cbindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.cbindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 36);
            this.cbindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // cbindingNavigatorSeparator2
            // 
            this.cbindingNavigatorSeparator2.Name = "cbindingNavigatorSeparator2";
            this.cbindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // clientBindingNavigatorSaveItem
            // 
            this.clientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientBindingNavigatorSaveItem.Image")));
            this.clientBindingNavigatorSaveItem.Name = "clientBindingNavigatorSaveItem";
            this.clientBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 36);
            this.clientBindingNavigatorSaveItem.Text = "Save Data";
            this.clientBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientBindingNavigatorSaveItem_Click);
            // 
            // client_IDTextBox
            // 
            this.client_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Client_ID", true));
            this.client_IDTextBox.Location = new System.Drawing.Point(133, 73);
            this.client_IDTextBox.Name = "client_IDTextBox";
            this.client_IDTextBox.Size = new System.Drawing.Size(264, 31);
            this.client_IDTextBox.TabIndex = 1;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(133, 147);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(264, 31);
            this.genderTextBox.TabIndex = 5;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(133, 184);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(264, 31);
            this.ageTextBox.TabIndex = 7;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.UpdateOrder = DatabaseAssignment11.CPSC285S23BDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkerTableAdapter = null;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 988);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.workersTab.ResumeLayout(false);
            this.workersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingNavigator)).EndInit();
            this.workerBindingNavigator.ResumeLayout(false);
            this.workerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPSC285S23BDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource2)).EndInit();
            this.clientTab.ResumeLayout(false);
            this.clientTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingNavigator)).EndInit();
            this.clientBindingNavigator.ResumeLayout(false);
            this.clientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPSC285S23BDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage workersTab;
        private System.Windows.Forms.TabPage clientTab;

        #endregion

        private CPSC285S23BDataSet cPSC285S23BDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private CPSC285S23BDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private CPSC285S23BDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator workerBindingNavigator;
        private System.Windows.Forms.ToolStripButton wbindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel wbindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton wbindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton wbindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton wbindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator wbindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox wbindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator wbindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton wbindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton wbindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator wbindingNavigatorSeparator2;
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

        private System.Windows.Forms.BindingSource clientBindingSource;
        private CPSC285S23BDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingNavigator clientBindingNavigator;
        private System.Windows.Forms.ToolStripButton cbindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel cbindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton cbindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton cbindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton cbindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator cbindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox cbindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator cbindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton cbindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton cbindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator cbindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clientBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox client_IDTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.ComboBox clientNameCmbBox;
        private System.Windows.Forms.BindingSource classBindingSource;
        private CPSC285S23BDataSetTableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridView classDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

