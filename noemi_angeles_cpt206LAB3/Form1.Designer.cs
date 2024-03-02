namespace Noemi_Angeles_CPT_206_LAB_2
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
            this.stateDBDataSet = new Noemi_Angeles_CPT_206_LAB_2.StateDBDataSet();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesTableAdapter = new Noemi_Angeles_CPT_206_LAB_2.StateDBDataSetTableAdapters.StatesTableAdapter();
            this.tableAdapterManager = new Noemi_Angeles_CPT_206_LAB_2.StateDBDataSetTableAdapters.TableAdapterManager();
            this.statesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.statesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.statesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateComboBox1 = new System.Windows.Forms.ComboBox();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.alphaButton = new System.Windows.Forms.Button();
            this.populationASCButton = new System.Windows.Forms.Button();
            this.birdsButton = new System.Windows.Forms.Button();
            this.flowersButton = new System.Windows.Forms.Button();
            this.incomeButton = new System.Windows.Forms.Button();
            this.percentButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.capitaltextBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.flowertextBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.birdtextBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearbutton1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).BeginInit();
            this.statesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataGridView)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            this.sortGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // stateDBDataSet
            // 
            this.stateDBDataSet.DataSetName = "StateDBDataSet";
            this.stateDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.stateDBDataSet;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StatesTableAdapter = this.statesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Noemi_Angeles_CPT_206_LAB_2.StateDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // statesBindingNavigator
            // 
            this.statesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.statesBindingNavigator.BindingSource = this.statesBindingSource;
            this.statesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.statesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.statesBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.statesBindingNavigatorSaveItem});
            this.statesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.statesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.statesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.statesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.statesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.statesBindingNavigator.Name = "statesBindingNavigator";
            this.statesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.statesBindingNavigator.Size = new System.Drawing.Size(1562, 33);
            this.statesBindingNavigator.TabIndex = 0;
            this.statesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // statesBindingNavigatorSaveItem
            // 
            this.statesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.statesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("statesBindingNavigatorSaveItem.Image")));
            this.statesBindingNavigatorSaveItem.Name = "statesBindingNavigatorSaveItem";
            this.statesBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.statesBindingNavigatorSaveItem.Text = "Save Data";
            this.statesBindingNavigatorSaveItem.Click += new System.EventHandler(this.statesBindingNavigatorSaveItem_Click);
            // 
            // statesDataGridView
            // 
            this.statesDataGridView.AutoGenerateColumns = false;
            this.statesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.statesDataGridView.DataSource = this.statesBindingSource;
            this.statesDataGridView.Location = new System.Drawing.Point(43, 58);
            this.statesDataGridView.Name = "statesDataGridView";
            this.statesDataGridView.RowHeadersWidth = 62;
            this.statesDataGridView.RowTemplate.Height = 28;
            this.statesDataGridView.Size = new System.Drawing.Size(1126, 405);
            this.statesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn1.HeaderText = "State";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn2.HeaderText = "Population";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "State Flag Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "State Flag Description";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "State Flower";
            this.dataGridViewTextBoxColumn4.HeaderText = "State Flower";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "State Bird";
            this.dataGridViewTextBoxColumn5.HeaderText = "State Bird";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "State Colors";
            this.dataGridViewTextBoxColumn6.HeaderText = "State Colors";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Three Largest Cities";
            this.dataGridViewTextBoxColumn7.HeaderText = "Three Largest Cities";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "State Capitol";
            this.dataGridViewTextBoxColumn8.HeaderText = "State Capitol";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Median Income";
            this.dataGridViewTextBoxColumn9.HeaderText = "Median Income";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Percentage of Computer-Related Jobs";
            this.dataGridViewTextBoxColumn10.HeaderText = "Percentage of Computer-Related Jobs";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // stateComboBox1
            // 
            this.stateComboBox1.FormattingEnabled = true;
            this.stateComboBox1.Location = new System.Drawing.Point(10, 486);
            this.stateComboBox1.Name = "stateComboBox1";
            this.stateComboBox1.Size = new System.Drawing.Size(121, 28);
            this.stateComboBox1.TabIndex = 2;
            this.stateComboBox1.SelectedIndexChanged += new System.EventHandler(this.stateComboBox1_SelectedIndexChanged);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.birdtextBox5);
            this.searchGroupBox.Controls.Add(this.label11);
            this.searchGroupBox.Controls.Add(this.flowertextBox4);
            this.searchGroupBox.Controls.Add(this.label10);
            this.searchGroupBox.Controls.Add(this.capitaltextBox3);
            this.searchGroupBox.Controls.Add(this.label9);
            this.searchGroupBox.Controls.Add(this.nameTextBox);
            this.searchGroupBox.Controls.Add(this.label5);
            this.searchGroupBox.Location = new System.Drawing.Point(157, 495);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(373, 422);
            this.searchGroupBox.TabIndex = 4;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search Bird";
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.percentButton);
            this.sortGroupBox.Controls.Add(this.incomeButton);
            this.sortGroupBox.Controls.Add(this.flowersButton);
            this.sortGroupBox.Controls.Add(this.birdsButton);
            this.sortGroupBox.Controls.Add(this.populationASCButton);
            this.sortGroupBox.Controls.Add(this.alphaButton);
            this.sortGroupBox.Controls.Add(this.label7);
            this.sortGroupBox.Controls.Add(this.label6);
            this.sortGroupBox.Controls.Add(this.label4);
            this.sortGroupBox.Controls.Add(this.label3);
            this.sortGroupBox.Controls.Add(this.label2);
            this.sortGroupBox.Controls.Add(this.label1);
            this.sortGroupBox.Location = new System.Drawing.Point(569, 486);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(372, 324);
            this.sortGroupBox.TabIndex = 5;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Sort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sort State Alphabetically";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sort Population ASC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sort Birds Alphabetically";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sort Flowers Alphabetically";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sort Median Income ASC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sort % ASC";
            // 
            // alphaButton
            // 
            this.alphaButton.Location = new System.Drawing.Point(209, 11);
            this.alphaButton.Name = "alphaButton";
            this.alphaButton.Size = new System.Drawing.Size(101, 34);
            this.alphaButton.TabIndex = 7;
            this.alphaButton.Text = "SORT";
            this.alphaButton.UseVisualStyleBackColor = true;
            this.alphaButton.Click += new System.EventHandler(this.alphaButton_Click);
            // 
            // populationASCButton
            // 
            this.populationASCButton.Location = new System.Drawing.Point(209, 60);
            this.populationASCButton.Name = "populationASCButton";
            this.populationASCButton.Size = new System.Drawing.Size(101, 34);
            this.populationASCButton.TabIndex = 8;
            this.populationASCButton.Text = "SORT";
            this.populationASCButton.UseVisualStyleBackColor = true;
            this.populationASCButton.Click += new System.EventHandler(this.populationASCButton_Click);
            // 
            // birdsButton
            // 
            this.birdsButton.Location = new System.Drawing.Point(209, 107);
            this.birdsButton.Name = "birdsButton";
            this.birdsButton.Size = new System.Drawing.Size(101, 34);
            this.birdsButton.TabIndex = 9;
            this.birdsButton.Text = "SORT";
            this.birdsButton.UseVisualStyleBackColor = true;
            this.birdsButton.Click += new System.EventHandler(this.birdsButton_Click);
            // 
            // flowersButton
            // 
            this.flowersButton.Location = new System.Drawing.Point(209, 149);
            this.flowersButton.Name = "flowersButton";
            this.flowersButton.Size = new System.Drawing.Size(101, 34);
            this.flowersButton.TabIndex = 10;
            this.flowersButton.Text = "SORT";
            this.flowersButton.UseVisualStyleBackColor = true;
            this.flowersButton.Click += new System.EventHandler(this.flowersButton_Click);
            // 
            // incomeButton
            // 
            this.incomeButton.Location = new System.Drawing.Point(212, 197);
            this.incomeButton.Name = "incomeButton";
            this.incomeButton.Size = new System.Drawing.Size(101, 34);
            this.incomeButton.TabIndex = 12;
            this.incomeButton.Text = "SORT";
            this.incomeButton.UseVisualStyleBackColor = true;
            this.incomeButton.Click += new System.EventHandler(this.incomeButton_Click);
            // 
            // percentButton
            // 
            this.percentButton.Location = new System.Drawing.Point(212, 247);
            this.percentButton.Name = "percentButton";
            this.percentButton.Size = new System.Drawing.Size(101, 34);
            this.percentButton.TabIndex = 13;
            this.percentButton.Text = "SORT";
            this.percentButton.UseVisualStyleBackColor = true;
            this.percentButton.Click += new System.EventHandler(this.percentButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Search State";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(204, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 1;
            // 
            // capitaltextBox3
            // 
            this.capitaltextBox3.Location = new System.Drawing.Point(204, 148);
            this.capitaltextBox3.Name = "capitaltextBox3";
            this.capitaltextBox3.Size = new System.Drawing.Size(100, 26);
            this.capitaltextBox3.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Search Capital";
            // 
            // flowertextBox4
            // 
            this.flowertextBox4.Location = new System.Drawing.Point(204, 217);
            this.flowertextBox4.Name = "flowertextBox4";
            this.flowertextBox4.Size = new System.Drawing.Size(100, 26);
            this.flowertextBox4.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Search Flower";
            // 
            // birdtextBox5
            // 
            this.birdtextBox5.Location = new System.Drawing.Point(204, 272);
            this.birdtextBox5.Name = "birdtextBox5";
            this.birdtextBox5.Size = new System.Drawing.Size(100, 26);
            this.birdtextBox5.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Search Bird";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(127, 368);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(101, 34);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearbutton1
            // 
            this.clearbutton1.Location = new System.Drawing.Point(580, 845);
            this.clearbutton1.Name = "clearbutton1";
            this.clearbutton1.Size = new System.Drawing.Size(134, 62);
            this.clearbutton1.TabIndex = 8;
            this.clearbutton1.Text = "Clear";
            this.clearbutton1.UseVisualStyleBackColor = true;
            this.clearbutton1.Click += new System.EventHandler(this.clearbutton1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(720, 843);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 67);
            this.button2.TabIndex = 9;
            this.button2.Text = "&Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 1050);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.clearbutton1);
            this.Controls.Add(this.sortGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.stateComboBox1);
            this.Controls.Add(this.statesDataGridView);
            this.Controls.Add(this.statesBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).EndInit();
            this.statesBindingNavigator.ResumeLayout(false);
            this.statesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataGridView)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StateDBDataSet stateDBDataSet;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private StateDBDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private StateDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator statesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton statesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView statesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.ComboBox stateComboBox1;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.Button incomeButton;
        private System.Windows.Forms.Button flowersButton;
        private System.Windows.Forms.Button birdsButton;
        private System.Windows.Forms.Button populationASCButton;
        private System.Windows.Forms.Button alphaButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox birdtextBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox flowertextBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox capitaltextBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button clearbutton1;
        private System.Windows.Forms.Button button2;
    }
}

