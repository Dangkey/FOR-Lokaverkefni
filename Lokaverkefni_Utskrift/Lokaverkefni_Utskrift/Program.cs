using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lokaverkefni;

namespace Lokaverkefni_Utskrift
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Hrutaspilid hrutaspilid = new Hrutaspilid("Elas","Hilmar","Api", 100 , 13,5,3,4,5,3,2);
            Hrutaspilid hrutaspilid1 = new Hrutaspilid("Aron", "Hilmar", "Api", 100, 13, 5, 3, 4, 5, 3, 2);
            Hrutaspilid hrutaspilid2 = new Hrutaspilid("Eyho", "Hilmar", "Api", 100, 13, 5, 3, 4, 5, 3, 2);
            Hrutaspilid hrutaspilid3 = new Hrutaspilid("Bobbi", "Hilmar", "Api", 100, 13, 5, 3, 4, 5, 3, 2);
            
            
            TopTrumps[] toptrump = new TopTrumps[4];
            
             toptrump[0] = hrutaspilid;
            toptrump[1] = hrutaspilid1;
            toptrump[2] = hrutaspilid2;
            toptrump[3] = hrutaspilid3;

            for (int i = 0; i < 4; i++)
			{
			    Console.WriteLine(toptrump[i] + "\n");
                Console.WriteLine("VS\n");
                Console.WriteLine(toptrump[i + 1] + "\n");
                Console.WriteLine("Ýttu á Enter til að draga næstu spil");
                Console.ReadKey();
                Console.Clear();
			}
            
            Console.ReadKey();
        }
    }
}
