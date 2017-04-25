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

            
            Hrutaspilid hrutaspilid = new Hrutaspilid("Elas", 100 , 13,5,"3",4,5,3,2,"Hilmar","Api");
            Hrutaspilid hrutaspilid1 = new Hrutaspilid("Aron", 100, 13, 5, "3", 4, 5, 3, 2, "Hilmar", "Api");
            Hrutaspilid hrutaspilid2 = new Hrutaspilid("Eyho", 100, 13, 5, "3", 4, 5, 3, 2, "Hilmar", "Api");
            Hrutaspilid hrutaspilid3 = new Hrutaspilid("Bobbi", 100, 13, 5, "3", 4, 5, 3, 2, "Hilmar", "Api");
            
            
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
            /*
            foreach (TopTrumps it in toptrump)
            {
                Console.WriteLine(it[] + "\n");
                Console.WriteLine("VS\n");
                Console.WriteLine(it[1] + "\n");
                Console.ReadKey();
                Console.Clear();
            }*/
            Console.ReadKey();
        }
    }
}
