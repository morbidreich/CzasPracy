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
    public partial class frmGrafikTWR : Form
    {
        public frmGrafikTWR()
        {
            InitializeComponent();
        }

        private void tWRgrafikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tWRgrafikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.czasPracyDataSet1);

        }

        private void frmGrafikTWR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'czasPracyDataSet1.TWRgrafik' table. You can move, or remove it, as needed.
            this.tWRgrafikTableAdapter.Fill(this.czasPracyDataSet1.TWRgrafik);

        }
    }
}
