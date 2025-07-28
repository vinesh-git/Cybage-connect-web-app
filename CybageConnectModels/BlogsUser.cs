using CybageConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnectModels
{
    public class BlogsUser
    {
        public static void DisplayBlogs(int id)
        {
            IEnumerable<BlogsOfUser> blogsOfUsers = UserBlogs.GetBlogs(id);
            foreach (var blog in blogsOfUsers)
            {
                Console.WriteLine($"Blog ID: {blog.BlogId},Blog: {blog.Blog}, PublishedDate: {blog.PublishedDateOfBLog}");
            }
        }
        public static void AddBlog(int id, string UserName, string blog)
        {
            BlogsOfUser blogsOfUser = new BlogsOfUser()
            {
                UserId = id,
                UserName = UserName,
                Blog = blog,
                PublishedDateOfBLog = DateTime.Now,
            };
            UserBlogs.AddBlog(blogsOfUser);
        }
    }
}
