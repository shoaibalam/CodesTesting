﻿namespace MANUUFinance
{
    partial class frmVirtualAccount
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPKVACID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDepID = new System.Windows.Forms.TextBox();
            this.comboAccount = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtparentAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboSL3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboSL2 = new System.Windows.Forms.ComboBox();
            this.comboSL1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPKACID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAccountNameSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSL3Search = new System.Windows.Forms.TextBox();
            this.txtSL3SearchLabel = new System.Windows.Forms.Label();
            this.txtBankAccSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSL1Seacrh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSL2Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DGVAccounts = new System.Windows.Forms.DataGridView();
            this.parentAccountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childAccountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childSL1NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childSL2NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childSL3NameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentACIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childACIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childSL1IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childSL2IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childSL3IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FKDEPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PKVACID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.virtualAccoountsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeDataSet = new MANUUFinance.FinanceDataSet();
            this.virtualAccoountsViewTableAdapter = new MANUUFinance.FinanceDataSetTableAdapters.VirtualAccoountsViewTableAdapter();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualAccoountsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(165, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 70);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(568, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close Form";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(429, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Controls";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(290, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(151, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 38);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPKVACID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDepName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDepID);
            this.groupBox1.Controls.Add(this.comboAccount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtparentAccount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.comboSL3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboSL2);
            this.groupBox1.Controls.Add(this.comboSL1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPKACID);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(33, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1445, 206);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Virtual Account Map";
            // 
            // txtPKVACID
            // 
            this.txtPKVACID.Location = new System.Drawing.Point(1311, 25);
            this.txtPKVACID.Name = "txtPKVACID";
            this.txtPKVACID.Size = new System.Drawing.Size(100, 26);
            this.txtPKVACID.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(795, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Department ID";
            // 
            // txtDepName
            // 
            this.txtDepName.Location = new System.Drawing.Point(217, 37);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(472, 26);
            this.txtDepName.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Department";
            // 
            // txtDepID
            // 
            this.txtDepID.Location = new System.Drawing.Point(939, 37);
            this.txtDepID.Name = "txtDepID";
            this.txtDepID.Size = new System.Drawing.Size(100, 26);
            this.txtDepID.TabIndex = 33;
            // 
            // comboAccount
            // 
            this.comboAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAccount.FormattingEnabled = true;
            this.comboAccount.Location = new System.Drawing.Point(939, 152);
            this.comboAccount.Name = "comboAccount";
            this.comboAccount.Size = new System.Drawing.Size(472, 28);
            this.comboAccount.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(795, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Virtual Account ID";
            // 
            // txtparentAccount
            // 
            this.txtparentAccount.Location = new System.Drawing.Point(217, 75);
            this.txtparentAccount.Name = "txtparentAccount";
            this.txtparentAccount.Size = new System.Drawing.Size(472, 26);
            this.txtparentAccount.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Virtual Account";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(795, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Account Name";
            // 
            // comboSL3
            // 
            this.comboSL3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSL3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSL3.FormattingEnabled = true;
            this.comboSL3.Location = new System.Drawing.Point(217, 152);
            this.comboSL3.Name = "comboSL3";
            this.comboSL3.Size = new System.Drawing.Size(472, 28);
            this.comboSL3.TabIndex = 2;
            this.comboSL3.SelectedIndexChanged += new System.EventHandler(this.comboSL3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "SL3 Name";
            // 
            // comboSL2
            // 
            this.comboSL2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSL2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSL2.FormattingEnabled = true;
            this.comboSL2.Location = new System.Drawing.Point(939, 113);
            this.comboSL2.Name = "comboSL2";
            this.comboSL2.Size = new System.Drawing.Size(472, 28);
            this.comboSL2.TabIndex = 1;
            this.comboSL2.SelectedIndexChanged += new System.EventHandler(this.comboSL2_SelectedIndexChanged);
            // 
            // comboSL1
            // 
            this.comboSL1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSL1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSL1.FormattingEnabled = true;
            this.comboSL1.Location = new System.Drawing.Point(217, 113);
            this.comboSL1.Name = "comboSL1";
            this.comboSL1.Size = new System.Drawing.Size(472, 28);
            this.comboSL1.TabIndex = 0;
            this.comboSL1.SelectedIndexChanged += new System.EventHandler(this.comboSL1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "SL1 Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(795, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "SL2 Name";
            // 
            // txtPKACID
            // 
            this.txtPKACID.Location = new System.Drawing.Point(939, 75);
            this.txtPKACID.Name = "txtPKACID";
            this.txtPKACID.Size = new System.Drawing.Size(100, 26);
            this.txtPKACID.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtAccountNameSearch);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtSL3Search);
            this.groupBox4.Controls.Add(this.txtSL3SearchLabel);
            this.groupBox4.Controls.Add(this.txtBankAccSearch);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.btnClearSearch);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtSL1Seacrh);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtSL2Search);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(1122, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(356, 402);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Grid Filter";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Account Name";
            // 
            // txtAccountNameSearch
            // 
            this.txtAccountNameSearch.Location = new System.Drawing.Point(18, 287);
            this.txtAccountNameSearch.Name = "txtAccountNameSearch";
            this.txtAccountNameSearch.Size = new System.Drawing.Size(324, 26);
            this.txtAccountNameSearch.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Bank Account";
            // 
            // txtSL3Search
            // 
            this.txtSL3Search.Location = new System.Drawing.Point(18, 171);
            this.txtSL3Search.Name = "txtSL3Search";
            this.txtSL3Search.Size = new System.Drawing.Size(324, 26);
            this.txtSL3Search.TabIndex = 2;
            // 
            // txtSL3SearchLabel
            // 
            this.txtSL3SearchLabel.AutoSize = true;
            this.txtSL3SearchLabel.Location = new System.Drawing.Point(16, 148);
            this.txtSL3SearchLabel.Name = "txtSL3SearchLabel";
            this.txtSL3SearchLabel.Size = new System.Drawing.Size(84, 20);
            this.txtSL3SearchLabel.TabIndex = 23;
            this.txtSL3SearchLabel.Text = "SL3 Name";
            // 
            // txtBankAccSearch
            // 
            this.txtBankAccSearch.Location = new System.Drawing.Point(18, 228);
            this.txtBankAccSearch.Name = "txtBankAccSearch";
            this.txtBankAccSearch.Size = new System.Drawing.Size(324, 26);
            this.txtBankAccSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(178, 342);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 38);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(33, 342);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(133, 38);
            this.btnClearSearch.TabIndex = 5;
            this.btnClearSearch.Text = "Clear Controls";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "SL2 Name";
            // 
            // txtSL1Seacrh
            // 
            this.txtSL1Seacrh.Location = new System.Drawing.Point(19, 57);
            this.txtSL1Seacrh.Name = "txtSL1Seacrh";
            this.txtSL1Seacrh.Size = new System.Drawing.Size(324, 26);
            this.txtSL1Seacrh.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "SL1 Name";
            // 
            // txtSL2Search
            // 
            this.txtSL2Search.Location = new System.Drawing.Point(19, 114);
            this.txtSL2Search.Name = "txtSL2Search";
            this.txtSL2Search.Size = new System.Drawing.Size(324, 26);
            this.txtSL2Search.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-123, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Account Name";
            // 
            // DGVAccounts
            // 
            this.DGVAccounts.AllowUserToAddRows = false;
            this.DGVAccounts.AllowUserToDeleteRows = false;
            this.DGVAccounts.AllowUserToResizeRows = false;
            this.DGVAccounts.AutoGenerateColumns = false;
            this.DGVAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parentAccountNameDataGridViewTextBoxColumn,
            this.childAccountNameDataGridViewTextBoxColumn,
            this.childSL1NameDataGridViewTextBoxColumn,
            this.childSL2NameDataGridViewTextBoxColumn,
            this.childSL3NameDataGridViewTextBoxColumn,
            this.parentACIDDataGridViewTextBoxColumn,
            this.childACIDDataGridViewTextBoxColumn,
            this.childSL1IDDataGridViewTextBoxColumn,
            this.childSL2IDDataGridViewTextBoxColumn,
            this.childSL3IDDataGridViewTextBoxColumn,
            this.FKDEPID,
            this.PKVACID});
            this.DGVAccounts.DataSource = this.virtualAccoountsViewBindingSource;
            this.DGVAccounts.Location = new System.Drawing.Point(33, 347);
            this.DGVAccounts.MultiSelect = false;
            this.DGVAccounts.Name = "DGVAccounts";
            this.DGVAccounts.ReadOnly = true;
            this.DGVAccounts.RowTemplate.Height = 28;
            this.DGVAccounts.Size = new System.Drawing.Size(1069, 317);
            this.DGVAccounts.TabIndex = 26;
            this.DGVAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAccounts_CellClick);
            // 
            // parentAccountNameDataGridViewTextBoxColumn
            // 
            this.parentAccountNameDataGridViewTextBoxColumn.DataPropertyName = "ParentAccountName";
            this.parentAccountNameDataGridViewTextBoxColumn.HeaderText = "ParentAccountName";
            this.parentAccountNameDataGridViewTextBoxColumn.Name = "parentAccountNameDataGridViewTextBoxColumn";
            this.parentAccountNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // childAccountNameDataGridViewTextBoxColumn
            // 
            this.childAccountNameDataGridViewTextBoxColumn.DataPropertyName = "ChildAccountName";
            this.childAccountNameDataGridViewTextBoxColumn.HeaderText = "ChildAccountName";
            this.childAccountNameDataGridViewTextBoxColumn.Name = "childAccountNameDataGridViewTextBoxColumn";
            this.childAccountNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // childSL1NameDataGridViewTextBoxColumn
            // 
            this.childSL1NameDataGridViewTextBoxColumn.DataPropertyName = "ChildSL1Name";
            this.childSL1NameDataGridViewTextBoxColumn.HeaderText = "ChildSL1Name";
            this.childSL1NameDataGridViewTextBoxColumn.Name = "childSL1NameDataGridViewTextBoxColumn";
            this.childSL1NameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // childSL2NameDataGridViewTextBoxColumn
            // 
            this.childSL2NameDataGridViewTextBoxColumn.DataPropertyName = "ChildSL2Name";
            this.childSL2NameDataGridViewTextBoxColumn.HeaderText = "ChildSL2Name";
            this.childSL2NameDataGridViewTextBoxColumn.Name = "childSL2NameDataGridViewTextBoxColumn";
            this.childSL2NameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // childSL3NameDataGridViewTextBoxColumn
            // 
            this.childSL3NameDataGridViewTextBoxColumn.DataPropertyName = "ChildSL3Name";
            this.childSL3NameDataGridViewTextBoxColumn.HeaderText = "ChildSL3Name";
            this.childSL3NameDataGridViewTextBoxColumn.Name = "childSL3NameDataGridViewTextBoxColumn";
            this.childSL3NameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parentACIDDataGridViewTextBoxColumn
            // 
            this.parentACIDDataGridViewTextBoxColumn.DataPropertyName = "ParentACID";
            this.parentACIDDataGridViewTextBoxColumn.HeaderText = "ParentACID";
            this.parentACIDDataGridViewTextBoxColumn.Name = "parentACIDDataGridViewTextBoxColumn";
            this.parentACIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentACIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // childACIDDataGridViewTextBoxColumn
            // 
            this.childACIDDataGridViewTextBoxColumn.DataPropertyName = "ChildACID";
            this.childACIDDataGridViewTextBoxColumn.HeaderText = "ChildACID";
            this.childACIDDataGridViewTextBoxColumn.Name = "childACIDDataGridViewTextBoxColumn";
            this.childACIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // childSL1IDDataGridViewTextBoxColumn
            // 
            this.childSL1IDDataGridViewTextBoxColumn.DataPropertyName = "ChildSL1ID";
            this.childSL1IDDataGridViewTextBoxColumn.HeaderText = "ChildSL1ID";
            this.childSL1IDDataGridViewTextBoxColumn.Name = "childSL1IDDataGridViewTextBoxColumn";
            this.childSL1IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.childSL1IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // childSL2IDDataGridViewTextBoxColumn
            // 
            this.childSL2IDDataGridViewTextBoxColumn.DataPropertyName = "ChildSL2ID";
            this.childSL2IDDataGridViewTextBoxColumn.HeaderText = "ChildSL2ID";
            this.childSL2IDDataGridViewTextBoxColumn.Name = "childSL2IDDataGridViewTextBoxColumn";
            this.childSL2IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.childSL2IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // childSL3IDDataGridViewTextBoxColumn
            // 
            this.childSL3IDDataGridViewTextBoxColumn.DataPropertyName = "ChildSL3ID";
            this.childSL3IDDataGridViewTextBoxColumn.HeaderText = "ChildSL3ID";
            this.childSL3IDDataGridViewTextBoxColumn.Name = "childSL3IDDataGridViewTextBoxColumn";
            this.childSL3IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.childSL3IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // FKDEPID
            // 
            this.FKDEPID.DataPropertyName = "FKDEPID";
            this.FKDEPID.HeaderText = "FKDEPID";
            this.FKDEPID.Name = "FKDEPID";
            this.FKDEPID.ReadOnly = true;
            this.FKDEPID.Visible = false;
            // 
            // PKVACID
            // 
            this.PKVACID.DataPropertyName = "PKVACID";
            this.PKVACID.HeaderText = "PKVACID";
            this.PKVACID.Name = "PKVACID";
            this.PKVACID.ReadOnly = true;
            this.PKVACID.Visible = false;
            // 
            // virtualAccoountsViewBindingSource
            // 
            this.virtualAccoountsViewBindingSource.DataMember = "VirtualAccoountsView";
            this.virtualAccoountsViewBindingSource.DataSource = this.financeDataSet;
            // 
            // financeDataSet
            // 
            this.financeDataSet.DataSetName = "FinanceDataSet";
            this.financeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // virtualAccoountsViewTableAdapter
            // 
            this.virtualAccoountsViewTableAdapter.ClearBeforeFill = true;
            // 
            // frmVirtualAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.DGVAccounts);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVirtualAccount";
            this.Text = "Virtual Account Mapping";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.virtualAccoountsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboSL3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboSL2;
        private System.Windows.Forms.ComboBox comboSL1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPKACID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DGVAccounts;
        private FinanceDataSet financeDataSet;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSL1Seacrh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSL2Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSL3Search;
        private System.Windows.Forms.Label txtSL3SearchLabel;
        private System.Windows.Forms.TextBox txtBankAccSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAccountNameSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtparentAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboAccount;
        private System.Windows.Forms.BindingSource virtualAccoountsViewBindingSource;
        private FinanceDataSetTableAdapters.VirtualAccoountsViewTableAdapter virtualAccoountsViewTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDepID;
        private System.Windows.Forms.TextBox txtPKVACID;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentAccountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childAccountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childSL1NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childSL2NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childSL3NameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentACIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childACIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childSL1IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childSL2IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childSL3IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FKDEPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKVACID;
    }
}