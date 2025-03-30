using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    internal class CatWeightStandart
    {
        public static double s_SmallWeight { get; set; } = 1; // Вы можете подумать, что я внезапно начал пользоваться gpt,
        public static double s_MediumWeight { get; set; } = 3; // Но мне просто стало любопытно, как правильно называть статические поля, вот я и почитал Microsoft CodeStyle
        public static double s_LargeWeight { get; set; } = 5;

        public static void CheckWeight(Cat cat)
        {
            if (cat.Weight < s_SmallWeight)
            {
                Console.WriteLine("Котик очень худой");
            }
            if (cat.Weight < s_MediumWeight)
            {
                Console.WriteLine("Котик худой");
            }
            if (cat.Weight < s_LargeWeight)
            {
                Console.WriteLine("Котик полноват");
            }
            Console.WriteLine("Котик полный");
        }
    }
}
