using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnect
{
    public class UserBlogs
    {
        public static IEnumerable<BlogsOfUser> GetBlogs(int id)
        {
            CybageConnectLinqDataContext context = new CybageConnectLinqDataContext();
            IEnumerable<BlogsOfUser> user = context.BlogsOfUsers.Where(u => u.UserId == id);
            return user.ToList();
        }
        public static void AddBlog(BlogsOfUser blogsOfUser)
        {
            CybageConnectLinqDataContext context = new CybageConnectLinqDataContext();
            context.BlogsOfUsers.InsertOnSubmit(blogsOfUser);
            context.SubmitChanges();
        }
    }
}
