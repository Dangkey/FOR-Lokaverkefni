using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverkefni
{
    public class TopTrumps
    {
        private string þyngd;
        private string mjolkurlagni;
        private string ull;
        private string afkvæmi;
        private string læri;
        private string frjosemi;
        private string gerðbak;
        private string malir;

        public string Þyngd
        {
            get
            {
                return þyngd;
            }
        }

        public string Mjolkurlagni
        {
            get
            {
                return mjolkurlagni;
            }
        }
        public string Ull
        {
            get
            {
                return ull;
            }
        }

        public string Afkvæmi
        {
            get
            {
                return afkvæmi;
            }
        }
        public string Læri
        {
            get
            {
                return læri;
            }
        }

        public string Frjosemi
        {
            get
            {
                return frjosemi;
            }
        }
        public string GerðBak
        {
            get
            {
                return gerðbak;
            }
        }
        public string Malir
        {
            get
            {
                return malir;
            }
        }

        public TopTrumps(string Þyngd, string Mjolkurlagni ,string Ull, string Afkvæmi, string Læri, string Frjosemi,string GerðBak,string Malir)
        {

            þyngd = Þyngd;
            mjolkurlagni = Mjolkurlagni;
            ull = Ull;
            afkvæmi = Afkvæmi;
            frjosemi = Frjosemi;
            gerðbak = GerðBak;
            malir = Malir;
        }

        public override string ToString()
        {
            return string.Format("Þyngd: {0}, Mjolkurlagni: {1}, Ull: {2}, Afkvæmi: {3}, Læri: {4}, Frjosemi: {5}, Gerðbak: {6}, Malir: {7}", Þyngd, Mjolkurlagni, Ull, Afkvæmi, Læri, Frjosemi,GerðBak,Malir);
        }
    }
}












































































































































// wtf you doing down here
