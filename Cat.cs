using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    internal class Cat
    {
        private string _name;
        private string _breed;
        private DateTime _birthDate;
        private double _weight;

        public double Weight { get; }

        public static bool operator <(Cat lsd, Cat rsd)
        {
            return lsd._weight < rsd._weight;
        }

        public static bool operator >(Cat lsd, Cat rsd)
        {
            return lsd._weight > rsd._weight;
        }

        public static string operator *(Cat lsd, Cat rsd)
        {
            if (lsd._breed == rsd._breed)
            {
                return "Селекция возможна";
            }
            return "Селекция невозможна";
        }
    }
}
