using CybageConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnectModels
{
    public class ArticlesUser
    {
        public static void DisplayArticles(int id)
        {
            IEnumerable<ArticlesOfUser> articlesOfUsers = UserArticles.GetArticles(id);
            foreach (var article in articlesOfUsers)
            {
                Console.WriteLine($"Article ID: {article.ArticleId},Article: {article.Article}, PublishedDate: {article.PublishedDate}");
            }
        }
        public static void AddArticle(int id,string UserName,string article)
        {
            ArticlesOfUser articlesOfUser=new ArticlesOfUser()
            {
                UserId= id,
                UserName= UserName,
                Article= article,
                PublishedDate= DateTime.Now,
            };
            UserArticles.AddArticle(articlesOfUser);
        }
    }
}
