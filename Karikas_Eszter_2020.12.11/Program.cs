using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karikas_Eszter_2020._12._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.feladat: Egy BKV jegy 270 Ft, egy automatából vett kávé 70 Ft, egy liter tej 210 Ft és egy üveg bor 700 Ft. 
            //Olvasd be a forint - euro árfolyamot (1 euro hány forint), majd írd ki a fenti termékek árát euroban! 
            int bkvjegy = 270;
            int kave = 70;
            int tej = 210;
            //Euró árfolyam: 360
            double bkvjegy_euro = (double) bkvjegy / 360; //típuskényszerítés
            Console.WriteLine($"A BKV jegy ára Euróban: {Math.Round(bkvjegy_euro,2)} euro");
            double kave_euro = (double)kave / 360;
            Console.WriteLine($"A kávé ára Euróban: {Math.Round(kave_euro,2)} euro");
            double tej_euro = (double) tej / 360;
            Console.WriteLine($"A tej ára Euróban: {Math.Round(tej_euro,2)} euro");

            //4.feladat: Írjon egy programot, ami leosztályoz egy maximálisan 100 pontos dolgozatot 
            //az 50, 65, 80, 90 ponthatárok szerint! A határérték a jobb jegyhez tartozik. 
            //Ha a pontszám negatív vagy száznál nagyobb, akkor a program írja ki, hogy hibás az adat!
            //50 ponttól elégséges | 0 - 49 elégtelen
            //65 ponttól közepes | 50 - 64 elégséges
            //80 ponttól jó | 65 - 79 közepes
            //90 ponttól jeles | 80 - 89 jó
            //Elágaz feladatmegoldással megoldható
            Console.Write("Kérem adja meg a dolgozatánka pontszámát: ");
            int pontszam = int.Parse(Console.ReadLine());
            //int pont = int.Parse(pontszam);
            if (pontszam >= 0 && pontszam <= 49)
            {
                Console.WriteLine("Az Ön pontszámának megfelelő jegye elégtelen!");
            }
            else if (pontszam >= 50 && pontszam <= 64)
            {
                Console.WriteLine("Az Ön pontszámának megfelelő jegye elégséges!");
            }
            else if (pontszam >= 65 && pontszam <= 79)
            {
                Console.WriteLine("Az Ön pontszámának megfelelő jegye közepes!");
            }
            else if (pontszam >= 80 && pontszam <= 89)
            {
                Console.WriteLine("Az Ön pontszámának megfelelő jegye jó!");
            }
            else
            {
                Console.WriteLine("Az Ön pontszámának megfelelő jegye jeles!");
            }

            //
            Console.ReadKey();
        }
    }
}
