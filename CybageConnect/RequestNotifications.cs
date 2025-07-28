using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnect
{
    public class RequestNotifications
    {
        public static void Accepts(int userId,int sender)
        {
            CybageConnectLinqDataContext context = new CybageConnectLinqDataContext();
            context.OnAccept(userId, sender);
        }
        public static void Delete(int userId, int sender)
        {
            CybageConnectLinqDataContext context = new CybageConnectLinqDataContext();
            context.Ondelete(userId, sender);
        }
    }
}
