using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD
{
    public class Statyki
    {
        public static int lab = 0, nr = 0;
        public static int GetLiczbaZadan(int lab)
        {
            switch (lab)
            {
                    case 1:return 5;
                    case 2:return 3;
                    case 3:return 7;
                    case 4:return 4;
                    case 5: return 4;
                default:return 0;
            }
        }

        public static int getLiczbaLaboratoriow()
        {
            return 5;
        }
    }
}
