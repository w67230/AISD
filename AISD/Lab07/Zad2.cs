using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab07
{
    public class Zad2
    {
        public static bool CzyNawiasyPoprawne(string s)
        {
            Stack s1 = new Stack();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('(')) s1.Push(s[i]);
                else if (s[i].Equals(')'))
                {
                    if (s1.Count < 1) return false;
                    s1.Pop();
                }
                else return false;
            }
            return s1.Count < 1;
        }

        public static void Run()
        {
            Console.WriteLine("Zadanie 2 - sprawdzanie poprawnosci nawiasow okraglych");
            Console.WriteLine();

            string nawiasy = "((()))()";
            Console.WriteLine(CzyNawiasyPoprawne(nawiasy));
        }
    }
}
