using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnect
{
    public class FindUserForPeronalInformation
    {
        
        public static UserRegistration FindUser(int id)
        {
            CybageConnectLinqDataContext context=new CybageConnectLinqDataContext();
            UserRegistration user=context.UserRegistrations.FirstOrDefault(u => u.UserId == id);
            return user;
        }
    }
}
