using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverkefni
{
    public class Hrutaspilid : TopTrumps
    {
        private string nafn;
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

        public double Þyngd { get; set; }
        public int Mjolkurlagni { get; set; }
        public double Ull { get; set; }
        public string Afkvaemi { get; set; }
        public double Laeri { get; set; }
        public int Frjosemi { get; set; }
        public int Bakvodvi { get; set; }
        public double Malir { get; set; }

        public Hrutaspilid(string nafn,double þyngd,int mjolkurlagni,double ull,string afkvaemi,double laeri,int frjosemi, int bakvodvi, double malir,string fadir, string modir)
            : base(nafn,fadir,modir,afkvaemi)
        {
            þyngd = Þyngd;
            mjolkurlagni = Mjolkurlagni;
            ull = Ull;
            afkvæmi = Afkvaemi;
            laeri = Laeri;
            frjosemi = Frjosemi;
            bakvodvi = Bakvodvi;
            malir = Malir;
        }
        public override string ToString()
        {
            return string.Format("Nafn: {0},\nÞyngd: {1},\nMjolkurlagni: {2},\nUll: {3},\nAfkvæmi: {4},\nLæri: {5},\nFrjósemi: {6},\nBakvöðvi: {7},\nMalir: {8},\nFaðir: {9},\nMóðir: {10},\n", Nafn, Þyngd,Mjolkurlagni, Ull, Afkvaemi, Laeri, Frjosemi, Bakvodvi, Malir, Fadir, Modir);
        }

        

        

        
        

        
    }
}
