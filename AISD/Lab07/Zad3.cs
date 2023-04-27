using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab07
{
    public class Zad3
    {
        public static bool SprawdzPoprawnoscZnakow(string s)
        {
            int s1 = 0;
            int s2 = 0;
            int s3 = 0;
            Stack last = new Stack();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('('))
                {
                    s1++;
                    last.Push(s[i]);
                }
                else if (s[i].Equals(')'))
                {
                    if (s1 < 1 || !last.Peek().Equals('(')) return false;
                    s1--;
                    last.Pop();
                }

                else if (s[i].Equals('['))
                {
                    s2++;
                    last.Push(s[i]);
                }
                else if (s[i].Equals(']'))
                {
                    if (s2 < 1 || !last.Peek().Equals('[')) return false;
                    s2--;
                    last.Pop();
                }

                else if (s[i].Equals('{'))
                {
                    s3++;
                    last.Push(s[i]);
                }  
                else if (s[i].Equals('}'))
                {
                    if (s3 < 1 || !last.Peek().Equals('{')) return false;
                    s3--;
                    last.Pop();
                }

                else return false;
            }

            return s1 == 0 && s2 == 0 && s3 == 0;
        }

        public static void Run()
        {
            Console.WriteLine("Zadanie 3 - sprawdzanie poprawnosci znakow");
            Console.WriteLine();

            string znaki = "({}[[({)}]{}])";
            Console.WriteLine(SprawdzPoprawnoscZnakow(znaki));
        }
    }
}
