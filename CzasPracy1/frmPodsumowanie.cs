using System;

using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CzasPracy1
{
    public partial class frmPodsumowanie : Form
    {
        public frmPodsumowanie()
        {
            InitializeComponent();
            
            
            //czasPracyBindingSource.Filter = "Pilot = 'Antkowiak M'";
        }

        private void czasPracyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.czasPracyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.czasPracyDataSet1);

        }

        private void frmPodsumowanie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'czasPracyDataSet1.CzasPracy' table. You can move, or remove it, as needed.
            this.czasPracyTableAdapter.Fill(this.czasPracyDataSet1.CzasPracy);

        }

        private void btnEksport_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Niemożliwe, na tym komputerze nie zainstalowano Excela");
                return;
            }
            else
            {
                //Excel.Workbook xlWorkBook = new Excel.Workbook();
                //Excel.Worksheet xlWorkSheet = new Excel.Worksheet();

                xlApp.Workbooks.Add();
                Excel._Worksheet xlWorkSheet = (Excel.Worksheet)xlApp.ActiveSheet;

                int i = 0;
                int j = 0;


                // legenda:
                xlWorkSheet.Cells[1, 1] = "Lp";
                xlWorkSheet.Cells[1, 2] = "Data";
                xlWorkSheet.Cells[1, 3] = "Pilot";
                xlWorkSheet.Cells[1, 4] = "Służba";
                xlWorkSheet.Cells[1, 5] = "Instruktor";
                xlWorkSheet.Cells[1, 6] = "Info";
                xlWorkSheet.Cells[1, 7] = "Godz. startu";
                xlWorkSheet.Cells[1, 8] = "Godz. zakończenia";
                xlWorkSheet.Cells[1, 9] = "Czas pracy [min]";
                

                for (i = 0; i <= dgCzasPracy.RowCount - 1; i++)
                {
                    //for (j = 0; j <= dgCzasPracy.ColumnCount - 1; j++)
                    //{
                    //    DataGridViewCell komorka = dgCzasPracy[j, i];

                    //    xlWorkSheet.Cells[i + 2, j + 1] = komorka.Value;
                    //    //zaczynam od drugiego wiersza żeby zmieścić legendę

                    //}

                    DataGridViewCell lp = dgCzasPracy[0, i];
                    DataGridViewCell pilot = dgCzasPracy[1, i];
                    DataGridViewCell sluzba = dgCzasPracy[2, i];
                    DataGridViewCell instruktor = dgCzasPracy[3, i];
                    DataGridViewCell info = dgCzasPracy[4, i];
                    DataGridViewCell start = dgCzasPracy[5, i];
                    DataGridViewCell koniec = dgCzasPracy[6, i];

                    string temp = start.Value.ToString();
                    DateTime dataTemp = new DateTime(int.Parse(temp.Substring(0, 4)), int.Parse(temp.Substring(5, 2)), int.Parse(temp.Substring(8, 2)));


                    xlWorkSheet.Cells[i + 2, 1] = i + 1;
                    xlWorkSheet.Cells[i + 2, 2] = (dataTemp.Date.ToString()).Substring(0, 10);
                    xlWorkSheet.Cells[i + 2, 3] = pilot.Value;
                    xlWorkSheet.Cells[i + 2, 4] = sluzba.Value;
                    xlWorkSheet.Cells[i + 2, 5] = instruktor.Value;
                    xlWorkSheet.Cells[i + 2, 6] = info.Value;
                    xlWorkSheet.Cells[i + 2, 7] = (start.Value.ToString()).Substring(11, 5);
                    xlWorkSheet.Cells[i + 2, 8] = (koniec.Value.ToString()).Substring(11, 5);
                    xlWorkSheet.Cells[i + 2, 9] = policzRoznice(start, koniec);





                }

                

                xlWorkSheet.Columns.AutoFit();
                xlApp.Visible = true;
                    

                

            }
        }

        private dynamic policzRoznice(DataGridViewCell _start, DataGridViewCell _koniec)
        {
            string poczatek = _start.Value.ToString();
            string koniec = _koniec.Value.ToString();

            DateTime a = new DateTime(2015, 05, 05, int.Parse(poczatek.Substring(11, 2)), int.Parse(poczatek.Substring(14, 2)), 0);
            DateTime b = new DateTime(2015, 05, 05, int.Parse(koniec.Substring(11, 2)), int.Parse(koniec.Substring(14, 2)), 0);

            return b.Subtract(a).TotalMinutes.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            czasPracyBindingSource.Filter = "Pilot = 'Antkowiak M'";
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.czasPracyTableAdapter.FillBy(this.czasPracyDataSet1.CzasPracy);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
