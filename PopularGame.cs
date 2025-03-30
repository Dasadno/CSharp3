using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    static internal class PopularGame
    {
     
        public static double s_rating = 8.5;
        public static int s_avgPlayers = 1000;
        public static int s_maxPlayers = 10000;

        public static bool CheckPopularity(Game game)
        {
           return game.Rating >= s_rating && game.AveragePlayers>= s_avgPlayers && game.MaxPlayers >= s_maxPlayers;
        }
        
    }
}
