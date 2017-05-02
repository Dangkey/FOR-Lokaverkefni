using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverkefni
{
    class Stodhestaspilid : TopTrumps
    {
        public string Fodurfadir { get; private set; }
        public string Fodurmodir { get; private set; }
        public string Modurfadir { get; private set; }
        public string Modurmodir { get; private set; }
        public int Faedinganumer { get; private set; }
        public string litaskyring { get; private set; }
        public int litanumer { get; private set; }
        public string Domur { get; private set; }
        public string Bygging { get; private set; }
        public int Frjosemi { get; private set; }
        public int Bakvodvi { get; private set; }
        public double Malir { get; private set; }

        public Stodhestaspilid(string nafn, string fadir, string modir, double þyngd,int mjolkurlagni,double ull,int afkvaemi,double laeri,int frjosemi, int bakvodvi, double malir)
            : base(nafn,fadir,modir)
        {
            Þyngd = þyngd;
            Mjolkurlagni = mjolkurlagni;
            Ull = ull;
            Afkvaemi = afkvaemi;
            Laeri = laeri;
            Frjosemi = frjosemi;
            Bakvodvi = bakvodvi;
            Malir = malir;
            //nafn = Nafn
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("Þyngd: {0},\nMjolkurlagni: {1},\nUll: {2},\nLæri: {3},\nFrjósemi: {4},\nBakvöðvi: {5},\nMalir: {6},\nAfkvæmi: {7}\n", Þyngd,Mjolkurlagni, Ull,  Laeri, Frjosemi, Bakvodvi, Malir, Afkvaemi);
        }
    }
}
