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

            
            Hrutaspilid hrutaspilid = new Hrutaspilid("Sokki","Kækur","Hvísl", 41, 108,7.0,0,17.3,108,144,8.5);
            Hrutaspilid hrutaspilid1 = new Hrutaspilid("Freyðir", "Flúðar", "03-290", 46.4, 105, 7.9, 135, 17.4, 103, 118, 8.6);
            Hrutaspilid hrutaspilid2 = new Hrutaspilid("Vöðvi", "Vöðvi", "Fura", 47, 100, 8.0, 0, 17.5, 106, 112, 9.0);
            Hrutaspilid hrutaspilid3 = new Hrutaspilid("Kjói", "Spói", "02-238", 48.8, 116, 8.4, 160, 17.0, 94, 111, 8.3);
            Hrutaspilid hrutaspilid4 = new Hrutaspilid("Bogi", "Erpur", "01-505", 49.9, 110, 8.3, 310, 17.3, 102, 116, 8.5);
            Hrutaspilid hrutaspilid5 = new Hrutaspilid("Falur", "Goði", "98-377", 48.3, 106, 8.2, 26, 16.9, 95, 114, 8.3);
            Hrutaspilid hrutaspilid6 = new Hrutaspilid("Borði", "Taumur", "05-071", 42, 110,8.0, 0, 18.0, 104, 0, 9.0);
            Hrutaspilid hrutaspilid7 = new Hrutaspilid("Bramli", "Lóði", "01-062", 47.5, 104, 7.8, 347, 17.2, 106, 102, 8.4);
            Hrutaspilid hrutaspilid8 = new Hrutaspilid("Kaldi","Hnöttur","Hæ-Þrenna", 47.8,100,7.9,218,17.1,135,93,8.4);
            Hrutaspilid hrutaspilid9 = new Hrutaspilid("Vorm","Melur", "Vordís",47.6,95,7.8,158,17.3,111,122,8.5);
            Hrutaspilid hrutaspilid10 = new Hrutaspilid("Smyrill", "Mosi", "Fela",47.8,101,7.9,97,17.2,95,114,8.4);
            Hrutaspilid hrutaspilid11 = new Hrutaspilid("Prjónn","Þráður","05-110",47.5,110,7.8,370,17.5,105,122,8.6);
            Hrutaspilid hrutaspilid12 = new Hrutaspilid("Grábotni", "Grímur", "Grábotna",45,102,7.5,0,17.5,106,139,8.5);
            Hrutaspilid hrutaspilid13 = new Hrutaspilid("Kóngur","Lóði","98-872",59,108,8.0,0,17.5,105,114,8.5);
            Hrutaspilid hrutaspilid14 = new Hrutaspilid("Garpur", "Dalur", "02-299",48.6,106,8.2,101,17.3,98,116,8.5);
            Hrutaspilid hrutaspilid15 = new Hrutaspilid("Broddi","Bogi","04-482", 57,92,7.5,0,18.0,99,144,9.5);
            Hrutaspilid hrutaspilid16 = new Hrutaspilid("Frakkson","Frakkur","Alda",49.6,110,8.4,325,17.2,106,117,8.4);
            Hrutaspilid hrutaspilid17 = new Hrutaspilid("Þróttur","Spakur","Féleg",48.0,106,7.8,222,17.4,105,121,8.5);
            Hrutaspilid hrutaspilid18 = new Hrutaspilid("Bifur","Brimill","02-157",45.5,96,7.7,407,17.5,110,115,8.7);
            Hrutaspilid hrutaspilid19 = new Hrutaspilid("Stáli","Tvistur","Edda",85,102,8.0,0,17.5,100,130,9.0);
            Hrutaspilid hrutaspilid20 = new Hrutaspilid("Fálki","Mímir","Sjöstjarna",51,103,7.5,0,17.5,102,142,9.0);
            Hrutaspilid hrutaspilid21 = new Hrutaspilid("Kjarkur","Kveikur","Mugga",48,108,7.5,0,17.0,108,0,8.5);
            Hrutaspilid hrutaspilid22 = new Hrutaspilid("Hólmi","Vaðall","02-118",45,104,7.5,0,18.0,95,0,9.0);
            Hrutaspilid hrutaspilid23 = new Hrutaspilid("Púki","Ári","03-341",49.0,111,7.7,403,17.3,114,119,8.5);
            Hrutaspilid hrutaspilid24 = new Hrutaspilid("Mjöður","Bjór","01-086",46.4,102,8.0,210,17.5,103,127,8.6);
            Hrutaspilid hrutaspilid25 = new Hrutaspilid("Mókollur","Kostur","Gusa",49.6,111,7.9,135,16.9,122,102,8.2);
            Hrutaspilid hrutaspilid26 = new Hrutaspilid("Gotti", "Gári", "03-301", 47.2,100, 9.0, 182, 17.5, 102, 119, 8.6);
            Hrutaspilid hrutaspilid27 = new Hrutaspilid("Hrói", "Kveikur", "02-307", 63, 107, 8.0, 0, 17.3, 108, 108, 8.5);
            Hrutaspilid hrutaspilid28 = new Hrutaspilid("Dökkvi", "Bifur", "04-390", 45.5, 102, 7.8, 157, 17.2, 105, 120, 8.5);
            Hrutaspilid hrutaspilid29 = new Hrutaspilid("Bolli", "Bolla", "Bolla", 51, 109, 9.0,0,17.5, 111, 109, 9.0);
            Hrutaspilid hrutaspilid30 = new Hrutaspilid("Týr", "Kútur", "Þilja", 38, 96, 8.0, 0, 17.5, 105, 131, 8.5);
            Hrutaspilid hrutaspilid31 = new Hrutaspilid("Papi", "Api", "Elma", 45.6, 82, 8.0, 428 ,17.6, 106, 140, 8.7);
            Hrutaspilid hrutaspilid32 = new Hrutaspilid("Tengill", "Lámur", "03-372", 45, 94, 8.0, 0, 17.5, 97, 145, 9.0);
            Hrutaspilid hrutaspilid33 = new Hrutaspilid("At", "Cat", "Heiður", 45.6, 110, 7.9, 244, 17.5, 110, 139, 8.5);
            Hrutaspilid hrutaspilid34 = new Hrutaspilid("Gráni", "Stapi", "Svala", 48.3, 111, 7.9, 381, 17.4, 105, 122, 8.6);
            Hrutaspilid hrutaspilid35 = new Hrutaspilid("Ylur", "Hylur", "00-061", 47.4, 11, 8.0, 184, 17.2, 96, 117, 8.4);
            Hrutaspilid hrutaspilid36 = new Hrutaspilid("Neisti", "Bogi", "04-629", 47, 106, 8.5, 0, 18.5, 104, 116, 9.0);
            Hrutaspilid hrutaspilid37 = new Hrutaspilid("Logi", "Þór", "Sóley", 53, 109, 8.5, 0, 18.0, 101, 114, 9.0);
            Hrutaspilid hrutaspilid38 = new Hrutaspilid("Kveikur", "Logi", "04-390", 49.0, 113, 7.8, 1085, 17.4, 106, 118, 8.6);
            Hrutaspilid hrutaspilid39 = new Hrutaspilid("Shrek", "Heydal", "01-129", 49.5, 117, 8.1, 82, 17.3, 103, 118, 8.5);
            Hrutaspilid hrutaspilid40 = new Hrutaspilid("Cat", "Týr", "00-025", 47.7, 98, 4.6, 193, 17.5, 100, 128, 8.6);
            Hrutaspilid hrutaspilid41 = new Hrutaspilid("Fanna", "Alki", "Rjúpa", 46.4, 105, 7.9, 222, 17.4, 101, 125, 8.6);
            Hrutaspilid hrutaspilid42 = new Hrutaspilid("Hvellur", "Hylur", "Glódís", 48.8, 112, 8.0, 552, 17.3, 96, 113, 8.6);
            Hrutaspilid hrutaspilid43 = new Hrutaspilid("Raftur", "Bramli", "03-290", 47.1, 106, 7.8, 1406, 17.6, 112, 122, 8.6);
            Hrutaspilid hrutaspilid44 = new Hrutaspilid("Blossi", "Bjarmi", "04-622", 54, 108, 8.5, 0, 18.0, 111, 113, 9.0);
            Hrutaspilid hrutaspilid45 = new Hrutaspilid("Blettur", "Sjúss", "Djásn", 44.9, 100, 7.9, 332, 17.2, 99, 109, 8.3);
            Hrutaspilid hrutaspilid46 = new Hrutaspilid("Mundi", "Lundi", "Dugga", 46, 104, 7.5, 0, 16.5, 110, 126, 8.5);
            Hrutaspilid hrutaspilid47 = new Hrutaspilid("Hriflon", "Raftur", "03-426", 49, 112, 8.0, 0, 18.0, 110, 124, 8.5);
            Hrutaspilid hrutaspilid48 = new Hrutaspilid("Skrauti", "Magni", "05-523", 45,111, 7.0, 0, 17.3, 98, 112, 9.5);
            Hrutaspilid hrutaspilid49 = new Hrutaspilid("Krókur", "Tumi", "Dröfn", 47.5, 101, 8.0, 218, 17.5, 97, 157, 8.7);
            Hrutaspilid hrutaspilid50 = new Hrutaspilid("Undri", "Kútur", "02-037",49.1, 108, 8.4, 76, 17.2, 100, 109, 8.4);
            Hrutaspilid hrutaspilid51 = new Hrutaspilid("Ás", "Snoddi", "01-120", 48.8, 121, 8.1, 82, 17.2, 108, 110, 8.3);
            
            
            
            TopTrumps[] toptrump = new TopTrumps[52];
             
            
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
