using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverkefni
{
    public class TopTrumps
    {
        //private string nafn;
        /*
        private string fadir;
        private string modir;
        */

        public string Nafn{ get; private set; }
        
        public string Fadir{get;private set;}


        public string Modir { get; private set; }
        
        

        public TopTrumps(string nafn,string fadir, string modir)
        {
            Nafn = nafn;
            Fadir = fadir;
            Modir = modir;
           
        }

        public override string ToString()
        {
            return string.Format("Nafn: {0}\nFadir: {1}\nModir: {2}\n", Nafn,Fadir, Modir);
        }
    }
}












































































































































// wtf you doing down here
