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
            if (pontszam <= 49)
            { 
                Console.WriteLine("Az Ön pontszámának megfelelő jegye elégtelen!");
            }
            else if (pontszam <= 64)
            {
                Console.WriteLine("Az Ön pontszámának megfelelő jegye elégséges!");
            }
            else if (pontszam <= 79)
            {
                Console.WriteLine("Az Ön pontszámának megfelelő jegye közepes!");
            }
            else if (pontszam <= 89)
            {
                Console.WriteLine("Az Ön pontszámának megfelelő jegye jó!");
            }
            else
            {
                Console.WriteLine("Az Ön pontszámának megfelelő jegye jeles!");
            }

            //
            //switch case
            Console.Write("Kérem adja meg az osztályzatát (1-5): ");
            string jegy = Console.ReadLine();
            switch (jegy)
            {
                case "1": Console.WriteLine("elégtelen"); break;
                case "2": Console.WriteLine("elégséges"); break;
                case "3": Console.WriteLine("közepes"); break;
                case "4": Console.WriteLine("jó"); break;
                case "5": Console.WriteLine("jeles"); break;
                default: Console.WriteLine("Nem jól adta meg a jegyet!");break;
            }

            //Progrmozás:
            //1 Szekvencia: utasítások sorozata
            //2 Szelekció: if-else, switch-case
            //3 Iteráció: más néven ciklusok
            // - előltesztelős ciklus
            // - hátultesztelős ciklus
            // -növekményes, vagy számlálós ciklus

            //1.feladat
            Console.Write("adjon meg egy egész számot: ");
            //int szam  = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(int.Parse(Console.ReadLine())));

            //2.feladat
            //Véletlenszám generálása
            Random veletlen = new Random();
            int szam1 = veletlen.Next(0,11);
            int szam2 = veletlen.Next(0, 11);
            int szam3 = veletlen.Next(0, 11);
            int oszto = 3;
            double atlag  = (double) (szam1  +  szam2  +  szam3)  /  oszto;
            //Console.WriteLine($"a három véletlen szám {szam1}, {szam2}, {szam3} átlaga: {Math.Round(atlag,2)}");
            Console.WriteLine($"a három véletlen szám {szam1}, {szam2}, {szam3} átlaga: {atlag.ToString("0.00")}");

            int a = 3;
            int b = 5;
            Console.WriteLine(Math.Pow(a, b));

            //Házi feladat
            //Sorsolj ki egy egész számot az [1;99] intervallumból, és írd ki, 
            //milyen számjegyre végződik!
            Console.ReadKey();
        }
    }
}
