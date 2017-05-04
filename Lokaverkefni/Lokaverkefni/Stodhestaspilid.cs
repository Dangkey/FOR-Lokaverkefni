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
            return base.ToString() + string.Format("1. Litanumer: {0}\n2. Bygging Aðaleinkunn: {1}\n3. Hæfileikar Aðaleinkunn: {2}\n4. Aðaleinkunn: {3}\n5. Afkvæmi: {4}\n6. Stangarmál: {5}\n7. Kynbótamat: {6}", Litanumer,ByggingAdaleinkunn,HaefileikarAdaleinkunn, Adaleinkunn,Afkvaemi,Stangarmal,Kynbotamat);
        }
    }
}
