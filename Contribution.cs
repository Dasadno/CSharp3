using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    internal class Contribution
    {
        public string _fio;
        public double _money;
        public static double procent = 10.5;


        public static Contribution operator++ (Contribution lsd)
        {
            lsd._money += lsd._money / 100 * procent;
            return lsd;
        }
    }
}
