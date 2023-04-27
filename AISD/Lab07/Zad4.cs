using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab07
{
    public class Zad4
    {
        private static HashSet<char> set = new HashSet<char>() { '+', '-', '*', '/', '%', '^', '=' };

        public static int WykonajOdpowiednieDzialanie(int fNumber, char znak, int sNumber)
        {
            if (znak == '+') return fNumber + sNumber;
            if(znak == '-') return fNumber - sNumber;
            if(znak == '*') return fNumber * sNumber;
            if(znak == '/') return fNumber / sNumber;
            if(znak == '%') return fNumber % sNumber;
            if(znak == '^')
            {
                int mnoznik = fNumber;
                for(int i = sNumber; i > 1; i--)
                {
                    fNumber *= mnoznik;
                }
                return fNumber;
            }
            return 0;
        }

        public static int LiczNotacjePostfiksowa(string s)
        {
            Stack stack = new Stack();
            int temp = 0;
            string liczba;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ') continue;

                if (set.Contains(s[i]))
                {
                    if (s[i] == '=') break;
                    temp = Convert.ToInt32(stack.Pop().ToString());
                    stack.Push(WykonajOdpowiednieDzialanie(Convert.ToInt32(stack.Pop().ToString()), s[i], temp));
                }
                else
                {
                    liczba = "" + s[i];
                    while(i < s.Length - 1)
                    {
                        if (s[i + 1] == ' ' || set.Contains(s[i + 1])) break;
                        liczba += s[i + 1];
                        i++;
                    }
                    stack.Push(liczba);
                }
            }

            return Convert.ToInt32(stack.Peek());
        }
        public static void Run()
        {
            Console.WriteLine("Zadanie 4 - program czytajacy wyrazenia arytmetyczne w notacji postfiksowej i obliczajacy jego wartosc");
            Console.WriteLine();

            string dzialanie = "7 3 + 5 2 - 2 ^ * =";
            //string dzialanie = "2 5 123 + * =";
            Console.WriteLine("7 3 + 5 2 - 2 ^ * = " + LiczNotacjePostfiksowa(dzialanie));




        }
    }
}
