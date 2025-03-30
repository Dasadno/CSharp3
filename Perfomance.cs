using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    internal class Perfomance
    {
        public static int MinAge { get; set; } = 18;
        public static int MaxAge { get; set; } = 70;

        public static bool CheckWorkAbility(Human person)
        {
            return person.Age >= MinAge && person.Age <= MaxAge;
        }
    }
}
