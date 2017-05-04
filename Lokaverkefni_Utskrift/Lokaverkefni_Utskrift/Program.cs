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
            int teljarispil = 0;
            int val = 0;
            Random random = new Random();
           List<Hrutaspilid> Listi = new List<Hrutaspilid>();
           List<Stodhestaspilid> ListiStod = new List<Stodhestaspilid>();
           List<Hrutaspilid> Spilnot = new List<Hrutaspilid>();
            List<Hrutaspilid> Spiltolvu = new List<Hrutaspilid>();
            List<Hrutaspilid> TempHrut = new List<Hrutaspilid>();
            List<Hrutaspilid> Jafntefli = new List<Hrutaspilid>();

            List<Stodhestaspilid> Spilnot2 = new List<Stodhestaspilid>();
            List<Stodhestaspilid> Spiltolvu2 = new List<Stodhestaspilid>();
            List<Stodhestaspilid> TempStod = new List<Stodhestaspilid>();
            int stignot = 0;
            int stigtolva = 0;
            int val2 = 0;
            

         Listi.Add(new Hrutaspilid("Sokki","Kækur","Hvísl", 41, 108,7.0,0,17.3,108,144,8.5));
         Listi.Add(new Hrutaspilid("Freyðir", "Flúðar", "03-290", 46.4, 105, 7.9, 135, 17.4, 103, 118, 8.6));
         Listi.Add(new Hrutaspilid("Vöðvi", "Vöðvi", "Fura", 47, 100, 8.0, 0, 17.5, 106, 112, 9.0));
         Listi.Add(new Hrutaspilid("Kjói", "Spói", "02-238", 48.8, 116, 8.4, 160, 17.0, 94, 111, 8.3));
         Listi.Add(new Hrutaspilid("Bogi", "Erpur", "01-505", 49.9, 110, 8.3, 310, 17.3, 102, 116, 8.5));
         Listi.Add(new Hrutaspilid("Falur", "Goði", "98-377", 48.3, 106, 8.2, 26, 16.9, 95, 114, 8.3));
         Listi.Add(new Hrutaspilid("Borði", "Taumur", "05-071", 42, 110,8.0, 0, 18.0, 104, 0, 9.0));
         Listi.Add(new Hrutaspilid("Bramli", "Lóði", "01-062", 47.5, 104, 7.8, 347, 17.2, 106, 102, 8.4));
         Listi.Add(new Hrutaspilid("Kaldi","Hnöttur","Hæ-Þrenna", 47.8,100,7.9,218,17.1,135,93,8.4));
         Listi.Add(new Hrutaspilid("Vorm","Melur", "Vordís",47.6,95,7.8,158,17.3,111,122,8.5));
         Listi.Add(new Hrutaspilid("Smyrill", "Mosi", "Fela",47.8,101,7.9,97,17.2,95,114,8.4));
         Listi.Add(new Hrutaspilid("Prjónn","Þráður","05-110",47.5,110,7.8,370,17.5,105,122,8.6));
         Listi.Add(new Hrutaspilid("Grábotni", "Grímur", "Grábotna",45,102,7.5,0,17.5,106,139,8.5));
         Listi.Add(new Hrutaspilid("Kóngur","Lóði","98-872",59,108,8.0,0,17.5,105,114,8.5));
         Listi.Add(new Hrutaspilid("Garpur", "Dalur", "02-299",48.6,106,8.2,101,17.3,98,116,8.5));
         Listi.Add(new Hrutaspilid("Broddi","Bogi","04-482", 57,92,7.5,0,18.0,99,144,9.5));
         Listi.Add(new Hrutaspilid("Frakkson","Frakkur","Alda",49.6,110,8.4,325,17.2,106,117,8.4));
         Listi.Add(new Hrutaspilid("Þróttur","Spakur","Féleg",48.0,106,7.8,222,17.4,105,121,8.5));
         Listi.Add(new Hrutaspilid("Bifur","Brimill","02-157",45.5,96,7.7,407,17.5,110,115,8.7));
         Listi.Add(new Hrutaspilid("Stáli","Tvistur","Edda",85,102,8.0,0,17.5,100,130,9.0));
         Listi.Add(new Hrutaspilid("Fálki","Mímir","Sjöstjarna",51,103,7.5,0,17.5,102,142,9.0));
         Listi.Add(new Hrutaspilid("Kjarkur","Kveikur","Mugga",48,108,7.5,0,17.0,108,0,8.5));
         Listi.Add(new Hrutaspilid("Hólmi","Vaðall","02-118",45,104,7.5,0,18.0,95,0,9.0));
         Listi.Add(new Hrutaspilid("Púki","Ári","03-341",49.0,111,7.7,403,17.3,114,119,8.5));
         Listi.Add(new Hrutaspilid("Mjöður","Bjór","01-086",46.4,102,8.0,210,17.5,103,127,8.6));
         Listi.Add(new Hrutaspilid("Mókollur","Kostur","Gusa",49.6,111,7.9,135,16.9,122,102,8.2));
         Listi.Add(new Hrutaspilid("Gotti", "Gári", "03-301", 47.2,100, 9.0, 182, 17.5, 102, 119, 8.6));
         Listi.Add(new Hrutaspilid("Hrói", "Kveikur", "02-307", 63, 107, 8.0, 0, 17.3, 108, 108, 8.5));
         Listi.Add(new Hrutaspilid("Dökkvi", "Bifur", "04-390", 45.5, 102, 7.8, 157, 17.2, 105, 120, 8.5));
         Listi.Add(new Hrutaspilid("Bolli", "Bollur", "Bolla", 51, 109, 9.0,0,17.5, 111, 109, 9.0));
         Listi.Add(new Hrutaspilid("Týr", "Kútur", "Þilja", 38, 96, 8.0, 0, 17.5, 105, 131, 8.5));
         Listi.Add(new Hrutaspilid("Papi", "Api", "Elma", 45.6, 82, 8.0, 428 ,17.6, 106, 140, 8.7));
         Listi.Add(new Hrutaspilid("Tengill", "Lámur", "03-372", 45, 94, 8.0, 0, 17.5, 97, 145, 9.0));
         Listi.Add(new Hrutaspilid("At", "Cat", "Heiður", 45.6, 110, 7.9, 244, 17.5, 110, 139, 8.5));
         Listi.Add(new Hrutaspilid("Gráni", "Stapi", "Svala", 48.3, 111, 7.9, 381, 17.4, 105, 122, 8.6));
         Listi.Add(new Hrutaspilid("Ylur", "Hylur", "00-061", 47.4, 11, 8.0, 184, 17.2, 96, 117, 8.4));
         Listi.Add(new Hrutaspilid("Neisti", "Bogi", "04-629", 47, 106, 8.5, 0, 18.5, 104, 116, 9.0));
         Listi.Add(new Hrutaspilid("Logi", "Þór", "Sóley", 53, 109, 8.5, 0, 18.0, 101, 114, 9.0));
         Listi.Add(new Hrutaspilid("Kveikur", "Logi", "04-390", 49.0, 113, 7.8, 1085, 17.4, 106, 118, 8.6));
         Listi.Add(new Hrutaspilid("Shrek", "Heydal", "01-129", 49.5, 117, 8.1, 82, 17.3, 103, 118, 8.5));
         Listi.Add(new Hrutaspilid("Cat", "Týr", "00-025", 47.7, 98, 4.6, 193, 17.5, 100, 128, 8.6));
         Listi.Add(new Hrutaspilid("Fanna", "Alki", "Rjúpa", 46.4, 105, 7.9, 222, 17.4, 101, 125, 8.6));
         Listi.Add(new Hrutaspilid("Hvellur", "Hylur", "Glódís", 48.8, 112, 8.0, 552, 17.3, 96, 113, 8.6));
         Listi.Add(new Hrutaspilid("Raftur", "Bramli", "03-290", 47.1, 106, 7.8, 1406, 17.6, 112, 122, 8.6));
         Listi.Add(new Hrutaspilid("Blossi", "Bjarmi", "04-622", 54, 108, 8.5, 0, 18.0, 111, 113, 9.0));
         Listi.Add(new Hrutaspilid("Blettur", "Sjúss", "Djásn", 44.9, 100, 7.9, 332, 17.2, 99, 109, 8.3));
         Listi.Add(new Hrutaspilid("Mundi", "Lundi", "Dugga", 46, 104, 7.5, 0, 16.5, 110, 126, 8.5));
         Listi.Add(new Hrutaspilid("Hriflon", "Raftur", "03-426", 49, 112, 8.0, 0, 18.0, 110, 124, 8.5));
         Listi.Add(new Hrutaspilid("Skrauti", "Magni", "05-523", 45,111, 7.0, 0, 17.3, 98, 112, 9.5));
         Listi.Add(new Hrutaspilid("Krókur", "Tumi", "Dröfn", 47.5, 101, 8.0, 218, 17.5, 97, 157, 8.7));
         Listi.Add(new Hrutaspilid("Undri", "Kútur", "02-037",49.1, 108, 8.4, 76, 17.2, 100, 109, 8.4));
         Listi.Add(new Hrutaspilid("Ás", "Snoddi", "01-120", 48.8, 121, 8.1, 82, 17.2, 108, 110, 8.3));
            //Stodhestaspilid



        
         ListiStod.Add(new Stodhestaspilid("Þristur frá Feti", "Orri frá Þúfu", "Skák frá Feti", 2510, 8.14, 8.35, 8.27, 275, 141, 117));
         ListiStod.Add(new Stodhestaspilid("Þokki frá Kýrholti","Sólon frá Hóli","Þörf frá Hólum",2200,8.28,9.04,8.73,175,143,123));
         ListiStod.Add(new Stodhestaspilid("Sveinn-Hervar frá Þúfu","Orri frá Þúfu","Rák frá Þúfu",2500,8.06,8.38,8.25,291,139,119));
         ListiStod.Add(new Stodhestaspilid("Andvari frá Ey 1", "Orri frá Þúfu", "Leira frá Ey 1",1600,8.33,8.40,8.36,500,136,120));
         ListiStod.Add(new Stodhestaspilid("Borði frá Fellskoti","Hugi frá Hafsteinsstöðum","Sokkadís frá Bergstöðum",1510,7.89,8.48,8.24,83,141,119));
         ListiStod.Add(new Stodhestaspilid("Rökkvi frá Hárlaugsstöðum", "Otur frá Sauðárkróki","Snegla frá Hala",2500,8.13,8.48,8.34,261,141,109));
         ListiStod.Add(new Stodhestaspilid("Kraftur frá Efri-Þverá","Kolfinnur frá Kjarnholtum 1","Drótt frá Kópavogi",3400,8.20,8.48,8.37,24,143,115));
         ListiStod.Add(new Stodhestaspilid("Oddur frá Selfossi","Kjarval frá Sauðárkróki","Leira frá Þingdal",4521,8.10,8.86,8.48,391,136,118));
         ListiStod.Add(new Stodhestaspilid("Fursti frá Stóra-Hofi","Óður frá Brún", "Hnota frá Stóra-Hofi",3500,8.09,8.78,8.51,36,143,121));
         ListiStod.Add(new Stodhestaspilid("Glymur frá Innri-Skeljabrekku","Gaukur frá Innri-Skeljabrekku","Þyrla frá Norðtungu",8600,7.98,8.65,8.38,87,142,115));
         ListiStod.Add(new Stodhestaspilid("Klettur frá Hvammi","Gustur frá Hóli", "Dóttla frá Hvammi", 0210,8.43,8.54,8.49,211,140,121));
         ListiStod.Add(new Stodhestaspilid("Aðall frá Nýjabæ","Adam frá Meðalfelli","Furða frá Nýjabæ",3500,8.13,8.97,8.64,82,143,118));
         ListiStod.Add(new Stodhestaspilid("Gígjar frá Auðsholtshjáleigu","Orri frá Þúfu","Hrafntinna frá Auðsholtash.",2520,7.98,8.78,8.46,168,136,123));
         ListiStod.Add(new Stodhestaspilid("Hruni frá Breiðumörk 2", "Hrannar frá Höskuldsstöðum", "Hetta frá Breiðumörk 2",7510,7.61,8.41,8.09,34,133,108));
         ListiStod.Add(new Stodhestaspilid("Kjarkur frá Egilsstaðabæ","Otur frá Sauðárkróki", "Hrefna frá Mýnesi", 2700,7.85,8.71,8.28,354,133,106));
         ListiStod.Add(new Stodhestaspilid("Hróður frá Refsstöðum","Léttir frá Stóra-Ási", "Rán frá Refsstöðum", 1590,7.94,8.69,8.39,344,135,125));
         ListiStod.Add(new Stodhestaspilid("Illingur frá Tóftum", "Númi frá Þóroddsstöðum","Hrísla frá Laugarvatni",1510,8.45,8.81,8.67,195,137,124));
         ListiStod.Add(new Stodhestaspilid("Sigur frá Hólabaki","Parker frá Sólheimum", "Sigurdís frá Hólabaki",1620,8.24,7.85,8.01,5,141,112));
         ListiStod.Add(new Stodhestaspilid("Stáli frá Kjarri", "Galsi frá Sauðárkróki", "Jónína frá Hala", 7500,8.26,9.09,8.76,70,140,121));
         ListiStod.Add(new Stodhestaspilid("Gári frá Auðsholtshjáleigu","Orri frá Þúfu","Limra frá Laugarvatni", 1600,8.87,8.47,8.63,162,143,125));
         ListiStod.Add(new Stodhestaspilid("Hugi frá Hafsteinsstöðum", "Hrafn frá Holtsmúla", "Sýn frá Hafsteinsstöðum",1551,8.13,8.49,8.31,370,137,119));
         ListiStod.Add(new Stodhestaspilid("Funi frá Vindási","Dynur frá Hvammi", "Drífa frá Vindási",1600,8.08,8.65,8.42,29,144,122));
         ListiStod.Add(new Stodhestaspilid("Orri frá Þúfu", "Otur frá Sauðárkróki", "Dama frá Þúfu",2500,8.08,8.61,8.34,1049,136,127));
         ListiStod.Add(new Stodhestaspilid("Þóroddur frá Þóroddsstöðum","Oddur frá Selfossi", "Hlökk frá Laugarvatni",1521,8.28,9.04,8.74,218,142,126));
         ListiStod.Add(new Stodhestaspilid("Álfur frá Selfossi", "Orri frá Þúfu", "Álfadís frá Selfossi",1510,7.98,8.44,8.26,82,140,124));
         ListiStod.Add(new Stodhestaspilid("Keilir frá Miðsitju","Ófeigur frá Flugumýri", "Krafla frá Sauðárkroki", 6600,8.42,8.77,8.63,446,138,119));
         ListiStod.Add(new Stodhestaspilid("Krummi frá Blesastöðum 1a", "Kraflar frá Miðsitju", "Raun frá Húsatoftum",0230,8.13,8.55,8.38,86,141,120));
         ListiStod.Add(new Stodhestaspilid("Akkur frá Brautarholti", "Galsi frá Sauðárkróki","Askja frá Miðsitju",1520,8.23,8.80,8.57,72,140,122));
         ListiStod.Add(new Stodhestaspilid("Roði frá Múla", "Orri frá Þúfu", "Litla-Þruma frá Múla",1500, 8.30,7.84,8.07,294,138,119));
         ListiStod.Add(new Stodhestaspilid("Örn frá Efri-Gegnishólum","Aron frá Strandarhöfði","Hrönn frá Efri-Gegnishólum", 1510,7.89,8.45,8.23,18,135,120));
         ListiStod.Add(new Stodhestaspilid("Blær frá Torfunesi", "Markús frá Langholtsparti","Bylgja frá Torfunesi",2500,8.17,8.80,8.55,87,141,126));
         ListiStod.Add(new Stodhestaspilid("Gustur frá Hóli","Gáski frá Hofsstöðum", "Abba frá Gili",0100,8.13,9.01,8.57,644,136,124));
         ListiStod.Add(new Stodhestaspilid("Moli frá Skriðu", "Glampi frá Vatnsleysu", "Gullinstjarna frá Akureyri", 2700,7.98,8.36,8.21,80,141,110));
         ListiStod.Add(new Stodhestaspilid("Þorsti frá Garði", "Ögri frá Háholti", "Þröm frá Gunnarsholti",1722,8.11,8.60,8.40,57,140,116));
         ListiStod.Add(new Stodhestaspilid("Sær frá Bakkakoti","Orri frá Þúfu","Sæla frá Gerðum", 7200,7.96,9.05,8.62,344,143,129));
         ListiStod.Add(new Stodhestaspilid("Eldjárn frá Tjaldhólum","Hugi frá Hafsteinsstöðum", "Hera frá Jaðri", 1500,8.09,8.85,8.55,132,140,119));
         ListiStod.Add(new Stodhestaspilid("Aron frá Strandarhöfði", "Óður frá Brún", "Yrsa frá Skjálg", 2200,8.22,8.75,8.54,276,144,122));
         ListiStod.Add(new Stodhestaspilid("Aris frá Akureyri","Grunur frá Oddhóli","Kátína frá Hömrum", 2500,8.26,8.62,8.47,19,142,117));
         ListiStod.Add(new Stodhestaspilid("Kormákur frá Flugumýri 2", "Kveikur frá Miðsitju", "Kolskör frá Gunnarsholti",3700,8.23,8.37,8.30,327,141,119));
         ListiStod.Add(new Stodhestaspilid("Huginn frá Haga 1", "Sólon frá Hóli", "Vænting frá Haga 1", 0200,7.84,9.05,8.57,218,140,119));
         ListiStod.Add(new Stodhestaspilid("Ás frá Ármóti","Sær frá Bakkakoti", "Bót frá Hólum", 2510, 8.00,8.75,8.45,64,142,121));
         ListiStod.Add(new Stodhestaspilid("Baugur frá Víðinesi 2","Hróður frá Refsstöðum", "Gáta frá Hofi", 1514,8.33,8.58,8.48,68,142,121));
         ListiStod.Add(new Stodhestaspilid("Dagur frá Strandarhöfði", "Baldur frá Bakka", "Sóley frá Tumabrekku", 4500,7.96,8.26,8.14,56,138,113));
         ListiStod.Add(new Stodhestaspilid("Leiknir frá Vakurstöðum", "Safír frá Viðvík", "Lyfting frá Ysta-Mó", 2520,8.04,8.44,8.28,153,137,109));
         ListiStod.Add(new Stodhestaspilid("Grunnur frá Oddhóli", "Kraflar frá Miðsitju", "Gola frá Brekkum", 2520,8.02,8.38,8.23,84,137,117));
         ListiStod.Add(new Stodhestaspilid("Natna frá Ketilsstöðum", "Kolfinnur frá Kjarnholtum 1", "Vænting frá Ketilsstöðum", 3500,8.23,8.51,8.40,22,142,119));
         ListiStod.Add(new Stodhestaspilid("Glymur frá Árgerði", "Kraftur frá Bringu", "Glæða frá Árgerði", 1500,8.18,8.53,8.39,35,140,113));
         ListiStod.Add(new Stodhestaspilid("Adam frá Ásmundarstöðum", "Stígur frá Kjartansstöðum", "Siggu-Brúnka frá Ásmundars.",2700,8.17,8.49,8.36,345,137,124));
         ListiStod.Add(new Stodhestaspilid("Glampi frá Vatnsleysu", "Smári frá Borgarhóli", "Albína frá Vatnsleysu",2790, 7.85,8.68,8.35,401,138,113));
         ListiStod.Add(new Stodhestaspilid("Galsi frá Sauðárkróki", "Ófeigur frá Flugumýri", "Gnótt frá Sauðárkróki", 7500,7.87,9.01,8.44,485,137,116));
         ListiStod.Add(new Stodhestaspilid("Markús frá Langhotlasparti", "Orri frá Þúfu", "Von frá Bjarnastöðum", 2700,7.99,8.61,8.36,293,140,127));
         ListiStod.Add(new Stodhestaspilid("Vilmundur frá Feti","Orri frá Þúfu","Vigdís frá Feti", 2700,7.96,8.95,8.56,59,138,130));

         Console.WriteLine("Hvaða spil viltu spila");
         Console.WriteLine("1. Hrútaspilið");
         Console.WriteLine("2. Stóðhestaspilið");
         Console.WriteLine("0. Hætta");
         val = Convert.ToInt32(Console.ReadLine());
         switch (val)
         {
             case 1:
                 while(Listi.Count() > 0)
         {
             Console.Clear();
             int randtala = random.Next(0, Listi.Count());
             if (teljarispil % 2 == 0)
             {
                 Spilnot.Add(Listi[randtala]);
                 
             }
             else
             {
                 Spiltolvu.Add(Listi[randtala]);
             }
             teljarispil++;
             Listi.Remove(Listi[randtala]);
         }


         do
         {
         
             
             
             TempHrut.Add(Spilnot[0]);
             Console.WriteLine("Spil notanda:");
             Console.WriteLine(TempHrut[0]);
             TempHrut.Remove(Spilnot[0]);

             Console.WriteLine("\nHvað vilt þú bera saman");
             val2 = Convert.ToInt32(Console.ReadLine());
             
             TempHrut.Add(Spiltolvu[0]);           
             Console.WriteLine("Spil Tölvu:");
             Console.WriteLine(TempHrut[0]);
             TempHrut.Remove(Spilnot[0]);
             Console.ReadKey();
             if (val2 == 1)
             {
                 if (Spilnot[0].Þyngd > Spiltolvu[0].Þyngd)
                 {
                     stignot++;
                 }
                 else
                 {
                     stigtolva++;
                 }
             }
             if (val2 == 2)
             {
                 if (Spilnot[0].Mjolkurlagni > Spiltolvu[0].Mjolkurlagni)
                 {
                     stignot++;
                 }
                 else
                 {



                     stigtolva++;
                 }
             }
             if (val2 == 3)
             {
                 if (Spilnot[0].Ull > Spiltolvu[0].Ull)
                 {
                     Console.WriteLine("Þú vannst");
                     Spilnot.Add(Spilnot[0]);
                     Spilnot.Add(Spiltolvu[0]);
                     Spilnot.AddRange(Jafntefli);
                     Jafntefli.Clear();
                 }
                 else if(Spilnot[0].Laeri < Spiltolvu[0].Laeri)
                 {
                     Console.WriteLine("Tölvan vann");
                     Spiltolvu.Add(Spilnot[0]);
                     Spiltolvu.Add(Spiltolvu[0]);
                 }
                 else
                 {
                     Jafntefli.Add(Spilnot[0]);
                     Jafntefli.Add(Spiltolvu[0]);
                 }
             }
             if (val2 == 4)
             {
                 if (Spilnot[0].Laeri > Spiltolvu[0].Laeri)
                 {
                     Console.WriteLine("Þú vannst");
                     Spilnot.Add(Spilnot[0]);
                     Spilnot.Add(Spiltolvu[0]);
                     Spilnot.AddRange(Jafntefli);
                     Jafntefli.Clear();
                 }
                 else if (Spilnot[0].Laeri < Spiltolvu[0].Laeri)
                 {
                     Console.WriteLine("Tölvan vann");
                     Spiltolvu.Add(Spilnot[0]);
                     Spiltolvu.Add(Spiltolvu[0]);
                 }
                 else
                 {
                     Jafntefli.Add(Spilnot[0]);
                     Jafntefli.Add(Spiltolvu[0]);
                 }
             }
             if (val2 == 5)
             {
                 if (Spilnot[0].Frjosemi > Spiltolvu[0].Frjosemi)
                 {
                     Console.WriteLine("Þú vannst");
                     Spilnot.Add(Spilnot[0]);
                     Spilnot.Add(Spiltolvu[0]);
                     Spilnot.AddRange(Jafntefli);
                     Jafntefli.Clear();
                 }
                 else if (Spilnot[0].Frjosemi < Spiltolvu[0].Frjosemi)
                 {
                     Console.WriteLine("Tölvan vann");
                     Spiltolvu.Add(Spilnot[0]);
                     Spiltolvu.Add(Spiltolvu[0]);
                 }
                 else
                 {
                     Jafntefli.Add(Spilnot[0]);
                     Jafntefli.Add(Spiltolvu[0]);
                 }
             }
             if (val2 == 6)
             {
                 if (Spilnot[0].Bakvodvi > Spiltolvu[0].Bakvodvi)
                 {
                     Console.WriteLine("Þú vannst");
                     Spilnot.Add(Spilnot[0]);
                     Spilnot.Add(Spiltolvu[0]);
                     Spilnot.AddRange(Jafntefli);
                     Jafntefli.Clear();
                 }
                 else if(Spilnot[0].Bakvodvi < Spiltolvu[0].Bakvodvi)
                 {
                     Console.WriteLine("Tölvan vann");
                     Spiltolvu.Add(Spilnot[0]);
                     Spiltolvu.Add(Spiltolvu[0]);
                 }
                 else
                 {
                     Jafntefli.Add(Spilnot[0]);
                     Jafntefli.Add(Spiltolvu[0]);
                 }
             }
             if (val2 == 7)
             {
                 if (Spilnot[0].Malir > Spiltolvu[0].Malir)
                 {
                     Console.WriteLine("Þú vannst");
                     Spilnot.Add(Spilnot[0]);
                     Spilnot.Add(Spiltolvu[0]);
                     Spilnot.AddRange(Jafntefli);
                     Jafntefli.Clear();
                 }
                 else if(Spilnot[0].Malir < Spiltolvu[0].Malir)
                 {
                     Console.WriteLine("Tölvan vann");
                     Spiltolvu.Add(Spilnot[0]);
                     Spiltolvu.Add(Spiltolvu[0]);
                 }
                 else
                 {
                     Jafntefli.Add(Spilnot[0]);
                     Jafntefli.Add(Spiltolvu[0]);
                 }
             }
             if (val2 == 8)
             {
                 if (Spilnot[0].Afkvaemi > Spiltolvu[0].Afkvaemi)
                 {
                     Console.WriteLine("Þú vannst");
                     Spilnot.Add(Spilnot[0]);
                     Spilnot.Add(Spiltolvu[0]);
                     Spilnot.AddRange(Jafntefli);
                     Jafntefli.Clear();
                 }
                 else if (Spilnot[0].Afkvaemi < Spiltolvu[0].Afkvaemi)
                 {
                     Console.WriteLine("Tölvan vann");
                     Spiltolvu.Add(Spilnot[0]);
                     Spiltolvu.Add(Spiltolvu[0]);
                 }
                 else
                 {
                     Jafntefli.Add(Spilnot[0]);
                     Jafntefli.Add(Spiltolvu[0]);
                 }
                    
             }
             Spilnot.Remove(Spilnot[0]);
             Spiltolvu.Remove(Spiltolvu[0]);
             Console.WriteLine("\nTölvan er með " + Spiltolvu.Count + " spil");
             Console.WriteLine("Notandinn er með " + Spilnot.Count + " spil");
             
             Console.ReadKey();
             Console.Clear();
         
         } while (Spilnot.Count != 0 && Spiltolvu.Count != 0);
         Console.ReadKey();
                 break;
             case 2:
                 while(ListiStod.Count() > 0)
         {
             Console.Clear();
             int randtala = random.Next(0, ListiStod.Count());
             if (teljarispil % 2 == 0)
             {
                 Spilnot2.Add(ListiStod[randtala]);
                 
             }
             else
             {
                 Spiltolvu2.Add(ListiStod[randtala]);
             }
             teljarispil++;
             ListiStod.Remove(ListiStod[randtala]);
         }


         do
         {
         for (int i = 0; i < 52; i++)
         {
             
             int x = i;
             TempStod.Add(Spilnot2[i]);
             Console.WriteLine("Spil notanda:");
             Console.WriteLine(TempStod[i]);
             TempStod.Remove(Spilnot2[i]);

             Console.WriteLine("\nHvað vilt þú bera saman");
             val2 = Convert.ToInt32(Console.ReadLine());

             TempStod.Add(Spiltolvu2[x]);           
             Console.WriteLine("Spil Tölvu:");
             Console.WriteLine(TempStod[x]);
             TempStod.Remove(Spilnot2[x]);
             Console.ReadKey();
             if (val2 == 1)
             {
                 if (Spilnot2[i].Litanumer > Spiltolvu2[x].Litanumer)
                 {
                     stignot++;
                 }
                 else
                 {
                     stigtolva++;
                 }
             }
             if (val2 == 2)
             {
                 if (Spilnot2[i].ByggingAdaleinkunn > Spiltolvu2[x].ByggingAdaleinkunn)
                 {
                     stignot++;
                 }
                 else
                 {



                     stigtolva++;
                 }
             }
             if (val2 == 3)
             {
                 if (Spilnot2[i].HaefileikarAdaleinkunn > Spiltolvu2[x].HaefileikarAdaleinkunn)
                 {
                     stignot++;
                 }
                 else
                 {
                     stigtolva++;
                 }
             }
             if (val2 == 4)
             {
                 if (Spilnot2[i].Adaleinkunn > Spiltolvu2[x].Adaleinkunn)
                 {
                     stignot++;
                 }
                 else
                 {
                     stigtolva++;
                 }
             }
             if (val2 == 5)
             {
                 if (Spilnot2[i].Afkvaemi > Spiltolvu2[x].Afkvaemi)
                 {
                     stignot++;
                 }
                 else
                 {
                     stigtolva++;
                 }
             }
             if (val2 == 6)
             {
                 if (Spilnot2[i].Stangarmal > Spiltolvu2[x].Stangarmal)
                 {
                     stignot++;
                 }
                 else
                 {
                     stigtolva++;
                 }
             }
             if (val2 == 7)
             {
                 if (Spilnot2[i].Kynbotamat > Spiltolvu2[x].Kynbotamat)
                 {
                     stignot++;
                 }
                 else
                 {
                     stigtolva++;
                 }
             }
             Console.WriteLine("\nTölvan er með " + stigtolva + " stig");
             Console.WriteLine("Notandinn er með " + stignot + " stig");
             
             Console.ReadKey();
             Console.Clear();
         }
         } while (val2 != 0);
         Console.ReadKey();
                 break;
             default:
                 break;
         }
         Console.WriteLine("byebye");
         Console.ReadKey();

         
        
           
            
           
        }
    }
}
