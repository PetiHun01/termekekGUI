using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace termekekGUI
{
    internal class Termek
    {
        string termekNev;
        int afaKulcs;
        double nettoAr;

        public string TermekNev
        {
            get { return termekNev; }
            set { termekNev = value; }
        }
        public int AfaKulcs
        {
            get { return afaKulcs; }
            set { afaKulcs = value; }
        }
        public double NettoAr
        {
            get { return nettoAr; }
            set { nettoAr = value; }
        }
        public Termek(string termekNev, int afaKulcs, double nettoAr)
        {
            this.termekNev = termekNev;
            this.afaKulcs = afaKulcs;
            this.nettoAr = nettoAr;
        }
        public double afatartalomszamitas()
        {
            return Math.Round(nettoAr * (afaKulcs / 100.0), 2);
        }
        public double BruttoAr()
        {
            return Math.Round(nettoAr * ((afaKulcs + 100) / 100), 2);
        }
    }
}
