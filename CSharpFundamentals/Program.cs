using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
           List<string> likers = FacebookLike.GetLikers();
           FacebookLike.DisplayLikeMessage(likers);
        }
    }
}
