using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab03
{
    public class Zad6
    {
        public static string DecToBin(int liczba, string bin = "", bool first = true)
        {
            if (liczba == 0) return "0";
            if (liczba > 1)
            {
                bin += Convert.ToString(liczba % 2);
                liczba /= 2;
                bin = DecToBin(liczba, bin, false);
            }
            else if(liczba == 1)
            {
                bin += "1";
            }

            if(!first) return bin;
            return OdwrocStringa(bin);
        }

        public static string OdwrocStringa(string s)
        {
            string rev = "";
            for(int i=s.Length - 1; i>=0; i--)
            {
                rev += s[i];
            }
            return rev;
        }


        public static void Run()
        {
            Console.WriteLine("Zad6 - rekurencyjny program zamiany liczby dziesietnej na binarna");
            Console.WriteLine();
            int a = -1;
            Console.WriteLine("Podaj liczbe naturalna");
            while (a < 0)
            {
                a = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine(a + " to w systemie binarnym: " + DecToBin(a));
        }
    }
}
