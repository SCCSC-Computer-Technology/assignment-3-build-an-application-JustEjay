namespace EricHoward_CPT_206_Lab_2
{
    partial class stateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stateForm));
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
            this.statesDataGridView = new System.Windows.Forms.DataGridView();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.stateSearchBtn = new System.Windows.Forms.Button();
            this.menuGroupBox = new System.Windows.Forms.GroupBox();
            this.editDataBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.insertDataBtn = new System.Windows.Forms.Button();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.sortMedianIncome = new System.Windows.Forms.Button();
            this.sortPopulationBtn = new System.Windows.Forms.Button();
            this.sortStateNameBtn = new System.Windows.Forms.Button();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.filterSearchBtn = new System.Windows.Forms.Button();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.filterResetBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
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
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateInfoDataSet = new EricHoward_CPT_206_Lab_2.StateInfoDataSet();
            this.statesTableAdapter = new EricHoward_CPT_206_Lab_2.StateInfoDataSetTableAdapters.StatesTableAdapter();
            this.tableAdapterManager = new EricHoward_CPT_206_Lab_2.StateInfoDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).BeginInit();
            this.statesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataGridView)).BeginInit();
            this.menuGroupBox.SuspendLayout();
            this.sortGroupBox.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // statesBindingNavigator
            // 
            this.statesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.statesBindingNavigator.BindingSource = this.statesBindingSource;
            this.statesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.statesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.statesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.statesBindingNavigator.Size = new System.Drawing.Size(1001, 31);
            this.statesBindingNavigator.TabIndex = 0;
            this.statesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // statesBindingNavigatorSaveItem
            // 
            this.statesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.statesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("statesBindingNavigatorSaveItem.Image")));
            this.statesBindingNavigatorSaveItem.Name = "statesBindingNavigatorSaveItem";
            this.statesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
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
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.statesDataGridView.DataSource = this.statesBindingSource;
            this.statesDataGridView.Location = new System.Drawing.Point(0, 30);
            this.statesDataGridView.Name = "statesDataGridView";
            this.statesDataGridView.RowHeadersWidth = 51;
            this.statesDataGridView.RowTemplate.Height = 24;
            this.statesDataGridView.Size = new System.Drawing.Size(981, 268);
            this.statesDataGridView.TabIndex = 6;
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(6, 31);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(190, 24);
            this.stateComboBox.TabIndex = 0;
            // 
            // stateSearchBtn
            // 
            this.stateSearchBtn.Location = new System.Drawing.Point(21, 63);
            this.stateSearchBtn.Name = "stateSearchBtn";
            this.stateSearchBtn.Size = new System.Drawing.Size(146, 38);
            this.stateSearchBtn.TabIndex = 1;
            this.stateSearchBtn.Text = "Get Info";
            this.stateSearchBtn.UseVisualStyleBackColor = true;
            this.stateSearchBtn.Click += new System.EventHandler(this.stateSearchBtn_Click);
            // 
            // menuGroupBox
            // 
            this.menuGroupBox.Controls.Add(this.editDataBtn);
            this.menuGroupBox.Controls.Add(this.deleteBtn);
            this.menuGroupBox.Controls.Add(this.stateComboBox);
            this.menuGroupBox.Controls.Add(this.stateSearchBtn);
            this.menuGroupBox.Location = new System.Drawing.Point(12, 315);
            this.menuGroupBox.Name = "menuGroupBox";
            this.menuGroupBox.Size = new System.Drawing.Size(200, 201);
            this.menuGroupBox.TabIndex = 0;
            this.menuGroupBox.TabStop = false;
            this.menuGroupBox.Text = "Select State ";
            // 
            // editDataBtn
            // 
            this.editDataBtn.Location = new System.Drawing.Point(21, 151);
            this.editDataBtn.Name = "editDataBtn";
            this.editDataBtn.Size = new System.Drawing.Size(146, 38);
            this.editDataBtn.TabIndex = 3;
            this.editDataBtn.Text = "Edit Data";
            this.editDataBtn.UseVisualStyleBackColor = true;
            this.editDataBtn.Click += new System.EventHandler(this.editDataBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(21, 107);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(146, 38);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete Row ";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // insertDataBtn
            // 
            this.insertDataBtn.Location = new System.Drawing.Point(495, 466);
            this.insertDataBtn.Name = "insertDataBtn";
            this.insertDataBtn.Size = new System.Drawing.Size(137, 44);
            this.insertDataBtn.TabIndex = 3;
            this.insertDataBtn.Text = "Insert Data";
            this.insertDataBtn.UseVisualStyleBackColor = true;
            this.insertDataBtn.Click += new System.EventHandler(this.insertDataBtn_Click);
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.sortMedianIncome);
            this.sortGroupBox.Controls.Add(this.sortPopulationBtn);
            this.sortGroupBox.Controls.Add(this.sortStateNameBtn);
            this.sortGroupBox.Location = new System.Drawing.Point(260, 315);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(200, 201);
            this.sortGroupBox.TabIndex = 1;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Sort";
            // 
            // sortMedianIncome
            // 
            this.sortMedianIncome.Location = new System.Drawing.Point(15, 134);
            this.sortMedianIncome.Name = "sortMedianIncome";
            this.sortMedianIncome.Size = new System.Drawing.Size(167, 44);
            this.sortMedianIncome.TabIndex = 2;
            this.sortMedianIncome.Text = "Sort By Median Income";
            this.sortMedianIncome.UseVisualStyleBackColor = true;
            this.sortMedianIncome.Click += new System.EventHandler(this.sortMedianIncome_Click);
            // 
            // sortPopulationBtn
            // 
            this.sortPopulationBtn.Location = new System.Drawing.Point(15, 84);
            this.sortPopulationBtn.Name = "sortPopulationBtn";
            this.sortPopulationBtn.Size = new System.Drawing.Size(167, 44);
            this.sortPopulationBtn.TabIndex = 1;
            this.sortPopulationBtn.Text = "Sort By Population";
            this.sortPopulationBtn.UseVisualStyleBackColor = true;
            this.sortPopulationBtn.Click += new System.EventHandler(this.sortPopulationBtn_Click);
            // 
            // sortStateNameBtn
            // 
            this.sortStateNameBtn.Location = new System.Drawing.Point(16, 32);
            this.sortStateNameBtn.Name = "sortStateNameBtn";
            this.sortStateNameBtn.Size = new System.Drawing.Size(167, 44);
            this.sortStateNameBtn.TabIndex = 0;
            this.sortStateNameBtn.Text = "Sort By State Name";
            this.sortStateNameBtn.UseVisualStyleBackColor = true;
            this.sortStateNameBtn.Click += new System.EventHandler(this.sortStateNameBtn_Click);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(197, 30);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(271, 22);
            this.filterTextBox.TabIndex = 1;
            // 
            // filterSearchBtn
            // 
            this.filterSearchBtn.Location = new System.Drawing.Point(66, 70);
            this.filterSearchBtn.Name = "filterSearchBtn";
            this.filterSearchBtn.Size = new System.Drawing.Size(150, 57);
            this.filterSearchBtn.TabIndex = 3;
            this.filterSearchBtn.Text = "Search";
            this.filterSearchBtn.UseVisualStyleBackColor = true;
            this.filterSearchBtn.Click += new System.EventHandler(this.filterSearchBtn_Click);
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "StateName",
            "Population",
            "FlagDescription",
            "StateFlower",
            "StateBird",
            "StateColors",
            "City1",
            "City2",
            "City3",
            "StateCapitol",
            "MedianIncome",
            "ComputerJobs"});
            this.filterComboBox.Location = new System.Drawing.Point(17, 31);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(150, 24);
            this.filterComboBox.TabIndex = 0;
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.filterResetBtn);
            this.filterGroupBox.Controls.Add(this.filterSearchBtn);
            this.filterGroupBox.Controls.Add(this.filterComboBox);
            this.filterGroupBox.Controls.Add(this.filterTextBox);
            this.filterGroupBox.Location = new System.Drawing.Point(495, 316);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(486, 144);
            this.filterGroupBox.TabIndex = 2;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Filter By Colum ";
            // 
            // filterResetBtn
            // 
            this.filterResetBtn.Location = new System.Drawing.Point(293, 70);
            this.filterResetBtn.Name = "filterResetBtn";
            this.filterResetBtn.Size = new System.Drawing.Size(150, 57);
            this.filterResetBtn.TabIndex = 4;
            this.filterResetBtn.Text = "Reset";
            this.filterResetBtn.UseVisualStyleBackColor = true;
            this.filterResetBtn.Click += new System.EventHandler(this.filterResetBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(647, 466);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(137, 44);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close ";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StateName";
            this.dataGridViewTextBoxColumn2.HeaderText = "StateName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn3.HeaderText = "Population";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FlagDescription";
            this.dataGridViewTextBoxColumn4.HeaderText = "FlagDescription";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StateFlower";
            this.dataGridViewTextBoxColumn5.HeaderText = "StateFlower";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "StateBird";
            this.dataGridViewTextBoxColumn6.HeaderText = "StateBird";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "StateColors";
            this.dataGridViewTextBoxColumn7.HeaderText = "StateColors";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "City1";
            this.dataGridViewTextBoxColumn8.HeaderText = "City1";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "City2";
            this.dataGridViewTextBoxColumn9.HeaderText = "City2";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "City3";
            this.dataGridViewTextBoxColumn10.HeaderText = "City3";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "StateCapitol";
            this.dataGridViewTextBoxColumn11.HeaderText = "StateCapitol";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "MedianIncome";
            this.dataGridViewTextBoxColumn12.HeaderText = "MedianIncome";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ComputerJobs";
            this.dataGridViewTextBoxColumn13.HeaderText = "ComputerJobs";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.stateInfoDataSet;
            // 
            // stateInfoDataSet
            // 
            this.stateInfoDataSet.DataSetName = "StateInfoDataSet";
            this.stateInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StatesTableAdapter = this.statesTableAdapter;
            this.tableAdapterManager.UpdateOrder = EricHoward_CPT_206_Lab_2.StateInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(1001, 545);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.sortGroupBox);
            this.Controls.Add(this.insertDataBtn);
            this.Controls.Add(this.statesDataGridView);
            this.Controls.Add(this.statesBindingNavigator);
            this.Controls.Add(this.menuGroupBox);
            this.Controls.Add(this.filterGroupBox);
            this.Name = "stateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EricHoward-cpt-206-lab-2 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).EndInit();
            this.statesBindingNavigator.ResumeLayout(false);
            this.statesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataGridView)).EndInit();
            this.menuGroupBox.ResumeLayout(false);
            this.sortGroupBox.ResumeLayout(false);
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StateInfoDataSet stateInfoDataSet;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private StateInfoDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private StateInfoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.Button stateSearchBtn;
        private System.Windows.Forms.GroupBox menuGroupBox;
        private System.Windows.Forms.Button insertDataBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.Button sortPopulationBtn;
        private System.Windows.Forms.Button sortStateNameBtn;
        private System.Windows.Forms.Button sortMedianIncome;
        private System.Windows.Forms.Button editDataBtn;
        public System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button filterSearchBtn;
        private System.Windows.Forms.ComboBox filterComboBox;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.Button filterResetBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}

