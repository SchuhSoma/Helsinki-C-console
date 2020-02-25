using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Helsinki2
{
    class Program
    {
        static List<Helsinki> HelsinkiList;
        static void Main(string[] args)
        {
            Feladat2Beolvasas();
            Feladat3PontszerzoMagyarok();
            Feladat4ErmekSzama();
            Feladat5EertOlimpiaiPontok();
            Feladat6UszasVagyTorna();
            Feladat7Csere();
            Feladat8LegtobbPontszerzo();
            Console.ReadKey();
        }

        private static void Feladat8LegtobbPontszerzo()
        {
            Console.WriteLine("\n8.Feladat: Legtöbb Pontszerző");
            int MaxSportolokSzama = int.MinValue;
            string MaxSportagNeve = "cica";
            string MaxVersenyszamNeve = "kutya";
            foreach (var h in HelsinkiList)
            {
                if(h.SportolokSzama> MaxSportolokSzama && h.Helyezes<4)
                {
                    MaxSportolokSzama = h.SportolokSzama;
                    MaxSportagNeve = h.SportagNeve;
                    MaxVersenyszamNeve = h.VersenyszamNeve;
                }
            }
            Console.WriteLine("\tSportolók száma: {0,-3} \n\tSportág neve: {1,-15} \n\tVersenyszám: {2}",MaxSportolokSzama, MaxSportagNeve,MaxVersenyszamNeve);

        }

        private static void Feladat7Csere()
        {
            Console.WriteLine("\n7.Feladat: Csere");
            int db = 0;
            var sw = new StreamWriter(@"Helsinki2.txt",false,Encoding.UTF8);
            foreach (var h in HelsinkiList)
            {
                db++;
                if (h.SportagNeve == "kajakkenu")
                {
                    if(h.Helyezes==1)
                    {
                        Console.WriteLine("{0} {1} kajak-kenu {2}", h.Helyezes, 7 * h.Helyezes,h.VersenyszamNeve);
                        sw.WriteLine("{0} {1} kajak-kenu {2}", h.Helyezes, 7 * h.Helyezes, h.VersenyszamNeve);
                    }
                    if (h.Helyezes == 2)
                    {
                        Console.WriteLine("{0} {1} kajak-kenu {2}", h.Helyezes, 5 * h.Helyezes, h.VersenyszamNeve);
                        sw.WriteLine("{0} {1} kajak-kenu {2}", h.Helyezes, 5 * h.Helyezes, h.VersenyszamNeve);
                    }
                    if (h.Helyezes == 3)
                    {
                        Console.WriteLine("{0} {1} kajak-kenu {2}", h.Helyezes, 4 * h.Helyezes, h.VersenyszamNeve);
                        sw.WriteLine("{0} {1} kajak-kenu {2}", h.Helyezes, 4 * h.Helyezes, h.VersenyszamNeve);
                    }
                    if (h.Helyezes == 4)
                    {
                        Console.WriteLine("{0} {1} kajak-kenu {2}", h.Helyezes, 3 * h.Helyezes, h.VersenyszamNeve);
                        sw.WriteLine("{0} {1} kajak-kenu {2}", h.Helyezes, 3 * h.Helyezes, h.VersenyszamNeve);
                    }
                    if (h.Helyezes == 5)
                    {
                        Console.WriteLine("{0} {1} kajak-kenu {2}", h.Helyezes, 2 * h.Helyezes, h.VersenyszamNeve);
                        sw.WriteLine("{0} {1} kajak-kenu {2}", h.Helyezes, 2 * h.Helyezes, h.VersenyszamNeve);
                    }
                    if (h.Helyezes == 6)
                    {
                        Console.WriteLine("{0} {1} kajak-kenu {2}", h.Helyezes, 1 * h.Helyezes, h.VersenyszamNeve);
                        sw.WriteLine("{0} {1} kajak-kenu {2}", h.Helyezes, 1 * h.Helyezes, h.VersenyszamNeve);
                    }
                   

                }
                else
                {
                    if (h.Helyezes == 1)
                    {
                        Console.WriteLine("{0} {1} {2} {3}", h.Helyezes, 7 * h.Helyezes, h.SportagNeve,h.VersenyszamNeve);
                        sw.WriteLine("{0} {1} {2} {3}", h.Helyezes, 7 * h.Helyezes, h.SportagNeve, h.VersenyszamNeve);
                    }
                    if (h.Helyezes == 2)                
                    {
                        Console.WriteLine("{0} {1} {2} {3}", h.Helyezes, 5 * h.Helyezes, h.SportagNeve, h.VersenyszamNeve);
                        sw.WriteLine("{0} {1} {2} {3}", h.Helyezes, 5 * h.Helyezes, h.SportagNeve, h.VersenyszamNeve);
                    }
                    if (h.Helyezes == 3)                
                    {
                        Console.WriteLine("{0} {1} {2} {3}", h.Helyezes, 4 * h.Helyezes, h.SportagNeve, h.VersenyszamNeve);
                        sw.WriteLine("{0} {1} {2} {3}", h.Helyezes, 4 * h.Helyezes, h.SportagNeve, h.VersenyszamNeve);
                    }
                    if (h.Helyezes == 4)                
                    {
                        Console.WriteLine("{0} {1} {2} {3}", h.Helyezes, 3 * h.Helyezes, h.SportagNeve, h.VersenyszamNeve);
                        sw.WriteLine("{0} {1} {2} {3}", h.Helyezes, 3 * h.Helyezes, h.SportagNeve, h.VersenyszamNeve);
                    }
                    if (h.Helyezes == 5)                
                    {
                        Console.WriteLine("{0} {1} {2} {3}", h.Helyezes, 2 * h.Helyezes, h.SportagNeve, h.VersenyszamNeve);
                        sw.WriteLine("{0} {1} {2} {3}", h.Helyezes, 2 * h.Helyezes, h.SportagNeve, h.VersenyszamNeve);
                    }
                    if (h.Helyezes == 6)                
                    {
                        Console.WriteLine("{0} {1} {2} {3}", h.Helyezes, 1 * h.Helyezes, h.SportagNeve, h.VersenyszamNeve);
                        sw.WriteLine("{0} {1} {2} {3}", h.Helyezes, 1 * h.Helyezes, h.SportagNeve, h.VersenyszamNeve);
                    }
                }
            }
            sw.Close();
        }

        private static void Feladat6UszasVagyTorna()
        {
            Console.WriteLine("\n6.Feladat: Úszás vagy Torna");
            int torna = 0;
            int uszas = 0;
            foreach (var h in HelsinkiList)
            {
                if(h.SportagNeve=="uszas" && h.Helyezes<4)
                {
                    uszas++;
                }
                if (h.SportagNeve == "torna" && h.Helyezes < 4)
                {
                    torna++;
                }
            }
            Console.WriteLine("\tÉrmes úszok száma:{0}",uszas);
            Console.WriteLine("\tÉrmes torma száma:{0}", torna);
            if(torna>uszas)
            {
                Console.WriteLine("\tTorna sportágban szereztek több érmet");
            }
            if (torna < uszas)
            {
                Console.WriteLine("\tÚszás sportágban szereztek több érmet");
            }
            if (torna == uszas)
            {
                Console.WriteLine("\tEgyenlő volt az érmek száma");
            }
        }

        private static void Feladat5EertOlimpiaiPontok()
        {
            Console.WriteLine("\n5.Feladat: Elért Olimpiai pontok száma");
            int elso = 0;
            int masodik = 0;
            int harmadik = 0;
            int negyedik = 0;
            int otodik = 0;
            int hatodik = 0;
            int PontokSzama = 0;
            foreach (var h in HelsinkiList)
            {
                if(h.Helyezes==1)
                {
                    elso++;
                }
                if (h.Helyezes == 2)
                {
                    masodik++;
                }
                if (h.Helyezes == 3)
                {
                    harmadik++;
                }
                if (h.Helyezes == 4)
                {
                    negyedik++;
                }
                if (h.Helyezes == 5)
                {
                    otodik++;
                }
                if (h.Helyezes == 6)
                {
                    hatodik++;
                }
                PontokSzama = 7 * elso + 5 * masodik + 4 * harmadik + 3 * negyedik + 2 * otodik + 1 * hatodik;

            }
            Console.WriteLine("\tÖsszesen elért Olimpiai pontok száma:{0}",PontokSzama);
        }

        private static void Feladat4ErmekSzama()
        {
            Console.WriteLine("\n4.Feladat: Érmek száma");
            int arany = 0;
            int ezust = 0;
            int bronz = 0;
            foreach (var h in HelsinkiList)
            {
                if(h.Helyezes == 1)
                {
                    arany++;
                }
                if (h.Helyezes == 2)
                {
                    ezust++;
                }
                if (h.Helyezes == 3)
                {
                    bronz++;
                }
            }
            Console.WriteLine("\tArany érmek száma:{0}",arany);
            Console.WriteLine("\tEzüst érmek száma:{0}", ezust);
            Console.WriteLine("\tBronz érmek száma:{0}", bronz);
            Console.WriteLine("\tÖsszes érem száma: {0}",arany+ezust+bronz);
        }

        private static void Feladat3PontszerzoMagyarok()
        {
            Console.WriteLine("\n3.Feladat: pontszerző magyarok száma");
            int db = 0;
            foreach (var h in HelsinkiList)
            {
                db++;
            }
            Console.WriteLine("\tPontszerző magyarok száma:{0}",db);
            Console.WriteLine("\tPontszerző magyarok száma:{0}",HelsinkiList.Count);
        }

        private static void Feladat2Beolvasas()
        {
            Console.WriteLine("2.Feladat: Adatok beolvasása");
            HelsinkiList = new List<Helsinki>();
            var sr = new StreamReader(@"Helsinki.txt",Encoding.UTF8);
            while(!sr.EndOfStream)
            {
                HelsinkiList.Add(new Helsinki(sr.ReadLine()));
            }
            Console.WriteLine("\tSikeres beolvasás");
            sr.Close();
        }
    }
}
