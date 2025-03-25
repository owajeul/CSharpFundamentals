using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class FacebookLike
    {
        public static List<string> GetLikers()
        {
            List<string> likers = new List<string>();
            Console.WriteLine("Enter names of likers (press Enter to stop):");

            while (true)
            {
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                    break;

                likers.Add(name);
            }

            return likers;
        }

        public static void DisplayLikeMessage(List<string> likers)
        {
            int likeCount = likers.Count;

            if (likeCount == 0)
            {
                Console.WriteLine();
            }
            else if (likeCount == 1)
            {
                Console.WriteLine($"{likers[0]} likes your post.");
            }
            else if (likeCount == 2)
            {
                Console.WriteLine($"{likers[0]} and {likers[1]} like your post.");
            }
            else
            {
                Console.WriteLine($"{likers[0]}, {likers[1]} and {likeCount - 2} {(likeCount - 2 > 1 ? "others": "other" )} like your post.");
            }
        }
    }
    
}
