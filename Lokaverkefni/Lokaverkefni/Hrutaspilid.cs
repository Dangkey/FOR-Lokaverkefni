using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverkefni
{
    public class Hrutaspilid : TopTrumps
    {
        /*private string nafn;
        private double þyngd;
        private int mjolkurlagni;
        private double ull;
        private string afkvæmi;
        private double laeri;
        private int frjosemi;
        private int bakvodvi;
        private double malir;
        private string fadir;
        private string modir;
         * */

        public double Þyngd { get; private set; }
        public int Mjolkurlagni { get; private set; }
        public double Ull { get; private set; }
        public int Afkvaemi { get; private set; }
        public double Laeri { get; private set; }
        public int Frjosemi { get; private set; }
        public int Bakvodvi { get; private set; }
        public double Malir { get; private set; }

        public Hrutaspilid(string nafn, string fadir, string modir, double þyngd,int mjolkurlagni,double ull,int afkvaemi,double laeri,int frjosemi, int bakvodvi, double malir)
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
