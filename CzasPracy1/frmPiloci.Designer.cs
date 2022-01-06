namespace CzasPracy1
{
    partial class frmPiloci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPiloci));
            this.czasPracyDataSet1 = new CzasPracy1.CzasPracyDataSet1();
            this.pilociBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilociTableAdapter = new CzasPracy1.CzasPracyDataSet1TableAdapters.PilociTableAdapter();
            this.tableAdapterManager = new CzasPracy1.CzasPracyDataSet1TableAdapters.TableAdapterManager();
            this.pilociBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pilociBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pilociDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.czasPracyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilociBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilociBindingNavigator)).BeginInit();
            this.pilociBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilociDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // czasPracyDataSet1
            // 
            this.czasPracyDataSet1.DataSetName = "CzasPracyDataSet1";
            this.czasPracyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pilociBindingSource
            // 
            this.pilociBindingSource.DataMember = "Piloci";
            this.pilociBindingSource.DataSource = this.czasPracyDataSet1;
            // 
            // pilociTableAdapter
            // 
            this.pilociTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACCgrafikTableAdapter = null;
            this.tableAdapterManager.APPgrafikTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CzasPracyTableAdapter = null;
            this.tableAdapterManager.InstruktorzyTableAdapter = null;
            this.tableAdapterManager.PilociTableAdapter = this.pilociTableAdapter;
            this.tableAdapterManager.SluzbyTableAdapter = null;
            this.tableAdapterManager.TWRgrafikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CzasPracy1.CzasPracyDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pilociBindingNavigator
            // 
            this.pilociBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pilociBindingNavigator.BindingSource = this.pilociBindingSource;
            this.pilociBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pilociBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pilociBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pilociBindingNavigatorSaveItem});
            this.pilociBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pilociBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pilociBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pilociBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pilociBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pilociBindingNavigator.Name = "pilociBindingNavigator";
            this.pilociBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pilociBindingNavigator.Size = new System.Drawing.Size(285, 25);
            this.pilociBindingNavigator.TabIndex = 0;
            this.pilociBindingNavigator.Text = "bindingNavigator1";
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
            // pilociBindingNavigatorSaveItem
            // 
            this.pilociBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pilociBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pilociBindingNavigatorSaveItem.Image")));
            this.pilociBindingNavigatorSaveItem.Name = "pilociBindingNavigatorSaveItem";
            this.pilociBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pilociBindingNavigatorSaveItem.Text = "Save Data";
            this.pilociBindingNavigatorSaveItem.Click += new System.EventHandler(this.pilociBindingNavigatorSaveItem_Click);
            // 
            // pilociDataGridView
            // 
            this.pilociDataGridView.AutoGenerateColumns = false;
            this.pilociDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pilociDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1});
            this.pilociDataGridView.DataSource = this.pilociBindingSource;
            this.pilociDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pilociDataGridView.Location = new System.Drawing.Point(0, 25);
            this.pilociDataGridView.Name = "pilociDataGridView";
            this.pilociDataGridView.Size = new System.Drawing.Size(285, 359);
            this.pilociDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Pilot";
            this.dataGridViewTextBoxColumn1.HeaderText = "Pilot";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Aktywny";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Aktywny";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // frmPiloci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 384);
            this.Controls.Add(this.pilociDataGridView);
            this.Controls.Add(this.pilociBindingNavigator);
            this.MinimumSize = new System.Drawing.Size(301, 422);
            this.Name = "frmPiloci";
            this.Text = "Piloci";
            this.Load += new System.EventHandler(this.frmPiloci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.czasPracyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilociBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilociBindingNavigator)).EndInit();
            this.pilociBindingNavigator.ResumeLayout(false);
            this.pilociBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilociDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CzasPracyDataSet1 czasPracyDataSet1;
        private System.Windows.Forms.BindingSource pilociBindingSource;
        private CzasPracyDataSet1TableAdapters.PilociTableAdapter pilociTableAdapter;
        private CzasPracyDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pilociBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pilociBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pilociDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;

    }
}