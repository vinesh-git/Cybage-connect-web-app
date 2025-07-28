using CybageConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnectModels
{
    public class KnowledgeSharingOfUser
    {
        public static void UserArticles(int id,string UserName)
        {
            while (true)
            {
                Console.WriteLine("For displaying Articles Press 1");
                Console.WriteLine("For Adding Articles Press 2");
                Console.WriteLine("For Going Back press 3");
                Console.WriteLine("Enter the Choice to perform : ");
                int ProcessNumber = Int32.Parse(Console.ReadLine());
                switch (ProcessNumber)
                {
                    case 1:
                        ArticlesUser.DisplayArticles(id);
                        break;
                    case 2:
                        Console.WriteLine("Enter Your desired content for the Article:");
                        string article=Console.ReadLine();
                        ArticlesUser.AddArticle(id,UserName,article);
                        break;
                    case 3:
                        CybageConnectUser.KnowledgeSharing(id,UserName);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice! Please try again.");
                        break;
                }
            }
        }
        public static void UserBlogs(int id,string UserName)
        {
            while (true)
            {
                Console.WriteLine("For displaying Blogs Press 1");
                Console.WriteLine("For Adding Blogs Press 2");
                Console.WriteLine("For Going Back press 3");
                Console.WriteLine("Enter the Choice to perform : ");
                int ProcessNumber = Int32.Parse(Console.ReadLine());
                switch (ProcessNumber)
                {
                    case 1:
                        BlogsUser.DisplayBlogs(id);
                        break;
                    case 2:
                        Console.WriteLine("Enter Your desired content for the Blog:");
                        string article = Console.ReadLine();
                        BlogsUser.AddBlog(id, UserName, article);
                        break;
                    case 3:
                        CybageConnectUser.KnowledgeSharing(id, UserName);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice! Please try again.");
                        break;
                }
            }
        }
        public static void UserProjectInsights(int id,string UserName)
        {
            while (true)
            {
                Console.WriteLine("For displaying ProjectInsights Press 1");
                Console.WriteLine("For Adding ProjectInsights Press 2");
                Console.WriteLine("For Going Back press 3");
                Console.WriteLine("Enter the Choice to perform : ");
                int ProcessNumber = Int32.Parse(Console.ReadLine());
                switch (ProcessNumber)
                {
                    case 1:
                        ProjectInsightsUser.DisplayProjectInsights(id);
                        break;
                    case 2:
                        Console.WriteLine("Enter Your desired content for the ProjectInsight:");
                        string article = Console.ReadLine();
                        ProjectInsightsUser.AddProjectInsights(id, UserName, article);
                        break;
                    case 3:
                        CybageConnectUser.KnowledgeSharing(id, UserName);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice! Please try again.");
                        break;
                }
            }
        }
    }
}
