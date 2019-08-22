using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Social_Media_Posts
{
    class Program
    {
        static void Main(string[] args)
        {
            var postsDict = new Dictionary<string, List<string>>();
            var commentsDict = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();


            while (input != "drop the media")
            {
                string[] tokens = input.Split(' ');
                string action = tokens[0];

                switch (action)
                {
                    case "post":
                        string postName = tokens[1];
                        if (!postsDict.ContainsKey(postName))
                        {
                            postsDict[postName] = new List<string>();
                        }
                        break;
                    case "like":
                        string postToLike = tokens[1];
                        postsDict[postToLike].Add("likes");
                        break;
                    case "dislike":
                        string postToDislike = tokens[1];
                        postsDict[postToDislike].Add("dislikes");
                        break;
                    case "comment":
                        string postToComment = tokens[1];
                        string commentator = tokens[2];
                        string comment = string.Empty;
                        if (tokens.Length > 3)
                        {
                            for (int i = 3; i < tokens.Length; i++)
                            {
                                comment += tokens[i] + " ";
                            }
                            comment.TrimEnd(' ');
                        }
                        else
                        {
                            comment = tokens[3];
                        }
                        if (!commentsDict.ContainsKey(postToComment))
                        {
                            commentsDict[postToComment] = new List<string>();
                        }
                        commentsDict[postToComment].Add(commentator);
                        commentsDict[postToComment].Add(comment);
                        break;
                }
                input = Console.ReadLine();
            }
            foreach (var item in postsDict)
            {
                int likes = 0;
                int dislikes = 0;
                var strings = item.Key;
                List<string> likeAndDis = postsDict[strings];
                for (int i = 0; i < likeAndDis.Count; i++)
                {
                    if (likeAndDis[i] == "likes")
                    {
                        likes++;
                    }
                    else
                    {
                        dislikes++;
                    }
                }
                Console.WriteLine($"Post: {item.Key} | Likes: {likes} | Dislikes: {dislikes}");
                if (commentsDict.ContainsKey(item.Key))
                {
                    var key = item.Key;
                    Console.WriteLine("Comments:");

                    List<string> values = commentsDict[key];
                    for (int i = 0; i < values.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write($"*  {values[i]}: ");
                        }
                        else
                        {
                            Console.Write($"{values[i]}");
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Comments:");
                    Console.WriteLine("None");
                }
            }
        }
    }
}
