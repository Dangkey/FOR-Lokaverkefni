using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverkefni
{
    public class TopTrumps
    {
        private string nafn;
        private string fadir;
        private string modir;
        private int afkvaemi;


        public string Nafn
        {
            get
            {
                return nafn;
            }
        }
        public string Fadir
        {
            get
            {
                return fadir;
            }
        }

        public string Modir
        {
            get
            {
                return modir;
            }
        }
        public int Afkvaemi
        {
            get
            {
                return afkvaemi;
            }
        }
        

        public TopTrumps(string Nafn,string Fadir, string Modir,int Afkvaemi)
        {
            nafn = Nafn;
            fadir = Fadir;
            modir = Modir;
            afkvaemi = Afkvaemi;            
           
        }

        public override string ToString()
        {
            return string.Format("Nafn: {0}, Fadir: {1}, Modir: {2}, Afkvaemi: {3}", Nafn,Fadir, Modir,Afkvaemi);
        }
    }
}












































































































































// wtf you doing down here
