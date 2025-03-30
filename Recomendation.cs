using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    internal class Recomendation
    {
        public static bool CheckRecommendation(SocialMediaPost post)
        {
            return post.Likes >= 2 * post.Dislikes;
        }
    }
}
