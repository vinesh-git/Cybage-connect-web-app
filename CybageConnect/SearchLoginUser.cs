using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnect
{
    public class SearchLoginUser
    {
        public static CybageConnectLinqDataContext context;
        public static IEnumerable<UserRegistration> SearchForUser(string _UserName,string _Userpassword){
            context = new CybageConnectLinqDataContext();
            var details = from users in context.UserRegistrations where users.UserName == _UserName && users.UserPassword == _Userpassword select users;
            int NumberOfUsers = details.Count();
            return details.ToList();
        }
        public static int SearchForUserId(string _UserName)
        {
            using (var context = new CybageConnectLinqDataContext())
            {
                var user = (from u in context.UserRegistrations
                            where u.UserName == _UserName
                            select u.UserId).FirstOrDefault();

                if (user != null)
                {
                    return user; // No need to convert, it's already an integer
                }
                else
                {
                    return -1; // Or any default value indicating user not found
                }
            }
        }
    }
}
