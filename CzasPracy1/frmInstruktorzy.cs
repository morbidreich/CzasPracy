using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CzasPracy1
{
    public partial class frmInstruktorzy : Form
    {
        public frmInstruktorzy()
        {
            InitializeComponent();
        }

        private void instruktorzyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.instruktorzyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.czasPracyDataSet1);

        }

        private void frmInstruktorzy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'czasPracyDataSet1.Instruktorzy' table. You can move, or remove it, as needed.
            this.instruktorzyTableAdapter.Fill(this.czasPracyDataSet1.Instruktorzy);
            // TODO: This line of code loads data into the 'czasPracyDataSet1.Instruktorzy' table. You can move, or remove it, as needed.
            this.instruktorzyTableAdapter.Fill(this.czasPracyDataSet1.Instruktorzy);
            
            

        }

        private void instruktorzyBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.instruktorzyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.czasPracyDataSet1);

        }

        private void instruktorzyBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.instruktorzyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.czasPracyDataSet1);

        }
    }
}
