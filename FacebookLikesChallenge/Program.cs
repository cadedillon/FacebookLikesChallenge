using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLikesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] userLikes = LikeSomething.CreateLikesArray();
            //string whoLikesThis = LikeSomething.Likes(userLikes);
            //LikeSomething.DisplayResults(whoLikesThis);

            LikeSomething.DisplayResults(
                LikeSomething.Likes(
                    LikeSomething.CreateLikesArray()));
        }
    }

    class LikeSomething
    {
        public static string[] CreateLikesArray()
        {
            Console.WriteLine("\n\t" + "Input the number of users who liked your post.");
            string reply = Console.ReadLine();
            int numLikes = int.Parse(reply);

            Console.WriteLine("\n\t" + "Input the first name of the users that liked your post.");
            string[] names = new string[numLikes];

            for (int index = 0; index < names.Length; index++)
            {
                string name = Console.ReadLine();
                names[index] = name;
            }
            return names;
        }

        public static string Likes(string[] names)
        {
           string whoLikesThis;

            switch (names.Length)
            {
                case 0:
                    whoLikesThis = "Nobody likes this.";
                    break;
                case 1:
                    whoLikesThis = $"{names[0]} likes this.";
                    break;
                case 2:
                    whoLikesThis = $"{names[0]} and {names[1]} like this.";
                    break;
                case 3:
                    whoLikesThis = $"{names[0]}, {names[1]} and {names[2]} like this.";
                    break;
                default:
                    whoLikesThis = $"{names[0]}, {names[1]}, and {names.Length - 2} others like this.";
                    break;
            }

            return whoLikesThis;

        }

        public static void DisplayResults(string likes)
        {
            Console.WriteLine("\n\t" + likes);
        }
    }
}
