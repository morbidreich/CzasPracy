namespace CzasPracy1
{
    partial class frmPodsumowanie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPodsumowanie));
            this.czasPracyDataSet1 = new CzasPracy1.CzasPracyDataSet1();
            this.czasPracyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.czasPracyTableAdapter = new CzasPracy1.CzasPracyDataSet1TableAdapters.CzasPracyTableAdapter();
            this.tableAdapterManager = new CzasPracy1.CzasPracyDataSet1TableAdapters.TableAdapterManager();
            this.czasPracyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.czasPracyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgCzasPracy = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEksport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.czasPracyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.czasPracyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.czasPracyBindingNavigator)).BeginInit();
            this.czasPracyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCzasPracy)).BeginInit();
            this.SuspendLayout();
            // 
            // czasPracyDataSet1
            // 
            this.czasPracyDataSet1.DataSetName = "CzasPracyDataSet1";
            this.czasPracyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // czasPracyBindingSource
            // 
            this.czasPracyBindingSource.DataMember = "CzasPracy";
            this.czasPracyBindingSource.DataSource = this.czasPracyDataSet1;
            // 
            // czasPracyTableAdapter
            // 
            this.czasPracyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACCgrafikTableAdapter = null;
            this.tableAdapterManager.APPgrafikTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CzasPracyTableAdapter = this.czasPracyTableAdapter;
            this.tableAdapterManager.InstruktorzyTableAdapter = null;
            this.tableAdapterManager.PilociTableAdapter = null;
            this.tableAdapterManager.SluzbyTableAdapter = null;
            this.tableAdapterManager.TWRgrafikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CzasPracy1.CzasPracyDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // czasPracyBindingNavigator
            // 
            this.czasPracyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.czasPracyBindingNavigator.BindingSource = this.czasPracyBindingSource;
            this.czasPracyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.czasPracyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.czasPracyBindingNavigator.Enabled = false;
            this.czasPracyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.czasPracyBindingNavigatorSaveItem});
            this.czasPracyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.czasPracyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.czasPracyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.czasPracyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.czasPracyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.czasPracyBindingNavigator.Name = "czasPracyBindingNavigator";
            this.czasPracyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.czasPracyBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.czasPracyBindingNavigator.Size = new System.Drawing.Size(974, 25);
            this.czasPracyBindingNavigator.TabIndex = 0;
            this.czasPracyBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
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
            // czasPracyBindingNavigatorSaveItem
            // 
            this.czasPracyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.czasPracyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("czasPracyBindingNavigatorSaveItem.Image")));
            this.czasPracyBindingNavigatorSaveItem.Name = "czasPracyBindingNavigatorSaveItem";
            this.czasPracyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.czasPracyBindingNavigatorSaveItem.Text = "Save Data";
            this.czasPracyBindingNavigatorSaveItem.Click += new System.EventHandler(this.czasPracyBindingNavigatorSaveItem_Click);
            // 
            // dgCzasPracy
            // 
            this.dgCzasPracy.AllowUserToAddRows = false;
            this.dgCzasPracy.AllowUserToDeleteRows = false;
            this.dgCzasPracy.AutoGenerateColumns = false;
            this.dgCzasPracy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCzasPracy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgCzasPracy.DataSource = this.czasPracyBindingSource;
            this.dgCzasPracy.Location = new System.Drawing.Point(12, 69);
            this.dgCzasPracy.Name = "dgCzasPracy";
            this.dgCzasPracy.ReadOnly = true;
            this.dgCzasPracy.Size = new System.Drawing.Size(744, 420);
            this.dgCzasPracy.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Pilot";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pilot";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sluzba";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sluzba";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Instruktor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Instruktor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Info";
            this.dataGridViewTextBoxColumn5.HeaderText = "Info";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 160;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GodzStart";
            this.dataGridViewTextBoxColumn6.HeaderText = "GodzStart";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GodzKoniec";
            this.dataGridViewTextBoxColumn7.HeaderText = "GodzKoniec";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(763, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 351);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtry";
            // 
            // btnEksport
            // 
            this.btnEksport.Location = new System.Drawing.Point(770, 466);
            this.btnEksport.Name = "btnEksport";
            this.btnEksport.Size = new System.Drawing.Size(121, 23);
            this.btnEksport.TabIndex = 1;
            this.btnEksport.Text = "Eksportuj do Excella";
            this.btnEksport.UseVisualStyleBackColor = true;
            this.btnEksport.Click += new System.EventHandler(this.btnEksport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "filtr test Antkowiak";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPodsumowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEksport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgCzasPracy);
            this.Controls.Add(this.czasPracyBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPodsumowanie";
            this.Text = "Podsumowanie";
            this.Load += new System.EventHandler(this.frmPodsumowanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.czasPracyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.czasPracyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.czasPracyBindingNavigator)).EndInit();
            this.czasPracyBindingNavigator.ResumeLayout(false);
            this.czasPracyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCzasPracy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CzasPracyDataSet1 czasPracyDataSet1;
        private System.Windows.Forms.BindingSource czasPracyBindingSource;
        private CzasPracyDataSet1TableAdapters.CzasPracyTableAdapter czasPracyTableAdapter;
        private CzasPracyDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator czasPracyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton czasPracyBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgCzasPracy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEksport;
        private System.Windows.Forms.Button button1;
    }
}