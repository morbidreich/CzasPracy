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
    public partial class frmGrafikACC : Form
    {
        public frmGrafikACC()
        {
            InitializeComponent();
        }

        private void aCCgrafikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aCCgrafikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.czasPracyDataSet1);

        }

        private void frmGrafikACC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'czasPracyDataSet1.ACCgrafik' table. You can move, or remove it, as needed.
            this.aCCgrafikTableAdapter.Fill(this.czasPracyDataSet1.ACCgrafik);

        }
    }
}
