using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    internal static class Admission
    {
        public static double _passingScore = 4.5;

        public static bool IsPassed(double score)
        {
            return score > _passingScore;
        }
    }
}
