using System.Collections;

namespace termekekGUI
{
    public partial class Form1 : Form
    {
        static List<Termek> termekek = new List<Termek>();
        public Form1()
        {
            InitializeComponent();
        }

        void Betoltes()
        {
            termekek.Clear();
            rtTermekek.Text = "";
            dgAdatok.Rows.Clear();
            using (FileStream fs = new FileStream("termekek.txt", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    sr.ReadLine();
                    try
                    {
                        while (!sr.EndOfStream)
                        {
                            string sor = sr.ReadLine() ?? "null;0;0";
                            string[] dbok = sor.Split(';');
                            string termekNev = dbok[0];
                            int afaKulcs = int.Parse(dbok[1]);
                            double nettoAr = double.Parse(dbok[2]);
                            Termek termek = new Termek(termekNev, afaKulcs, nettoAr);
                            termekek.Add(termek);
                            rtTermekek.Text += $"{termek.TermekNev}\n";
                            dgAdatok.Rows.Add(termek.TermekNev, termek.NettoAr, termek.AfaKulcs, termek.afatartalomszamitas(), termek.BruttoAr());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hiba a fájl beolvasásakor: " + ex.Message);
                    }
                }
            }
            //áfakulcsok szerinti darabszám
            Dictionary<int, int> afaDarabszam = new Dictionary<int, int>();
            afaDarabszam.Clear();
            foreach (Termek termek in termekek)
            {
                if (afaDarabszam.ContainsKey(termek.AfaKulcs))
                {
                    afaDarabszam[termek.AfaKulcs]++;
                }
                else
                {
                    afaDarabszam[termek.AfaKulcs] = 1;
                }
            }
            dgAfakulcsonkenti.Columns.Clear();
            dgAfakulcsonkenti.Columns.Add("Áfa kulcs", "Áfa kulcs");
            dgAfakulcsonkenti.Columns.Add("Darabszám", "Darabszám");
            dgAfakulcsonkenti.Rows.Clear();
            foreach (var afa in afaDarabszam)
            {
                dgAfakulcsonkenti.Rows.Add(afa.Key, afa.Value);
            }
            //afa kulcs szelektor
            cbAfaKulcs.Items.Clear();
            cbAfaKulcs.Items.Add("27");
            cbAfaKulcs.Items.Add("18");
            cbAfaKulcs.Items.Add("5");
            cbAfaKulcs.SelectedIndex = 0;
            cbAfaKulcs.DropDownStyle = ComboBoxStyle.DropDownList;
            //atlagos brutto ar
            double atlagosBruttoAr = 0;
            foreach (Termek termek in termekek)
            {
                atlagosBruttoAr += termek.BruttoAr();
            }
            atlagosBruttoAr /= termekek.Count;
            lbAtlagBruttoAr.Text = "Átlagos bruttó ár: " + Math.Round(atlagosBruttoAr, 2);
            //legdragabb termek
            int legdragabbIndex = 0;
            for (int i = 1; i < termekek.Count; i++)
            {
                if (termekek[i].BruttoAr() > termekek[legdragabbIndex].BruttoAr())
                {
                    legdragabbIndex = i;
                }
            }
            lbLegdragabbNetto.Text = "Legdrágább (nettó) árú termék: " + termekek[legdragabbIndex].TermekNev + " | ára: " + termekek[legdragabbIndex].BruttoAr();
        }
        void HozzaadasFrissitese()
        {
            if (tbNettoEgysegar.Text != "")
            {
                try
                {
                    double near = Convert.ToDouble(tbNettoEgysegar.Text);
                    double afakulcs = Convert.ToDouble(cbAfaKulcs.SelectedItem);
                    double afaszorzo = afakulcs / 100.0 + 1;
                    double bruttoar = Math.Round(near * afaszorzo, 2);
                    double afatartalom = Math.Round(bruttoar - near, 2);
                    lbAfatartalom.Text = "Áfa tartalom: " + afatartalom;
                    lbBruttoar.Text = "Bruttó ár: " + bruttoar;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A nettó árnak számnak kell lennie!" + ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNettoEgysegar.Text = "";
                    lbAfatartalom.Text = "Áfa tartalom: ";
                    lbBruttoar.Text = "Bruttó ár: ";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgAdatok.Columns.Add("Termék neve", "Termék neve");
            dgAdatok.Columns.Add("Nettó ár", "Nettó ár");
            dgAdatok.Columns.Add("Áfa kulcs", "Áfa kulcs");
            dgAdatok.Columns.Add("Áfa tartalom", "Áfa tartalom");
            dgAdatok.Columns.Add("Bruttó ár", "Bruttó ár");
            Betoltes();
        }

        private void dgAdatok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgAfakulcsonkenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgAdatok_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dgAdatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbTermekNeve.Text = termekek[e.RowIndex].TermekNev;
            lbTermekAra.Text = termekek[e.RowIndex].NettoAr.ToString();
        }

        private void tbNettoEgysegar_TextChanged(object sender, EventArgs e)
        {
            HozzaadasFrissitese();
        }

        private void cbAfaKulcs_SelectedIndexChanged(object sender, EventArgs e)
        {
            HozzaadasFrissitese();
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            if (tbTermekNeve.Text != "" && tbNettoEgysegar.Text != "")
            {
                using (FileStream fs = new FileStream("termekek.txt", FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        string termekNev = tbTermekNeve.Text;
                        int afaKulcs = Convert.ToInt32(cbAfaKulcs.SelectedItem);
                        double nettoAr = Convert.ToDouble(tbNettoEgysegar.Text);
                        Termek ujTermek = new Termek(termekNev, afaKulcs, nettoAr);
                        termekek.Add(ujTermek);
                        sw.Write($"\n{termekNev};{afaKulcs};{nettoAr}");
                        sw.Close();
                    }
                    fs.Close();
                }
                tbNettoEgysegar.Text = "";
                tbTermekNeve.Text = "";
                Betoltes();
            }
        }

        private void btnElvet_Click(object sender, EventArgs e)
        {
            //elvetés gomb
            DialogResult d = MessageBox.Show("Biztosan el akarod vetni a hozzáadást?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                tbTermekNeve.Text = "";
                tbNettoEgysegar.Text = "";
                lbAfatartalom.Text = "Áfa tartalom: ";
                lbBruttoar.Text = "Bruttó ár: ";
            } 
        }
    }
}
