using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CzasPracy1
{
    public partial class frmCzasPracy : Form
    {

        SqlConnection conn = new SqlConnection();
        bool GodzZGrafiku;
        DateTime data = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);


        public frmCzasPracy()
        {
            InitializeComponent();

            //lblData.Text = DateTime.Now.ToString("D");

            lblData.Text = dataDoString(data);

            //konfiguracja polaczenia z baza danych
            //Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = "C:\Users\User\Desktop\CzasPracy - projekt 08 06 2015\CzasPracy - projekt\CzasPracy1\czasPracy.mdf"; Integrated Security = True; Connect Timeout = 30
            //Data Source = (LocalDB)\v11.0; AttachDbFilename =| DataDirectory |\CzasPracy.mdf1; Integrated Security = True
            string strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CzasPracy.mdf;Integrated Security=True";
            conn.ConnectionString = strcon;

            dodajRadBtnSluzb(conn);
            dodajRadBtnPilot(conn);

            bool test = czySieNaklada("Kujda B", data, data, conn);
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                string sluzba = null;
                string instruktor = "";

                //DateTime data = DateTime.Now;

                int intGodzKoniec = -1;
                int intMinKoniec = -1;
                int intGodzStart = -1;
                int intMinStart = -1;

                DateTime poczatek;
                DateTime koniec;

                List<string> listaZaznaczonychPilotow = new List<string>();

                //sprawdzam pilota
                foreach (Control przycisk in this.gbPiloci.Controls)
                    if (przycisk is CheckBox)
                    {
                        CheckBox cb = przycisk as CheckBox;
                        if (cb.Checked)
                            listaZaznaczonychPilotow.Add(cb.Text);
                    }

                //sprawdzam sluzbe
                foreach (Control przycisk in this.gbSluzba.Controls)
                    if (przycisk is RadioButton)
                    {
                        RadioButton rd = przycisk as RadioButton;
                        if (rd.Checked)
                            sluzba = rd.Text;
                    }

                //sprawdzam instruktora
                foreach (Control przycisk in this.gbInstruktorzy.Controls)
                    if (przycisk is RadioButton)
                    {
                        RadioButton rd = przycisk as RadioButton;
                        if (rd.Checked)
                            instruktor = rd.Text;
                    }

                //sprawdzam godzine startu
                foreach (RadioButton przycisk in this.gbGodzStart.Controls)
                    if (przycisk.Checked)
                        intGodzStart = int.Parse(przycisk.Text);                    

                //sprawdzam min startu
                foreach (RadioButton przycisk in this.gbMinStart.Controls)
                    if (przycisk.Checked)
                        intMinStart = int.Parse(przycisk.Text);

                foreach (RadioButton przycisk in this.gbGodzKoniec.Controls)
                    if (przycisk.Checked)
                        intGodzKoniec = int.Parse(przycisk.Text);

                foreach (RadioButton przycisk in this.gbMinKoniec.Controls)
                    if (przycisk.Checked)
                        intMinKoniec = int.Parse(przycisk.Text);


                //string podsumowanie = pilot + " " + sluzba + " " + godzStart + ":" + minStart + " - " + " godzKoniec" + ":" + "minKoniec";
                //MessageBox.Show(podsumowanie);

                ////////////////////////////////////////////////////////////////////
                // tutaj dodajemy rekord do bazy danych
                //
                //  po jednym razie dla kazdego zaznaczonego pilota bedacego na liscie 'listaZaznaczonychPilotow'

                if (listaZaznaczonychPilotow.Count < 1)
                    throw new ArgumentException("Nie wybrano żadnego pilota!");
                if (sluzba == null)
                    throw new ArgumentException("Nie wybrano żadnej służby!");
                //if (!GodzZGrafiku)
                //    if (intGodzStart < 0 || intMinStart < 0 || intGodzKoniec < 0 || intMinKoniec < 0)
                //        throw new ArgumentException("Nie wybrano pełnej godziny rozpoczęcia/zakończenia ćwiczenia");

                foreach (string str in listaZaznaczonychPilotow)
                {
                    //tu zapisuje tylko jedno cwiczenie o czasie trwania podanym  w 4 groupboxach z godzinami i minutami
                    if (!GodzZGrafiku)
                    {
                        //MessageBox.Show("zapisze pojedynczy czas cwiczenia");

                        poczatek = new DateTime(data.Year, data.Month, data.Day, intGodzStart, intMinStart, 0);
                        koniec = new DateTime(data.Year, data.Month, data.Day, intGodzKoniec, intMinKoniec, 0);

                        int porownanie = DateTime.Compare(poczatek, koniec);
                        if (porownanie >= 0)
                            throw new ArgumentException("Niepoprawna godzina rozpoczęcia/zakończenia ćwiczenia!");
                       
                        //sprawdzenie poprawnosci godziny
                        

                        SqlCommand cmd = new SqlCommand("INSERT INTO CzasPracy (Pilot, Sluzba, Instruktor, GodzStart, GodzKoniec, Info) VALUES (@Pilot, @Sluzba, @Instruktor, @GodzStart, @GodzKoniec, @Info)");
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@Pilot", str);
                        cmd.Parameters.AddWithValue("@Sluzba", sluzba);
                        cmd.Parameters.AddWithValue("@Instruktor", instruktor);
                        cmd.Parameters.AddWithValue("@GodzStart", poczatek.ToString());
                        cmd.Parameters.AddWithValue("@GodzKoniec", koniec.ToString());
                        cmd.Parameters.AddWithValue("@Info", txtInfo.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    else      // tu procedura zapisu do bazy danych z grafikowych czasow
                    {
                        //tu zapisuje godzine cwiczenia jesli uzytkownik wybral godziny z groupboxa z grafikiem
                        //MessageBox.Show("zapisze grafikowe czasy cwiczen");

                        List<DateTime> rozpoczecieZGrafiku = wyciagnijPoczatki(gbGrafik, data);
                        List<DateTime> zakonczenieZGrafiku = wyciagnijKonce(gbGrafik, data);


                        for (int i = 0; i < rozpoczecieZGrafiku.Count; i++)
                        {
                            

                                SqlCommand cmd = new SqlCommand("INSERT INTO CzasPracy (Pilot, Sluzba, Instruktor, GodzStart, GodzKoniec, Info) VALUES (@Pilot, @Sluzba, @Instruktor, @GodzStart, @GodzKoniec, @Info)");
                                cmd.CommandType = CommandType.Text;
                                cmd.Connection = conn;
                                cmd.Parameters.AddWithValue("@Pilot", str);
                                cmd.Parameters.AddWithValue("@Sluzba", sluzba);
                                cmd.Parameters.AddWithValue("@Instruktor", instruktor);
                                cmd.Parameters.AddWithValue("@GodzStart", rozpoczecieZGrafiku[i].ToString());
                                cmd.Parameters.AddWithValue("@GodzKoniec", zakonczenieZGrafiku[i].ToString());
                                cmd.Parameters.AddWithValue("@Info", txtInfo.Text);

                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                        }

                        
                    }
                }

                //odznaczam wszystkie przyciski
                btnAnuluj_Click(null, null);
                //ustawiam date na dzisiejsza
                data = DateTime.Now;
                lblData.Text = dataDoString(data);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            finally
            {
                //odznaczam wszystkie przyciski
                //btnAnuluj_Click(null, null);
                //txtInfo.Text = "";
                //gbInstruktorzy.Controls.Clear();

                //foreach (Control groupBox in tabControl1.TabPages[0].Controls)
                //    if (groupBox is GroupBox)
                //    {
                //        foreach (Control radio in groupBox.Controls)
                //        {
                //            if (radio is RadioButton)
                //            {
                //                RadioButton _radio = radio as RadioButton;
                //                _radio.Checked = false;
                //            }

                //        }

                //        foreach (Control checkBox in groupBox.Controls)
                //        {
                //            if (checkBox is CheckBox)
                //            {
                //                CheckBox _chb = checkBox as CheckBox;
                //                _chb.Checked = false;
                //            }

                //        }
                //    }
                
            }

        }

        private List<DateTime> wyciagnijKonce(GroupBox gbGrafik, DateTime data)
        {
            List<DateTime> lista = new List<DateTime>();

            foreach (CheckBox cb in gbGrafik.Controls)
            {
                if (cb.Checked)
                {
                    string godz = (cb.Text).Substring(8, 2);
                    string min = (cb.Text).Substring(11, 2);
                    DateTime koniec = new DateTime(data.Year, data.Month, data.Day, int.Parse(godz), int.Parse(min), 0);
                    lista.Add(koniec);
                }
            }
            return lista;
        }

        private List<DateTime> wyciagnijPoczatki(GroupBox gbGrafik, DateTime data)
        {
            List<DateTime> lista = new List<DateTime>();

            foreach (CheckBox cb in gbGrafik.Controls)
            {
                if (cb.Checked)
                {
                    string godz = (cb.Text).Substring(0,2);
                    string min = (cb.Text).Substring(3,2);
                    DateTime pocz = new DateTime(data.Year, data.Month, data.Day, int.Parse(godz), int.Parse(min), 0);
                    lista.Add(pocz);
                }
            }
            return lista;
        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void edytujPilotówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHaslo frmHaslo1 = new frmHaslo("frmPiloci");
            frmHaslo1.ShowDialog();

            //frmPiloci frmPiloci1 = new frmPiloci();
            //frmPiloci1.ShowDialog();
            // po zamknieciu przepisuje przyciski pilotow na wypadek ajk by byla zmiana

            gbPiloci.Controls.Clear();

            dodajRadBtnPilot(conn);
            btnAnuluj_Click(null, null);
        }

        private void służbyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHaslo frmHaslo1 = new frmHaslo("frmSluzby");
            frmHaslo1.ShowDialog();

            gbSluzba.Controls.Clear();
            dodajRadBtnSluzb(conn);

            //odznaczam wszystko
            btnAnuluj_Click(null, null);
        }

        private void podsumowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPodsumowanie frmPodsumowanie1 = new frmPodsumowanie();
            frmPodsumowanie1.ShowDialog();
        }

        private void instruktorzyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHaslo frmHaslo1 = new frmHaslo("frmInstruktorzy");
            frmHaslo1.ShowDialog();

            //odznaczam wszystko
            btnAnuluj_Click(null, null);
        }



        /////////////////////////////////////////////////////////////////////////////////////
        //
        //   tu sa moje metodki rozne

        private void dodajRadBtnSluzb(SqlConnection conn)
        {
            //to male zasrane i decyduje czy tworzymy dla sluzb czy pilotow

            SqlDataReader sqlRdr = null;
            SqlCommand cmd = new SqlCommand("SELECT Sluzba, Aktywna FROM Sluzby", conn);
            List<string> listaSluzb = new List<string>();

            conn.Open();
            sqlRdr = cmd.ExecuteReader();
            

            while (sqlRdr.Read())
            {
                if ((bool)sqlRdr["Aktywna"])
                    listaSluzb.Add(sqlRdr["Sluzba"].ToString());

            }
            conn.Close();

            

            for (int i = 0; i<listaSluzb.Count; i++)
            {
                RadioButton rb = new RadioButton();
                rb.Text = listaSluzb[i].ToString();
                rb.Appearance = Appearance.Button;
                rb.Height = 30;
                rb.Width = 100;
                rb.TextAlign = ContentAlignment.MiddleCenter;
                rb.Click += new EventHandler(wyborSluzby);
                rb.CheckedChanged += new EventHandler(pokolorujKliknietyRadio);
                gbSluzba.Controls.Add(rb);
                rb.Location = new Point(10, 20 + (i * 36));
            }
        }

        private void pokolorujKliknietyRadio(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                rb.BackColor = Color.Lime;
                rb.Font = new Font(rb.Font.Name, rb.Font.Size, FontStyle.Bold);
            }
            else
            {
                rb.BackColor = Color.Transparent;
                rb.Font = new Font(rb.Font.Name, rb.Font.Size, FontStyle.Regular);

            }
        }

        private void pokolorujKliknietyCheckBox(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (cb.Checked)
            {
                cb.BackColor = Color.Lime;
                cb.Font = new Font(cb.Font.Name, cb.Font.Size, FontStyle.Bold);
            }
            else
            {
                cb.BackColor = Color.Transparent;
                cb.Font = new Font(cb.Font.Name, cb.Font.Size, FontStyle.Regular);
            }
        }

        private void dodajRadBtnPilot(SqlConnection conn)
        {
            //to male zasrane i decyduje czy tworzymy dla sluzb czy pilotow

            SqlDataReader sqlRdr = null;
            SqlCommand cmd = new SqlCommand("SELECT Pilot, Aktywny FROM Piloci", conn);

            
            
            List<string> listaPilotow = new List<string>();

            conn.Open();
            sqlRdr = cmd.ExecuteReader();


            while (sqlRdr.Read())
            {
                if ((bool)sqlRdr["Aktywny"])
                    listaPilotow.Add(sqlRdr["Pilot"].ToString());

            }
            conn.Close();

            int x = 10;
            int y = 20;

            for (int i = 0; i < listaPilotow.Count; i++)
            {
                CheckBox cb = new CheckBox();
                cb.Text = listaPilotow[i].ToString();
                cb.Appearance = Appearance.Button;
                cb.Height = 30;
                cb.Width = 100;
                cb.TextAlign = ContentAlignment.MiddleCenter;
                cb.CheckedChanged += new EventHandler(pokolorujKliknietyCheckBox);
                gbPiloci.Controls.Add(cb);

                cb.Location = new Point(x, y);

                y = y + 35;

                if (i == 13)
                {
                    x += 105;
                    y = 20;
                }
                if (i == 27)
                {
                    x += 105;
                    y = 20;
                }
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            //odznaczam wszystkie kontrolki, czyszcze pola

            txtInfo.Text = "";

            GodzZGrafiku = false;

            gbInstruktorzy.Controls.Clear();
            gbGrafik.Controls.Clear();

            gbGodzKoniec.Enabled = true;
            gbMinKoniec.Enabled = true;
            gbGodzStart.Enabled = true;
            gbMinStart.Enabled = true;


            foreach (Control groupBox in tabControl1.TabPages[0].Controls)
                if (groupBox is GroupBox)
                {
                    foreach (Control radio in groupBox.Controls)
                    {
                        if (radio is RadioButton)
                        {
                            RadioButton _radio = radio as RadioButton;
                            _radio.Checked = false;
                        }

                    }

                    foreach (Control checkBox in groupBox.Controls)
                    {
                        if (checkBox is CheckBox)
                        {
                            CheckBox _chb = checkBox as CheckBox;
                            _chb.Checked = false;
                        }

                    }
                }
        }

        private void wyborSluzby(object sender, EventArgs e)
        {

            gbInstruktorzy.Controls.Clear();            

            List<string> instruktorzy = new List<string>();

            //wczytuje z bazy danych instruktorow dla danej sluzby
            SqlDataReader sqlRdr = null;
            SqlCommand cmd = new SqlCommand("SELECT Instruktor, Aktywny FROM Instruktorzy WHERE Typ = '" + ((RadioButton)sender).Text + "'", conn);
            
            conn.Open();
            
            sqlRdr = cmd.ExecuteReader();


            while (sqlRdr.Read())
            {
                if ((bool)sqlRdr["Aktywny"])
                    instruktorzy.Add(sqlRdr["Instruktor"].ToString());

            }
            conn.Close();

            //ostatecznie dodaje przyciski instruktorow na podstawie listy

            for (int i = 0; i < instruktorzy.Count; i++)
            {
                RadioButton rb = new RadioButton();
                rb.Text = instruktorzy[i].ToString();
                rb.Appearance = Appearance.Button;
                rb.Height = 30;
                rb.Width = 100;
                rb.TextAlign = ContentAlignment.MiddleCenter;
                rb.CheckedChanged += new EventHandler(pokolorujKliknietyRadio);
                gbInstruktorzy.Controls.Add(rb);
                rb.Location = new Point(10, 20 + (i * 35));
            }

            //i ostatecznie jezeli wybrano ACC, APP, TWR to dodaje mozliwosc wyboru godzin z grafiku

            string sluzba = ((RadioButton)sender).Text;

            switch (sluzba)
            {
                case "ACC":
                    wypiszGrafik(sluzba);
                    break;
                case "APP":
                    wypiszGrafik(sluzba);
                    break;
                case "TWR":
                    wypiszGrafik(sluzba);
                    break;
                default:
                    gbGrafik.Controls.Clear();
                    break;

            }


        }

        private void wypiszGrafik(string sluzba)
        {
            gbGrafik.Controls.Clear();
            SqlDataReader sqlRdr = null;
            List<string> grafik = new List<string>();

            SqlCommand cmd = new SqlCommand("SELECT Czas FROM " + sluzba + "grafik", conn);

            conn.Open();

            sqlRdr = cmd.ExecuteReader();


            while (sqlRdr.Read())
            {
                grafik.Add(sqlRdr[0].ToString());

            }
            conn.Close();

            for (int i = 0; i < grafik.Count; i++)
            {
                CheckBox cb = new CheckBox();
                cb.Text = grafik[i].ToString();
                cb.Appearance = Appearance.Button;
                cb.Height = 30;
                cb.Width = 150;
                cb.TextAlign = ContentAlignment.MiddleCenter;
                cb.CheckedChanged += new EventHandler(pokolorujKliknietyCheckBox);
                cb.CheckedChanged += new EventHandler(zablokujWyborGodziny);
                gbGrafik.Controls.Add(cb);
                cb.Location = new Point(10, 20 + (i * 35));
            }

            
        }

        private void zablokujWyborGodziny(object sender, EventArgs e)
        {
            bool czyzaznaczony = false;

            foreach (CheckBox cb in gbGrafik.Controls)
                if (cb.Checked)
                    czyzaznaczony = true;

            if (czyzaznaczony)
            {
                gbGodzKoniec.Enabled = false;
                gbMinKoniec.Enabled = false;
                gbGodzStart.Enabled = false;
                gbMinStart.Enabled = false;

                foreach (RadioButton rb in gbGodzKoniec.Controls)
                    rb.Checked = false;
                foreach (RadioButton rb in gbGodzStart.Controls)
                    rb.Checked = false;
                foreach (RadioButton rb in gbMinKoniec.Controls)
                    rb.Checked = false;
                foreach (RadioButton rb in gbMinStart.Controls)
                    rb.Checked = false;

                GodzZGrafiku = true;
                        
            }
            else
            {
                gbGodzKoniec.Enabled = true;
                gbMinKoniec.Enabled = true;
                gbGodzStart.Enabled = true;
                gbMinStart.Enabled = true;

                GodzZGrafiku = false;
            }

        }



        //przyciski do wskazania godziny/minuty startu/konca cwiczenia sa tu przypiete
        //pod event kolorujacy przyciski na zielono
        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            pokolorujKliknietyRadio(sender, e);
        }

        private void aCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHaslo frmHaslo1 = new frmHaslo("frmGrafikACC");
            frmHaslo1.ShowDialog();
            //na wszelki wypadek kasuje wszystko z formularza
            btnAnuluj_Click(null, null);
        }

        private void aPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHaslo frmHaslo1 = new frmHaslo("frmGrafikAPP");
            frmHaslo1.ShowDialog();
            //na wszelki wypadek kasuje wszystko z formularza
            btnAnuluj_Click(null, null);
        }

        private void tWRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHaslo frmHaslo1 = new frmHaslo("frmGrafikTWR");
            frmHaslo1.ShowDialog();
            //na wszelki wypadek kasuje wszystko z formularza
            btnAnuluj_Click(null, null);
        }

        private void chbPopoludnie_Click(object sender, EventArgs e)
        {
            if (chbPopoludnie.Checked)
            {
                radioButton12.Text = "14";
                radioButton11.Text = "15";
                radioButton10.Text = "16";
                radioButton9.Text = "17";
                radioButton13.Text = "18";
                radioButton14.Text = "19";
                radioButton15.Text = "20";
                radioButton16.Text = "21";
                radioButton70.Text = "22";

                radioButton36.Text = "14";
                radioButton35.Text = "15";
                radioButton34.Text = "16";
                radioButton33.Text = "17";
                radioButton32.Text = "18";
                radioButton31.Text = "19";
                radioButton30.Text = "20";
                radioButton29.Text = "21";
                radioButton71.Text = "22";
            }
            else
            {
                radioButton12.Text = "6";
                radioButton11.Text = "7";
                radioButton10.Text = "8";
                radioButton9.Text = "9";
                radioButton13.Text = "10";
                radioButton14.Text = "11";
                radioButton15.Text = "12";
                radioButton16.Text = "13";
                radioButton70.Text = "14";

                radioButton36.Text = "6";
                radioButton35.Text = "7";
                radioButton34.Text = "8";
                radioButton33.Text = "9";
                radioButton32.Text = "10";
                radioButton31.Text = "11";
                radioButton30.Text = "12";
                radioButton29.Text = "13";
                radioButton71.Text = "14";
            }
        }

        private void btnDataMinus_Click(object sender, EventArgs e)
        { 
            DateTime nowa = data.AddDays(-1);
            lblData.Text = dataDoString(nowa);
            data = nowa;
        }

        private void btnDataPlus_Click(object sender, EventArgs e)
        {
            DateTime nowa = data.AddDays(1);

            //zabezpieczenie zeby nie mozna bylo ustawic przyszlej daty, max to obecna
            if (nowa <= DateTime.Now)
            {
                lblData.Text = dataDoString(nowa);
                data = nowa;
            }
            else
            {
                lblData.Text = dataDoString(data);
            }
        }

        private void btnDzis_Click(object sender, EventArgs e)
        {
            DateTime nowa = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            lblData.Text = dataDoString(nowa);
            data = nowa;
        }

        private string dataDoString(DateTime data)
        {

            var pl = new System.Globalization.CultureInfo("pl-PL");

            string dzien = pl.DateTimeFormat.GetDayName(data.DayOfWeek);
            
            return data.ToString("D") + " (" + dzien + ")";
        }

        private void lblData_SizeChanged(object sender, EventArgs e)
        {
            Point pt = new Point(lblData.Location.X + lblData.Size.Width + 10, lblData.Location.Y);
            btnDzis.Location = pt;
        }

        private bool czySieNaklada(string pilot, DateTime dataStart1, DateTime dataKoniec1, SqlConnection conn)
        {

            //tak wykryje nakladajace sie godziny:
            //http://stackoverflow.com/questions/13513932/algorithm-to-detect-overlapping-periods
            //https://social.msdn.microsoft.com/Forums/vstudio/en-US/667b2367-59a4-44e4-806b-4f1e8f14e6ac/how-do-i-compare-two-timespan-objects-to-see-if-they-overlap?forum=csharpgeneral

            SqlDataReader sqlRdr = null;


            //http://weblogs.sqlteam.com/jeffs/archive/2006/07/21/10728.aspx
            SqlCommand cmd = new SqlCommand("SELECT * " +
                                            "FROM CzasPracy " +
                                            "WHERE Pilot LIKE 'Moryc%' AND " +
                                            "GodzStart BETWEEN '2015-06-05 00:00:00' AND '2015-06-05 23:59:59'" , conn);

            conn.Open();
            sqlRdr = cmd.ExecuteReader();
            
            // tak wybrac konkretny dzien:
            //http://stackoverflow.com/questions/14104304/mysql-select-where-datetime-matches-day-and-not-necessarily-time

            while (sqlRdr.Read())
            {
            //    if ((bool)sqlRdr["Aktywny"])
            //        listaPilotow.Add(sqlRdr["Pilot"].ToString());


            }
            conn.Close();




            return true;
        }
        
    }
}
