using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    internal class Ingredient
    {
        private string _name;
        private string _effect;
        private double _price;

        public double Price { get { return _price; } }

        public static bool operator <(Ingredient i1, Ingredient i2)
        {
            return i1._price < i2._price;
        }

        public static bool operator >(Ingredient i1, Ingredient i2)
        {
            return i1._price > i2._price;
        }

        public static Ingredient operator +(Ingredient i1, Ingredient i2)
        {
            Ingredient res = new Ingredient();
            res._effect = i1._effect + ", " + i2._effect;
            res._price = i1._price + i2._price;
            return res;
        }
    }
}
