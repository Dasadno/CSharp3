using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    internal class Country
    {
        private string _name;
        
        public double Area { get; set; }   
        public int Population { get; set; }

        public static Country operator +(Country s1, Country s2)
        {
            Country res = new Country();
            res._name = s1._name;
            res.Population = s1.Population + s2.Population;
            res.Area = s1.Area + s2.Area;
            return res;
        }

        public static bool operator <(Country s1, Country s2)
        {
            if (s1.Population == s2.Population)
            {
                return s1.Area < s2.Area;
            }   
            return s1.Population < s2.Population;
        }

        public static bool operator >(Country s1, Country s2)
        {
            if (s1.Population == s2.Population)
            {
                return s1.Area > s2.Area;
            }
            return s1.Population > s2.Population;
        }
    }
}
