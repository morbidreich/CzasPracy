namespace CzasPracy1
{
    partial class frmInstruktorzy
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
            System.Windows.Forms.Label instruktorLabel;
            System.Windows.Forms.Label typLabel;
            System.Windows.Forms.Label aktywnyLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstruktorzy));
            this.czasPracyDataSet1 = new CzasPracy1.CzasPracyDataSet1();
            this.instruktorzyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instruktorzyTableAdapter = new CzasPracy1.CzasPracyDataSet1TableAdapters.InstruktorzyTableAdapter();
            this.tableAdapterManager = new CzasPracy1.CzasPracyDataSet1TableAdapters.TableAdapterManager();
            this.instruktorzyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.instruktorzyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.instruktorTextBox = new System.Windows.Forms.TextBox();
            this.typTextBox = new System.Windows.Forms.TextBox();
            this.aktywnyCheckBox = new System.Windows.Forms.CheckBox();
            this.instruktorzyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            instruktorLabel = new System.Windows.Forms.Label();
            typLabel = new System.Windows.Forms.Label();
            aktywnyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.czasPracyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktorzyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktorzyBindingNavigator)).BeginInit();
            this.instruktorzyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instruktorzyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // instruktorLabel
            // 
            instruktorLabel.AutoSize = true;
            instruktorLabel.Location = new System.Drawing.Point(17, 52);
            instruktorLabel.Name = "instruktorLabel";
            instruktorLabel.Size = new System.Drawing.Size(54, 13);
            instruktorLabel.TabIndex = 1;
            instruktorLabel.Text = "Instruktor:";
            // 
            // typLabel
            // 
            typLabel.AutoSize = true;
            typLabel.Location = new System.Drawing.Point(17, 78);
            typLabel.Name = "typLabel";
            typLabel.Size = new System.Drawing.Size(28, 13);
            typLabel.TabIndex = 3;
            typLabel.Text = "Typ:";
            // 
            // aktywnyLabel
            // 
            aktywnyLabel.AutoSize = true;
            aktywnyLabel.Location = new System.Drawing.Point(17, 106);
            aktywnyLabel.Name = "aktywnyLabel";
            aktywnyLabel.Size = new System.Drawing.Size(50, 13);
            aktywnyLabel.TabIndex = 5;
            aktywnyLabel.Text = "Aktywny:";
            // 
            // czasPracyDataSet1
            // 
            this.czasPracyDataSet1.DataSetName = "CzasPracyDataSet1";
            this.czasPracyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instruktorzyBindingSource
            // 
            this.instruktorzyBindingSource.DataMember = "Instruktorzy";
            this.instruktorzyBindingSource.DataSource = this.czasPracyDataSet1;
            // 
            // instruktorzyTableAdapter
            // 
            this.instruktorzyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACCgrafikTableAdapter = null;
            this.tableAdapterManager.APPgrafikTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CzasPracyTableAdapter = null;
            this.tableAdapterManager.InstruktorzyTableAdapter = this.instruktorzyTableAdapter;
            this.tableAdapterManager.PilociTableAdapter = null;
            this.tableAdapterManager.SluzbyTableAdapter = null;
            this.tableAdapterManager.TWRgrafikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CzasPracy1.CzasPracyDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // instruktorzyBindingNavigator
            // 
            this.instruktorzyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.instruktorzyBindingNavigator.BindingSource = this.instruktorzyBindingSource;
            this.instruktorzyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.instruktorzyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.instruktorzyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.instruktorzyBindingNavigatorSaveItem});
            this.instruktorzyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.instruktorzyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.instruktorzyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.instruktorzyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.instruktorzyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.instruktorzyBindingNavigator.Name = "instruktorzyBindingNavigator";
            this.instruktorzyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.instruktorzyBindingNavigator.Size = new System.Drawing.Size(567, 25);
            this.instruktorzyBindingNavigator.TabIndex = 0;
            this.instruktorzyBindingNavigator.Text = "bindingNavigator1";
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
            // instruktorzyBindingNavigatorSaveItem
            // 
            this.instruktorzyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.instruktorzyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("instruktorzyBindingNavigatorSaveItem.Image")));
            this.instruktorzyBindingNavigatorSaveItem.Name = "instruktorzyBindingNavigatorSaveItem";
            this.instruktorzyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.instruktorzyBindingNavigatorSaveItem.Text = "Save Data";
            this.instruktorzyBindingNavigatorSaveItem.Click += new System.EventHandler(this.instruktorzyBindingNavigatorSaveItem_Click_2);
            // 
            // instruktorTextBox
            // 
            this.instruktorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instruktorzyBindingSource, "Instruktor", true));
            this.instruktorTextBox.Location = new System.Drawing.Point(77, 49);
            this.instruktorTextBox.Name = "instruktorTextBox";
            this.instruktorTextBox.Size = new System.Drawing.Size(104, 20);
            this.instruktorTextBox.TabIndex = 2;
            // 
            // typTextBox
            // 
            this.typTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instruktorzyBindingSource, "Typ", true));
            this.typTextBox.Location = new System.Drawing.Point(77, 75);
            this.typTextBox.Name = "typTextBox";
            this.typTextBox.Size = new System.Drawing.Size(104, 20);
            this.typTextBox.TabIndex = 4;
            // 
            // aktywnyCheckBox
            // 
            this.aktywnyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.instruktorzyBindingSource, "Aktywny", true));
            this.aktywnyCheckBox.Location = new System.Drawing.Point(77, 101);
            this.aktywnyCheckBox.Name = "aktywnyCheckBox";
            this.aktywnyCheckBox.Size = new System.Drawing.Size(104, 24);
            this.aktywnyCheckBox.TabIndex = 6;
            this.aktywnyCheckBox.UseVisualStyleBackColor = true;
            // 
            // instruktorzyDataGridView
            // 
            this.instruktorzyDataGridView.AutoGenerateColumns = false;
            this.instruktorzyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instruktorzyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.instruktorzyDataGridView.DataSource = this.instruktorzyBindingSource;
            this.instruktorzyDataGridView.Location = new System.Drawing.Point(205, 49);
            this.instruktorzyDataGridView.Name = "instruktorzyDataGridView";
            this.instruktorzyDataGridView.Size = new System.Drawing.Size(346, 331);
            this.instruktorzyDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Instruktor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Instruktor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Typ";
            this.dataGridViewTextBoxColumn2.HeaderText = "Typ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Aktywny";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Aktywny";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // frmInstruktorzy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 392);
            this.Controls.Add(this.instruktorzyDataGridView);
            this.Controls.Add(instruktorLabel);
            this.Controls.Add(this.instruktorTextBox);
            this.Controls.Add(typLabel);
            this.Controls.Add(this.typTextBox);
            this.Controls.Add(aktywnyLabel);
            this.Controls.Add(this.aktywnyCheckBox);
            this.Controls.Add(this.instruktorzyBindingNavigator);
            this.Name = "frmInstruktorzy";
            this.Text = "Instruktorzy";
            this.Load += new System.EventHandler(this.frmInstruktorzy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.czasPracyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktorzyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktorzyBindingNavigator)).EndInit();
            this.instruktorzyBindingNavigator.ResumeLayout(false);
            this.instruktorzyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instruktorzyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CzasPracyDataSet1 czasPracyDataSet1;
        private System.Windows.Forms.BindingSource instruktorzyBindingSource;
        private CzasPracyDataSet1TableAdapters.InstruktorzyTableAdapter instruktorzyTableAdapter;
        private CzasPracyDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator instruktorzyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton instruktorzyBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox instruktorTextBox;
        private System.Windows.Forms.TextBox typTextBox;
        private System.Windows.Forms.CheckBox aktywnyCheckBox;
        private System.Windows.Forms.DataGridView instruktorzyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;


    }
}