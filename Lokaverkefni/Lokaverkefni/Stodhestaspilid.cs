using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverkefni
{
    public class Stodhestaspilid : TopTrumps
    {
        public int Litanumer { get; private set; }        
        public double ByggingAdaleinkunn{ get; private set; }        
        public double HaefileikarAdaleinkunn { get; private set; }
        public double Adaleinkunn { get; private set; }
        public int Afkvaemi { get; private set; }
        public int Stangarmal { get; private set; }
        public int Kynbotamat { get; private set; }

        public Stodhestaspilid(string nafn, string fadir, string modir, int litanumer,double byggingAdaleinkunn,double haefileikarAdaleinkunn,double adaleinkunn,int afkvaemi, int stangarmal, int kynbotamat)
            : base(nafn,fadir,modir)
        {
            Litanumer = litanumer;            
            ByggingAdaleinkunn = byggingAdaleinkunn;            
            HaefileikarAdaleinkunn = haefileikarAdaleinkunn;
            Adaleinkunn = adaleinkunn;
            Afkvaemi = afkvaemi;
            Stangarmal   = stangarmal;
            Kynbotamat = kynbotamat;            
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("Litanumer: {0},\nBygging Aðaleinkunn: {1},\nHæfileikar Aðaleinkunn: {2},\nAðaleinkunn: {3},\nAfkvæmi: {4},\nStangarmál: {5},\nKynbótamat: {6}", Litanumer,ByggingAdaleinkunn,HaefileikarAdaleinkunn, Adaleinkunn,Afkvaemi,Stangarmal,Kynbotamat);
        }
    }
}
