using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnect
{
    public class RequestToUser
    {
        public static void Request(int RequestFrom,int requestTo,string Username)
        {
            CybageConnectLinqDataContext context = new CybageConnectLinqDataContext();
            context.SendRequest(RequestFrom, requestTo);
            Console.WriteLine("Requested added Successfull");
        }
        public static IEnumerable<FriendRequest> SearchRequests(int userId)
        {
            CybageConnectLinqDataContext context = new CybageConnectLinqDataContext();
            var notification = from friends in context.FriendRequests where friends.ReceiverId == userId select friends;
            return notification.ToList();
        }
    }
}
