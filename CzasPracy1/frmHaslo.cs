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
    public partial class frmHaslo : Form
    {
        string elementDocelowy;

        public frmHaslo(string elDoc)
        {
            InitializeComponent();
            elementDocelowy = elDoc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "haslo")
            {
                switch (elementDocelowy)
                {
                    case "frmPiloci":
                        frmPiloci frmPiloci1 = new frmPiloci();
                        frmPiloci1.ShowDialog();
                        this.Close();
                    break;

                    case "frmInstruktorzy":
                        frmInstruktorzy frmInstruktorzy1 = new frmInstruktorzy();
                        frmInstruktorzy1.ShowDialog();
                        this.Close();
                    break;

                    case "frmSluzby":
                        frmSluzby frmSluzby1 = new frmSluzby();
                        frmSluzby1.ShowDialog();
                        this.Close();
                    break;

                    case "frmGrafikACC":
                        frmGrafikACC frmGrafikACC1 = new frmGrafikACC();
                        frmGrafikACC1.ShowDialog();
                        this.Close();
                    break;

                    case "frmGrafikAPP":
                        frmGrafikAPP frmGrafikAPP1 = new frmGrafikAPP();
                        frmGrafikAPP1.ShowDialog();
                        this.Close();
                    break;

                    case "frmGrafikTWR":
                        frmGrafikTWR frmGrafikTWR1 = new frmGrafikTWR();
                        frmGrafikTWR1.ShowDialog();
                        this.Close();
                    break;

                    default:
                    break;
            }
                
            }
            else
                MessageBox.Show("Błędne hasło", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                button1_Click(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
