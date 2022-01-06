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
    public partial class frmSluzby : Form
    {
        public frmSluzby()
        {
            InitializeComponent();
        }

        private void sluzbyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sluzbyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.czasPracyDataSet1);

        }

        private void frmSluzby_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'czasPracyDataSet1.Sluzby' table. You can move, or remove it, as needed.
            this.sluzbyTableAdapter.Fill(this.czasPracyDataSet1.Sluzby);
            // TODO: This line of code loads data into the 'czasPracyDataSet1.Sluzby' table. You can move, or remove it, as needed.
            this.sluzbyTableAdapter.Fill(this.czasPracyDataSet1.Sluzby);

        }

        private void sluzbyBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sluzbyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.czasPracyDataSet1);

        }
    }
}
