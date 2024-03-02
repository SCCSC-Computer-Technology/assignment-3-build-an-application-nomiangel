namespace Noemi_Angeles_CPT_206_LAB_2
{
    partial class DisplayIndvStateInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayIndvStateInfo));
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label populationLabel;
            System.Windows.Forms.Label state_Flag_DescriptionLabel;
            System.Windows.Forms.Label state_FlowerLabel;
            System.Windows.Forms.Label state_BirdLabel;
            System.Windows.Forms.Label state_ColorsLabel;
            System.Windows.Forms.Label three_Largest_CitiesLabel;
            System.Windows.Forms.Label state_CapitolLabel;
            System.Windows.Forms.Label median_IncomeLabel;
            System.Windows.Forms.Label percentage_of_Computer_Related_JobsLabel;
            this.stateDBDataSet = new Noemi_Angeles_CPT_206_LAB_2.StateDBDataSet();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesTableAdapter = new Noemi_Angeles_CPT_206_LAB_2.StateDBDataSetTableAdapters.StatesTableAdapter();
            this.tableAdapterManager = new Noemi_Angeles_CPT_206_LAB_2.StateDBDataSetTableAdapters.TableAdapterManager();
            this.statesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.statesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.state_Flag_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.state_FlowerTextBox = new System.Windows.Forms.TextBox();
            this.state_BirdTextBox = new System.Windows.Forms.TextBox();
            this.state_ColorsTextBox = new System.Windows.Forms.TextBox();
            this.three_Largest_CitiesTextBox = new System.Windows.Forms.TextBox();
            this.state_CapitolTextBox = new System.Windows.Forms.TextBox();
            this.median_IncomeTextBox = new System.Windows.Forms.TextBox();
            this.percentage_of_Computer_Related_JobsTextBox = new System.Windows.Forms.TextBox();
            stateLabel = new System.Windows.Forms.Label();
            populationLabel = new System.Windows.Forms.Label();
            state_Flag_DescriptionLabel = new System.Windows.Forms.Label();
            state_FlowerLabel = new System.Windows.Forms.Label();
            state_BirdLabel = new System.Windows.Forms.Label();
            state_ColorsLabel = new System.Windows.Forms.Label();
            three_Largest_CitiesLabel = new System.Windows.Forms.Label();
            state_CapitolLabel = new System.Windows.Forms.Label();
            median_IncomeLabel = new System.Windows.Forms.Label();
            percentage_of_Computer_Related_JobsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).BeginInit();
            this.statesBindingNavigator.SuspendLayout();
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
            this.statesBindingNavigator.Size = new System.Drawing.Size(928, 33);
            this.statesBindingNavigator.TabIndex = 0;
            this.statesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
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
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(191, 102);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(52, 20);
            stateLabel.TabIndex = 1;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(483, 99);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(299, 26);
            this.stateTextBox.TabIndex = 2;
            // 
            // populationLabel
            // 
            populationLabel.AutoSize = true;
            populationLabel.Location = new System.Drawing.Point(191, 134);
            populationLabel.Name = "populationLabel";
            populationLabel.Size = new System.Drawing.Size(88, 20);
            populationLabel.TabIndex = 3;
            populationLabel.Text = "Population:";
            // 
            // populationTextBox
            // 
            this.populationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Population", true));
            this.populationTextBox.Location = new System.Drawing.Point(483, 131);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(299, 26);
            this.populationTextBox.TabIndex = 4;
            // 
            // state_Flag_DescriptionLabel
            // 
            state_Flag_DescriptionLabel.AutoSize = true;
            state_Flag_DescriptionLabel.Location = new System.Drawing.Point(191, 166);
            state_Flag_DescriptionLabel.Name = "state_Flag_DescriptionLabel";
            state_Flag_DescriptionLabel.Size = new System.Drawing.Size(171, 20);
            state_Flag_DescriptionLabel.TabIndex = 5;
            state_Flag_DescriptionLabel.Text = "State Flag Description:";
            // 
            // state_Flag_DescriptionTextBox
            // 
            this.state_Flag_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State Flag Description", true));
            this.state_Flag_DescriptionTextBox.Location = new System.Drawing.Point(483, 163);
            this.state_Flag_DescriptionTextBox.Name = "state_Flag_DescriptionTextBox";
            this.state_Flag_DescriptionTextBox.Size = new System.Drawing.Size(299, 26);
            this.state_Flag_DescriptionTextBox.TabIndex = 6;
            // 
            // state_FlowerLabel
            // 
            state_FlowerLabel.AutoSize = true;
            state_FlowerLabel.Location = new System.Drawing.Point(191, 198);
            state_FlowerLabel.Name = "state_FlowerLabel";
            state_FlowerLabel.Size = new System.Drawing.Size(103, 20);
            state_FlowerLabel.TabIndex = 7;
            state_FlowerLabel.Text = "State Flower:";
            // 
            // state_FlowerTextBox
            // 
            this.state_FlowerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State Flower", true));
            this.state_FlowerTextBox.Location = new System.Drawing.Point(483, 195);
            this.state_FlowerTextBox.Name = "state_FlowerTextBox";
            this.state_FlowerTextBox.Size = new System.Drawing.Size(299, 26);
            this.state_FlowerTextBox.TabIndex = 8;
            // 
            // state_BirdLabel
            // 
            state_BirdLabel.AutoSize = true;
            state_BirdLabel.Location = new System.Drawing.Point(191, 230);
            state_BirdLabel.Name = "state_BirdLabel";
            state_BirdLabel.Size = new System.Drawing.Size(84, 20);
            state_BirdLabel.TabIndex = 9;
            state_BirdLabel.Text = "State Bird:";
            // 
            // state_BirdTextBox
            // 
            this.state_BirdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State Bird", true));
            this.state_BirdTextBox.Location = new System.Drawing.Point(483, 227);
            this.state_BirdTextBox.Name = "state_BirdTextBox";
            this.state_BirdTextBox.Size = new System.Drawing.Size(299, 26);
            this.state_BirdTextBox.TabIndex = 10;
            // 
            // state_ColorsLabel
            // 
            state_ColorsLabel.AutoSize = true;
            state_ColorsLabel.Location = new System.Drawing.Point(191, 262);
            state_ColorsLabel.Name = "state_ColorsLabel";
            state_ColorsLabel.Size = new System.Drawing.Size(101, 20);
            state_ColorsLabel.TabIndex = 11;
            state_ColorsLabel.Text = "State Colors:";
            // 
            // state_ColorsTextBox
            // 
            this.state_ColorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State Colors", true));
            this.state_ColorsTextBox.Location = new System.Drawing.Point(483, 259);
            this.state_ColorsTextBox.Name = "state_ColorsTextBox";
            this.state_ColorsTextBox.Size = new System.Drawing.Size(299, 26);
            this.state_ColorsTextBox.TabIndex = 12;
            // 
            // three_Largest_CitiesLabel
            // 
            three_Largest_CitiesLabel.AutoSize = true;
            three_Largest_CitiesLabel.Location = new System.Drawing.Point(191, 294);
            three_Largest_CitiesLabel.Name = "three_Largest_CitiesLabel";
            three_Largest_CitiesLabel.Size = new System.Drawing.Size(155, 20);
            three_Largest_CitiesLabel.TabIndex = 13;
            three_Largest_CitiesLabel.Text = "Three Largest Cities:";
            // 
            // three_Largest_CitiesTextBox
            // 
            this.three_Largest_CitiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Three Largest Cities", true));
            this.three_Largest_CitiesTextBox.Location = new System.Drawing.Point(483, 291);
            this.three_Largest_CitiesTextBox.Name = "three_Largest_CitiesTextBox";
            this.three_Largest_CitiesTextBox.Size = new System.Drawing.Size(299, 26);
            this.three_Largest_CitiesTextBox.TabIndex = 14;
            // 
            // state_CapitolLabel
            // 
            state_CapitolLabel.AutoSize = true;
            state_CapitolLabel.Location = new System.Drawing.Point(191, 326);
            state_CapitolLabel.Name = "state_CapitolLabel";
            state_CapitolLabel.Size = new System.Drawing.Size(105, 20);
            state_CapitolLabel.TabIndex = 15;
            state_CapitolLabel.Text = "State Capitol:";
            // 
            // state_CapitolTextBox
            // 
            this.state_CapitolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "State Capitol", true));
            this.state_CapitolTextBox.Location = new System.Drawing.Point(483, 323);
            this.state_CapitolTextBox.Name = "state_CapitolTextBox";
            this.state_CapitolTextBox.Size = new System.Drawing.Size(299, 26);
            this.state_CapitolTextBox.TabIndex = 16;
            // 
            // median_IncomeLabel
            // 
            median_IncomeLabel.AutoSize = true;
            median_IncomeLabel.Location = new System.Drawing.Point(191, 358);
            median_IncomeLabel.Name = "median_IncomeLabel";
            median_IncomeLabel.Size = new System.Drawing.Size(122, 20);
            median_IncomeLabel.TabIndex = 17;
            median_IncomeLabel.Text = "Median Income:";
            // 
            // median_IncomeTextBox
            // 
            this.median_IncomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Median Income", true));
            this.median_IncomeTextBox.Location = new System.Drawing.Point(483, 355);
            this.median_IncomeTextBox.Name = "median_IncomeTextBox";
            this.median_IncomeTextBox.Size = new System.Drawing.Size(299, 26);
            this.median_IncomeTextBox.TabIndex = 18;
            // 
            // percentage_of_Computer_Related_JobsLabel
            // 
            percentage_of_Computer_Related_JobsLabel.AutoSize = true;
            percentage_of_Computer_Related_JobsLabel.Location = new System.Drawing.Point(191, 390);
            percentage_of_Computer_Related_JobsLabel.Name = "percentage_of_Computer_Related_JobsLabel";
            percentage_of_Computer_Related_JobsLabel.Size = new System.Drawing.Size(286, 20);
            percentage_of_Computer_Related_JobsLabel.TabIndex = 19;
            percentage_of_Computer_Related_JobsLabel.Text = "Percentage of Computer-Related Jobs:";
            // 
            // percentage_of_Computer_Related_JobsTextBox
            // 
            this.percentage_of_Computer_Related_JobsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Percentage of Computer-Related Jobs", true));
            this.percentage_of_Computer_Related_JobsTextBox.Location = new System.Drawing.Point(483, 387);
            this.percentage_of_Computer_Related_JobsTextBox.Name = "percentage_of_Computer_Related_JobsTextBox";
            this.percentage_of_Computer_Related_JobsTextBox.Size = new System.Drawing.Size(299, 26);
            this.percentage_of_Computer_Related_JobsTextBox.TabIndex = 20;
            // 
            // DisplayIndvStateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 470);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(populationLabel);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(state_Flag_DescriptionLabel);
            this.Controls.Add(this.state_Flag_DescriptionTextBox);
            this.Controls.Add(state_FlowerLabel);
            this.Controls.Add(this.state_FlowerTextBox);
            this.Controls.Add(state_BirdLabel);
            this.Controls.Add(this.state_BirdTextBox);
            this.Controls.Add(state_ColorsLabel);
            this.Controls.Add(this.state_ColorsTextBox);
            this.Controls.Add(three_Largest_CitiesLabel);
            this.Controls.Add(this.three_Largest_CitiesTextBox);
            this.Controls.Add(state_CapitolLabel);
            this.Controls.Add(this.state_CapitolTextBox);
            this.Controls.Add(median_IncomeLabel);
            this.Controls.Add(this.median_IncomeTextBox);
            this.Controls.Add(percentage_of_Computer_Related_JobsLabel);
            this.Controls.Add(this.percentage_of_Computer_Related_JobsTextBox);
            this.Controls.Add(this.statesBindingNavigator);
            this.Name = "DisplayIndvStateInfo";
            this.Text = "DisplayIndvStateInfo";
            this.Load += new System.EventHandler(this.DisplayIndvStateInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).EndInit();
            this.statesBindingNavigator.ResumeLayout(false);
            this.statesBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox state_Flag_DescriptionTextBox;
        private System.Windows.Forms.TextBox state_FlowerTextBox;
        private System.Windows.Forms.TextBox state_BirdTextBox;
        private System.Windows.Forms.TextBox state_ColorsTextBox;
        private System.Windows.Forms.TextBox three_Largest_CitiesTextBox;
        private System.Windows.Forms.TextBox state_CapitolTextBox;
        private System.Windows.Forms.TextBox median_IncomeTextBox;
        private System.Windows.Forms.TextBox percentage_of_Computer_Related_JobsTextBox;
    }
}