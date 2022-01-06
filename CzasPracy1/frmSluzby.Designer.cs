namespace CzasPracy1
{
    partial class frmSluzby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSluzby));
            System.Windows.Forms.Label sluzbaLabel;
            System.Windows.Forms.Label aktywnaLabel;
            this.czasPracyDataSet1 = new CzasPracy1.CzasPracyDataSet1();
            this.sluzbyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sluzbyTableAdapter = new CzasPracy1.CzasPracyDataSet1TableAdapters.SluzbyTableAdapter();
            this.tableAdapterManager = new CzasPracy1.CzasPracyDataSet1TableAdapters.TableAdapterManager();
            this.sluzbyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sluzbyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sluzbaTextBox = new System.Windows.Forms.TextBox();
            this.aktywnaCheckBox = new System.Windows.Forms.CheckBox();
            this.sluzbyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            sluzbaLabel = new System.Windows.Forms.Label();
            aktywnaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.czasPracyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluzbyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluzbyBindingNavigator)).BeginInit();
            this.sluzbyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sluzbyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // czasPracyDataSet1
            // 
            this.czasPracyDataSet1.DataSetName = "CzasPracyDataSet1";
            this.czasPracyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sluzbyBindingSource
            // 
            this.sluzbyBindingSource.DataMember = "Sluzby";
            this.sluzbyBindingSource.DataSource = this.czasPracyDataSet1;
            // 
            // sluzbyTableAdapter
            // 
            this.sluzbyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACCgrafikTableAdapter = null;
            this.tableAdapterManager.APPgrafikTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CzasPracyTableAdapter = null;
            this.tableAdapterManager.InstruktorzyTableAdapter = null;
            this.tableAdapterManager.PilociTableAdapter = null;
            this.tableAdapterManager.SluzbyTableAdapter = this.sluzbyTableAdapter;
            this.tableAdapterManager.TWRgrafikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CzasPracy1.CzasPracyDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sluzbyBindingNavigator
            // 
            this.sluzbyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sluzbyBindingNavigator.BindingSource = this.sluzbyBindingSource;
            this.sluzbyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sluzbyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sluzbyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sluzbyBindingNavigatorSaveItem});
            this.sluzbyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sluzbyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sluzbyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sluzbyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sluzbyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sluzbyBindingNavigator.Name = "sluzbyBindingNavigator";
            this.sluzbyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sluzbyBindingNavigator.Size = new System.Drawing.Size(456, 25);
            this.sluzbyBindingNavigator.TabIndex = 0;
            this.sluzbyBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // sluzbyBindingNavigatorSaveItem
            // 
            this.sluzbyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sluzbyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sluzbyBindingNavigatorSaveItem.Image")));
            this.sluzbyBindingNavigatorSaveItem.Name = "sluzbyBindingNavigatorSaveItem";
            this.sluzbyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.sluzbyBindingNavigatorSaveItem.Text = "Save Data";
            this.sluzbyBindingNavigatorSaveItem.Click += new System.EventHandler(this.sluzbyBindingNavigatorSaveItem_Click_1);
            // 
            // sluzbaLabel
            // 
            sluzbaLabel.AutoSize = true;
            sluzbaLabel.Location = new System.Drawing.Point(14, 55);
            sluzbaLabel.Name = "sluzbaLabel";
            sluzbaLabel.Size = new System.Drawing.Size(42, 13);
            sluzbaLabel.TabIndex = 1;
            sluzbaLabel.Text = "Sluzba:";
            // 
            // sluzbaTextBox
            // 
            this.sluzbaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sluzbyBindingSource, "Sluzba", true));
            this.sluzbaTextBox.Location = new System.Drawing.Point(71, 52);
            this.sluzbaTextBox.Name = "sluzbaTextBox";
            this.sluzbaTextBox.Size = new System.Drawing.Size(104, 20);
            this.sluzbaTextBox.TabIndex = 2;
            // 
            // aktywnaLabel
            // 
            aktywnaLabel.AutoSize = true;
            aktywnaLabel.Location = new System.Drawing.Point(14, 83);
            aktywnaLabel.Name = "aktywnaLabel";
            aktywnaLabel.Size = new System.Drawing.Size(51, 13);
            aktywnaLabel.TabIndex = 3;
            aktywnaLabel.Text = "Aktywna:";
            // 
            // aktywnaCheckBox
            // 
            this.aktywnaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.sluzbyBindingSource, "Aktywna", true));
            this.aktywnaCheckBox.Location = new System.Drawing.Point(71, 78);
            this.aktywnaCheckBox.Name = "aktywnaCheckBox";
            this.aktywnaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.aktywnaCheckBox.TabIndex = 4;
            this.aktywnaCheckBox.UseVisualStyleBackColor = true;
            // 
            // sluzbyDataGridView
            // 
            this.sluzbyDataGridView.AutoGenerateColumns = false;
            this.sluzbyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sluzbyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1});
            this.sluzbyDataGridView.DataSource = this.sluzbyBindingSource;
            this.sluzbyDataGridView.Location = new System.Drawing.Point(192, 52);
            this.sluzbyDataGridView.Name = "sluzbyDataGridView";
            this.sluzbyDataGridView.Size = new System.Drawing.Size(245, 311);
            this.sluzbyDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Sluzba";
            this.dataGridViewTextBoxColumn1.HeaderText = "Sluzba";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Aktywna";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Aktywna";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // frmSluzby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 379);
            this.Controls.Add(this.sluzbyDataGridView);
            this.Controls.Add(sluzbaLabel);
            this.Controls.Add(this.sluzbaTextBox);
            this.Controls.Add(aktywnaLabel);
            this.Controls.Add(this.aktywnaCheckBox);
            this.Controls.Add(this.sluzbyBindingNavigator);
            this.Name = "frmSluzby";
            this.Text = "Służby";
            this.Load += new System.EventHandler(this.frmSluzby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.czasPracyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluzbyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluzbyBindingNavigator)).EndInit();
            this.sluzbyBindingNavigator.ResumeLayout(false);
            this.sluzbyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sluzbyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CzasPracyDataSet1 czasPracyDataSet1;
        private System.Windows.Forms.BindingSource sluzbyBindingSource;
        private CzasPracyDataSet1TableAdapters.SluzbyTableAdapter sluzbyTableAdapter;
        private CzasPracyDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sluzbyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sluzbyBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox sluzbaTextBox;
        private System.Windows.Forms.CheckBox aktywnaCheckBox;
        private System.Windows.Forms.DataGridView sluzbyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;

    }
}