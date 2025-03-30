using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3
{
    internal class SocialMediaPost
    {
        private int _id;
        private int _likes;
        private int _dislikes;
        private string _message;

        public int Likes { get { return _likes; } }
        public int Dislikes { get { return _dislikes; } }

        public static SocialMediaPost operator +(SocialMediaPost post, int likes)
        {
            post._likes += likes;
            return post;
        }

        public static SocialMediaPost operator -(SocialMediaPost post)
        {
            post._dislikes++;
            return post;
        }

        public static SocialMediaPost operator ++(SocialMediaPost post)
        {
            post._likes++;
            return post;
        }

        public static SocialMediaPost operator --(SocialMediaPost post)
        {
            post._dislikes++;
            return post;
        }
    }
}
