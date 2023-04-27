using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab07
{
    public class Zad6
    {

        private static Queue UtworzUczestnikow(int x)
        {
            Queue queue = new Queue();

            for(int i = 1; i < x+1; i++)
            {
                queue.Enqueue(i);
            }

            return queue;
        }

        private static void KrecZiemniakiem(Queue queue, int x)
        {
            for(int i = 0; i < x; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
            Console.WriteLine("Odpada uczestnik nr: " + queue.Dequeue());

        }

        private static int WezLosowaLiczbePodan(int x)
        {
            Console.WriteLine();
            Random random = new Random();
            x = random.Next(x) + 1;
            Console.WriteLine("Uczestnicy sa eliminowani po " + x + " podaniach");
            return x;
        }

        public static void Run()
        {
            Console.WriteLine("Zadanie 6 - gra w goracego ziemniaka");
            Console.WriteLine();

            int x = 10;
            Queue queue = UtworzUczestnikow(x);
            Console.WriteLine("Numery uczestnikow: ");
            for (int i = 1; i < x + 1; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");

            int eliminuj;
            

            while (queue.Count > 1)
            {
                //eliminuj = 5;
                eliminuj = WezLosowaLiczbePodan(20);

                KrecZiemniakiem(queue, eliminuj);
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Wygrywa uczestnik nr: " + queue.Dequeue());

        }
    }
}
