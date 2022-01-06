namespace CzasPracy1
{
    partial class frmGrafikAPP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrafikAPP));
            this.czasPracyDataSet1 = new CzasPracy1.CzasPracyDataSet1();
            this.aPPgrafikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPPgrafikTableAdapter = new CzasPracy1.CzasPracyDataSet1TableAdapters.APPgrafikTableAdapter();
            this.tableAdapterManager = new CzasPracy1.CzasPracyDataSet1TableAdapters.TableAdapterManager();
            this.aPPgrafikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.aPPgrafikBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.aPPgrafikDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.czasPracyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPgrafikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPgrafikBindingNavigator)).BeginInit();
            this.aPPgrafikBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPPgrafikDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // czasPracyDataSet1
            // 
            this.czasPracyDataSet1.DataSetName = "CzasPracyDataSet1";
            this.czasPracyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPPgrafikBindingSource
            // 
            this.aPPgrafikBindingSource.DataMember = "APPgrafik";
            this.aPPgrafikBindingSource.DataSource = this.czasPracyDataSet1;
            // 
            // aPPgrafikTableAdapter
            // 
            this.aPPgrafikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACCgrafikTableAdapter = null;
            this.tableAdapterManager.APPgrafikTableAdapter = this.aPPgrafikTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CzasPracyTableAdapter = null;
            this.tableAdapterManager.InstruktorzyTableAdapter = null;
            this.tableAdapterManager.PilociTableAdapter = null;
            this.tableAdapterManager.SluzbyTableAdapter = null;
            this.tableAdapterManager.TWRgrafikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CzasPracy1.CzasPracyDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aPPgrafikBindingNavigator
            // 
            this.aPPgrafikBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aPPgrafikBindingNavigator.BindingSource = this.aPPgrafikBindingSource;
            this.aPPgrafikBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aPPgrafikBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aPPgrafikBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aPPgrafikBindingNavigatorSaveItem});
            this.aPPgrafikBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aPPgrafikBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aPPgrafikBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aPPgrafikBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aPPgrafikBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aPPgrafikBindingNavigator.Name = "aPPgrafikBindingNavigator";
            this.aPPgrafikBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aPPgrafikBindingNavigator.Size = new System.Drawing.Size(353, 25);
            this.aPPgrafikBindingNavigator.TabIndex = 0;
            this.aPPgrafikBindingNavigator.Text = "bindingNavigator1";
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
            // aPPgrafikBindingNavigatorSaveItem
            // 
            this.aPPgrafikBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aPPgrafikBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aPPgrafikBindingNavigatorSaveItem.Image")));
            this.aPPgrafikBindingNavigatorSaveItem.Name = "aPPgrafikBindingNavigatorSaveItem";
            this.aPPgrafikBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aPPgrafikBindingNavigatorSaveItem.Text = "Save Data";
            this.aPPgrafikBindingNavigatorSaveItem.Click += new System.EventHandler(this.aPPgrafikBindingNavigatorSaveItem_Click);
            // 
            // aPPgrafikDataGridView
            // 
            this.aPPgrafikDataGridView.AutoGenerateColumns = false;
            this.aPPgrafikDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aPPgrafikDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.aPPgrafikDataGridView.DataSource = this.aPPgrafikBindingSource;
            this.aPPgrafikDataGridView.Location = new System.Drawing.Point(25, 46);
            this.aPPgrafikDataGridView.Name = "aPPgrafikDataGridView";
            this.aPPgrafikDataGridView.Size = new System.Drawing.Size(300, 220);
            this.aPPgrafikDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Czas";
            this.dataGridViewTextBoxColumn1.HeaderText = "Czas";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // frmGrafikAPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 297);
            this.Controls.Add(this.aPPgrafikDataGridView);
            this.Controls.Add(this.aPPgrafikBindingNavigator);
            this.Name = "frmGrafikAPP";
            this.Text = "Grafik APP";
            this.Load += new System.EventHandler(this.frmGrafikAPP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.czasPracyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPgrafikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPgrafikBindingNavigator)).EndInit();
            this.aPPgrafikBindingNavigator.ResumeLayout(false);
            this.aPPgrafikBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPPgrafikDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CzasPracyDataSet1 czasPracyDataSet1;
        private System.Windows.Forms.BindingSource aPPgrafikBindingSource;
        private CzasPracyDataSet1TableAdapters.APPgrafikTableAdapter aPPgrafikTableAdapter;
        private CzasPracyDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aPPgrafikBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aPPgrafikBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView aPPgrafikDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}