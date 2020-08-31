namespace Lista_de_Cumparaturi
{
    partial class Lista_de_cumparaturi
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
            System.Windows.Forms.Label nume_ProdusLabel;
            System.Windows.Forms.Label cantitateLabel;
            System.Windows.Forms.Label uMLabel;
            System.Windows.Forms.Label pret__lei_Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_de_cumparaturi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.modelDataSet = new Lista_de_Cumparaturi.ModelDataSet();
            this.databaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseTableAdapter = new Lista_de_Cumparaturi.ModelDataSetTableAdapters.DatabaseTableAdapter();
            this.tableAdapterManager = new Lista_de_Cumparaturi.ModelDataSetTableAdapters.TableAdapterManager();
            this.databaseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.databaseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.nume_ProdusTextBox = new System.Windows.Forms.TextBox();
            this.cantitateTextBox = new System.Windows.Forms.TextBox();
            this.uMComboBox = new System.Windows.Forms.ComboBox();
            this.pret__lei_TextBox = new System.Windows.Forms.TextBox();
            this.total__lei_TextBox = new System.Windows.Forms.TextBox();
            this.databaseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.TextBox();
            nume_ProdusLabel = new System.Windows.Forms.Label();
            cantitateLabel = new System.Windows.Forms.Label();
            uMLabel = new System.Windows.Forms.Label();
            pret__lei_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingNavigator)).BeginInit();
            this.databaseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nume_ProdusLabel
            // 
            nume_ProdusLabel.AutoSize = true;
            nume_ProdusLabel.BackColor = System.Drawing.Color.Transparent;
            nume_ProdusLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            nume_ProdusLabel.Location = new System.Drawing.Point(12, 42);
            nume_ProdusLabel.Name = "nume_ProdusLabel";
            nume_ProdusLabel.Size = new System.Drawing.Size(74, 13);
            nume_ProdusLabel.TabIndex = 3;
            nume_ProdusLabel.Text = "Nume Produs:";
            // 
            // cantitateLabel
            // 
            cantitateLabel.AutoSize = true;
            cantitateLabel.BackColor = System.Drawing.Color.Transparent;
            cantitateLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            cantitateLabel.Location = new System.Drawing.Point(12, 68);
            cantitateLabel.Name = "cantitateLabel";
            cantitateLabel.Size = new System.Drawing.Size(52, 13);
            cantitateLabel.TabIndex = 5;
            cantitateLabel.Text = "Cantitate:";
            // 
            // uMLabel
            // 
            uMLabel.AutoSize = true;
            uMLabel.BackColor = System.Drawing.Color.Transparent;
            uMLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            uMLabel.Location = new System.Drawing.Point(261, 42);
            uMLabel.Name = "uMLabel";
            uMLabel.Size = new System.Drawing.Size(27, 13);
            uMLabel.TabIndex = 7;
            uMLabel.Text = "UM:";
            // 
            // pret__lei_Label
            // 
            pret__lei_Label.AutoSize = true;
            pret__lei_Label.BackColor = System.Drawing.Color.Transparent;
            pret__lei_Label.ForeColor = System.Drawing.Color.DodgerBlue;
            pret__lei_Label.Location = new System.Drawing.Point(261, 71);
            pret__lei_Label.Name = "pret__lei_Label";
            pret__lei_Label.Size = new System.Drawing.Size(48, 13);
            pret__lei_Label.TabIndex = 9;
            pret__lei_Label.Text = "Pret (lei):";
            pret__lei_Label.Click += new System.EventHandler(this.pret__lei_Label_Click);
            // 
            // modelDataSet
            // 
            this.modelDataSet.DataSetName = "ModelDataSet";
            this.modelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseBindingSource
            // 
            this.databaseBindingSource.DataMember = "Database";
            this.databaseBindingSource.DataSource = this.modelDataSet;
            // 
            // databaseTableAdapter
            // 
            this.databaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DatabaseTableAdapter = this.databaseTableAdapter;
            this.tableAdapterManager.UpdateOrder = Lista_de_Cumparaturi.ModelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // databaseBindingNavigator
            // 
            this.databaseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.databaseBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.databaseBindingNavigator.BindingSource = this.databaseBindingSource;
            this.databaseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.databaseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.databaseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.databaseBindingNavigatorSaveItem,
            this.toolStripButton2,
            this.toolStripButton3});
            this.databaseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.databaseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.databaseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.databaseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.databaseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.databaseBindingNavigator.Name = "databaseBindingNavigator";
            this.databaseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.databaseBindingNavigator.Size = new System.Drawing.Size(746, 25);
            this.databaseBindingNavigator.TabIndex = 0;
            this.databaseBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // databaseBindingNavigatorSaveItem
            // 
            this.databaseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.databaseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("databaseBindingNavigatorSaveItem.Image")));
            this.databaseBindingNavigatorSaveItem.Name = "databaseBindingNavigatorSaveItem";
            this.databaseBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.databaseBindingNavigatorSaveItem.Text = "Save Data";
            this.databaseBindingNavigatorSaveItem.Click += new System.EventHandler(this.databaseBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(165, 22);
            this.toolStripButton2.Text = "Export To Excel Document";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Terminal";
            // 
            // nume_ProdusTextBox
            // 
            this.nume_ProdusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databaseBindingSource, "Nume Produs", true));
            this.nume_ProdusTextBox.Location = new System.Drawing.Point(92, 39);
            this.nume_ProdusTextBox.Name = "nume_ProdusTextBox";
            this.nume_ProdusTextBox.Size = new System.Drawing.Size(121, 20);
            this.nume_ProdusTextBox.TabIndex = 4;
            // 
            // cantitateTextBox
            // 
            this.cantitateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databaseBindingSource, "Cantitate", true));
            this.cantitateTextBox.Location = new System.Drawing.Point(149, 65);
            this.cantitateTextBox.Name = "cantitateTextBox";
            this.cantitateTextBox.Size = new System.Drawing.Size(64, 20);
            this.cantitateTextBox.TabIndex = 6;
            this.cantitateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cantitateTextBox.TextChanged += new System.EventHandler(this.cantitateTextBox_TextChanged);
            this.cantitateTextBox.Leave += new System.EventHandler(this.cantitateTextBox_Leave);
            // 
            // uMComboBox
            // 
            this.uMComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databaseBindingSource, "UM", true));
            this.uMComboBox.FormattingEnabled = true;
            this.uMComboBox.Items.AddRange(new object[] {
            "BUC",
            "KG",
            "LITRU",
            "STICLA",
            "SACI"});
            this.uMComboBox.Location = new System.Drawing.Point(315, 39);
            this.uMComboBox.Name = "uMComboBox";
            this.uMComboBox.Size = new System.Drawing.Size(84, 21);
            this.uMComboBox.TabIndex = 8;
            // 
            // pret__lei_TextBox
            // 
            this.pret__lei_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databaseBindingSource, "Pret (lei)", true));
            this.pret__lei_TextBox.Location = new System.Drawing.Point(315, 68);
            this.pret__lei_TextBox.Name = "pret__lei_TextBox";
            this.pret__lei_TextBox.Size = new System.Drawing.Size(84, 20);
            this.pret__lei_TextBox.TabIndex = 10;
            this.pret__lei_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pret__lei_TextBox.TextChanged += new System.EventHandler(this.pret__lei_TextBox_TextChanged);
            // 
            // total__lei_TextBox
            // 
            this.total__lei_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.databaseBindingSource, "Total (lei)", true));
            this.total__lei_TextBox.Location = new System.Drawing.Point(518, 68);
            this.total__lei_TextBox.Name = "total__lei_TextBox";
            this.total__lei_TextBox.ReadOnly = true;
            this.total__lei_TextBox.Size = new System.Drawing.Size(121, 20);
            this.total__lei_TextBox.TabIndex = 12;
            this.total__lei_TextBox.Text = "0";
            this.total__lei_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // databaseDataGridView
            // 
            this.databaseDataGridView.AutoGenerateColumns = false;
            this.databaseDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.databaseDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.databaseDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.databaseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.databaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.databaseDataGridView.DataSource = this.databaseBindingSource;
            this.databaseDataGridView.Location = new System.Drawing.Point(44, 120);
            this.databaseDataGridView.Name = "databaseDataGridView";
            this.databaseDataGridView.Size = new System.Drawing.Size(664, 287);
            this.databaseDataGridView.TabIndex = 13;
            this.databaseDataGridView.BackgroundColorChanged += new System.EventHandler(this.databaseDataGridView_BackgroundColorChanged);
            this.databaseDataGridView.TabIndexChanged += new System.EventHandler(this.databaseDataGridView_TabIndexChanged);
            this.databaseDataGridView.DragOver += new System.Windows.Forms.DragEventHandler(this.databaseDataGridView_DragOver);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume Produs";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume Produs";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cantitate";
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantitate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UM";
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "UM";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pret (lei)";
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Pret (lei)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Total (lei)";
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Total (lei)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(524, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total Produs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(405, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Lei";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(645, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lei";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(454, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "lei";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(256, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Total de Plata :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(384, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Visible = false;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(373, 420);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(84, 20);
            this.Total.TabIndex = 20;
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Lista_de_cumparaturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 455);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.databaseDataGridView);
            this.Controls.Add(nume_ProdusLabel);
            this.Controls.Add(this.nume_ProdusTextBox);
            this.Controls.Add(cantitateLabel);
            this.Controls.Add(this.cantitateTextBox);
            this.Controls.Add(uMLabel);
            this.Controls.Add(this.uMComboBox);
            this.Controls.Add(pret__lei_Label);
            this.Controls.Add(this.pret__lei_TextBox);
            this.Controls.Add(this.total__lei_TextBox);
            this.Controls.Add(this.databaseBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lista_de_cumparaturi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Cumparaturi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lista_de_cumparaturi_FormClosing);
            this.Load += new System.EventHandler(this.Lista_de_cumparaturi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingNavigator)).EndInit();
            this.databaseBindingNavigator.ResumeLayout(false);
            this.databaseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModelDataSet modelDataSet;
        private System.Windows.Forms.BindingSource databaseBindingSource;
        private ModelDataSetTableAdapters.DatabaseTableAdapter databaseTableAdapter;
        private ModelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator databaseBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton databaseBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nume_ProdusTextBox;
        private System.Windows.Forms.TextBox cantitateTextBox;
        private System.Windows.Forms.ComboBox uMComboBox;
        private System.Windows.Forms.TextBox pret__lei_TextBox;
        private System.Windows.Forms.TextBox total__lei_TextBox;
        private System.Windows.Forms.DataGridView databaseDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}