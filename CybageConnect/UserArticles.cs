using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnect
{
    public class UserArticles
    {
        public static IEnumerable<ArticlesOfUser> GetArticles(int id)
        {
            CybageConnectLinqDataContext context = new CybageConnectLinqDataContext();
            IEnumerable<ArticlesOfUser> user = context.ArticlesOfUsers.Where(u => u.UserId == id);
            return user.ToList();
        }
        public static void AddArticle(ArticlesOfUser articlesOfUser)
        {
            CybageConnectLinqDataContext context = new CybageConnectLinqDataContext();
            context.ArticlesOfUsers.InsertOnSubmit(articlesOfUser);
            context.SubmitChanges();
        }
    }
}
