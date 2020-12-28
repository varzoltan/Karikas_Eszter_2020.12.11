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
            // - előltesztelős ciklus //Ha nem tudjuk hányszor kell lefutnia a ciklusnak
            // - hátultesztelős ciklus //Ha nem tudjuk hányszor kell lefutnia a ciklusnak
            // -növekményes, vagy számlálós ciklus //Ha tudjuk hányszor kell lefuztnia a ciklusnak!

            //1.feladat
            Console.Write("adjon meg egy egész számot: ");
            //int szam  = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(int.Parse(Console.ReadLine())));

            //2.feladat
            //Véletlenszám generálása
            Random veletlen = new Random();
            int szam1 = veletlen.Next(0,11);
            int szam2 = veletlen.Next(0, 11);
            int szam3 = veletlen.Next(11);
            int oszto = 3;
            double atlag  = (double) (szam1  +  szam2  +  szam3)  /  oszto;
            //Console.WriteLine($"a három véletlen szám {szam1}, {szam2}, {szam3} átlaga: {Math.Round(atlag,2)}");
            Console.WriteLine($"a három véletlen szám {szam1}, {szam2}, {szam3} átlaga: {atlag.ToString("0.00")}");

            int a = 3;
            int b = 5;
            Console.WriteLine(Math.Pow(a, b));
            int szam4 = veletlen.Next(1,100);

            //Házi feladat
            //Sorsolj ki egy egész számot az [1;99] intervallumból, és írd ki, 
            //milyen számjegyre végződik!
            double maradek = (double) szam4 % 10;
            Console.WriteLine($"A szám ({szam4}) végződése: {maradek}");

            //4.feladat: Sorsolj ki egy egész számot a [7;24] intervallumból. 
            //Írd ki a szám osztóit!
            int szam5 = veletlen.Next(7,25);
            //számlálós ciklussal oldjuk meg!
            /*for(//honnan indulunk;Meddig megyünk;Lépésköz)
            {
            }*/
            Console.Write($"4.feladat\nA {szam5} osztói: 1, ");
            for(int i = 2;i <= szam5/2;i++)
            {
                if(szam5 % i == 0)
                {
                    Console.Write($"{i}, ");
                }
            }
            Console.Write($" {szam5}");

            //5.feladat: Generáljunk egy véletlen egész számot a [90;100] intervallumból.
            //5.1. Számoljuk meg hány darab páros és páratlan osztólya van a generált számnak.
            Console.WriteLine("\n5.feladat");
            int szam6 = veletlen.Next(90, 101);
            int paros = 0;//Összegzéd tétele
            int paratlan = 0;
            for (int i = 2; i <= szam6 / 2; i++)
            {
                if (szam6 % i == 0)
                {
                   if(i%2==0)
                   {
                        paros++;
                   }
                   else
                   {
                        paratlan++;
                   }
                }
            }
            Console.WriteLine($" A véletlen szám páros osztója: {paros} darab, páratlan osztója: {paratlan} darab");
            Console.Write($" {szam6}");

            //6.feladat
            //Kérj be 2 egész számot a felhasználótól a [-100;100] intervallumból, 
            //és írd ki a közöttük lévő páros számokat!
            int szam7 = veletlen.Next(-100, 101);
            int szam8 = veletlen.Next(-100, 101);
            Console.WriteLine($"\n6.feladat {szam7}, {szam8}");
            if (szam7 > szam8)
            {
                for (int i = szam8; i <= szam7; i++)
                {
                    if(i%2==0)
                    {
                        Console.Write($"{i} ");
                    }
                }

            }
            else
            {
                for (int i = szam7; i <= szam8; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }

            //7.feladat
            //Kérj be egy negatív egész számot a felhasználótól, és írd ki az ettől nagyobb negatív számokat!
            Console.Write($"\n7.feladat\nKérem adjon meg egy negatív egész számot: ");
            int negativ_egesz = int.Parse(Console.ReadLine());
            for(int i=negativ_egesz; i<=0;i++)
            {
                Console.Write($"{i} ");
            }
            //előltesztelős ciklussal oldom meg a feladatot!
            //int lepeskoz = 0;
            Console.WriteLine();
            while(negativ_egesz <= 0)
            {
                Console.Write($"{negativ_egesz} ");
                negativ_egesz++;
            }

            //8.feladat
            // Hozz létre egy 10 elemű tömböt, amit tölts fel a [0;20] intervallumból véletlen számokkal! 
            // Írd ki a tömb páros egyjegyű számait!
            Console.ReadKey();
        }
    }
}
