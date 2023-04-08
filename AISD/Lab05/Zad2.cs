using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab05
{
    public class Zad2
    {

        public static float P(int i, int j)
        {
            float[,] tab = new float[i + 1,j + 1];
            for(int fd = 0; fd < i+1; fd++)
            {
                for(int sd = 0; sd < j+1; sd++)
                {
                    if (fd > 0 && sd == 0) tab[fd, sd] = 0;
                    else if (fd == 0 && sd > 0) tab[fd, sd] = 1;
                    else if (fd > 0 && sd > 0) tab[fd, sd] = (tab[fd - 1, sd] + tab[fd, sd - 1]) / 2;
                }
            }

            /*
            for (int fd = 0; fd < tab.GetLength(0); fd++)
            {
                for (int sd = 0; sd < tab.GetLength(1); sd++)
                {
                    Console.Write(tab[fd, sd] + " \t");
                }
                Console.WriteLine();
            }
            */

            return tab[i,j];
        }

        public static void Run()
        {
            Console.WriteLine("Zad2 - wyznaczanie wartosci wyrazenia P(i,j) dla: i = 5 , j = 5");
            Console.WriteLine();

            Console.WriteLine(P(5, 5));
        }
    }
}
