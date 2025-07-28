using CybageConnect;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnectModels
{
    public class SearchFunctionForUser
    {
        public static void SearchUsers(int userId,string Username)
        {
            UserDal userDAL=new UserDal();
            string SearchedName = Console.ReadLine();
            List<UserRegistration> searchedUsers = userDAL.SearchUsers(userId, SearchedName);
            if (searchedUsers.Count > 0)
            {
                Console.WriteLine("Users Name " + SearchedName);
                for (int i = 0; i < searchedUsers.Count; i++)
                {
                    Console.WriteLine((i + 1) + "." + (searchedUsers[i].UserName));
                }

                Console.WriteLine("Enter the index of the name you want to view\"The Index starts with 1\":");
                int selectedIndex = Convert.ToInt32(Console.ReadLine());

                if (selectedIndex > 0 && selectedIndex <= searchedUsers.Count)
                {
                    Console.WriteLine($"Selected User: {searchedUsers[selectedIndex - 1].UserName}\tEmail: {searchedUsers[selectedIndex-1].Email}");
                    int RequistToId = searchedUsers[selectedIndex - 1].UserId;
                    Console.WriteLine("For Send Resquest Press 1");
                    int number=Int32.Parse(Console.ReadLine());
                    if (number == 1) {
                        RequestToUser.Request(userId, RequistToId,Username);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid index. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("No users found with the Searched name: " + SearchedName);
            }
        }
        public static void Notification(int userId)
        {
            IEnumerable<FriendRequest> friendrequests = RequestToUser.SearchRequests(userId);
            foreach (FriendRequest friendrequest in friendrequests)
            {
                Console.WriteLine("SenderId: {0}\t{1}\t", friendrequest.senderID, friendrequest.RqstMessage);

            }
            
            foreach (FriendRequest friendrequest in friendrequests)
            {
                Console.WriteLine("Choose to Accept/Decline enter 1/2");
                int sender = Convert.ToInt32(friendrequest.senderID);
                Console.WriteLine("SenderId: {0}\t{1}\t", friendrequest.senderID, friendrequest.RqstMessage);
                Console.WriteLine("Enter the Choice");
                int choice=Int32.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    RequestNotifications.Accepts(userId, sender);
                    Console.WriteLine("Connection Accepted Successfully");
                }
                else if(choice==2)
                {
                    RequestNotifications.Delete(userId, sender);
                    Console.WriteLine("Connection Deleted Successfully");
                }
                else
                {
                    Console.WriteLine("The Connection Neither Accepted nor Declined");
                }
            }
        }
    }
}
