using CybageConnectModels;
using CybageConnectViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnect
{
    public class CybageConnectUser
    {
        public static void PersonalInformation(int id,string Username)
        {
            UserLogin.GetUserDetails(id,Username);
            while (true)
            {
                Console.WriteLine("1. Edit Username");
                Console.WriteLine("2. Edit Mobile Number");
                Console.WriteLine("3. Edit Email");
                Console.WriteLine("4. Go back ");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter new username: ");
                        UserLogin.Username(id);
                        break;
                    case 2:
                        Console.Write("Enter new phone number: ");
                        UserLogin.PhoneNumber(id);
                        break;
                    case 3:
                        Console.Write("Enter new email: ");
                        UserLogin.Email(id);
                        break;

                    case 4:
                        UserLoginMenu(id,Username);
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

        }
        public static void NetWorking(int id,string UserName)
        {
            while (true)
            {
                Console.WriteLine("For Users Search Press 1");
                Console.WriteLine("For Notifications Press 2");
                Console.WriteLine("For Go Back press 3");
                Console.WriteLine("Enter the Choice to perform : ");
                int ProcessNumber = Int32.Parse(Console.ReadLine());
                switch (ProcessNumber)
                {
                    case 1:
                        Console.WriteLine("Enter UserName to be Search: ");
                        SearchFunctionForUser.SearchUsers(id, UserName);
                        break;
                    case 2:
                        SearchFunctionForUser.Notification(id);
                        break;
                    case 3:
                        UserLoginMenu(id, UserName);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice! Please try again.");
                        break;
                }
            }
        }
        public static void KnowledgeSharing(int id,string UserName)
        {
            while (true)
            {
                Console.WriteLine("For Articles Press 1");
                Console.WriteLine("For Blogs Press 2");
                Console.WriteLine("For ProjectInsights Press 3");
                Console.WriteLine("For LoginMenu press 4");
                Console.WriteLine("Enter the Choice to perform : ");
                int ProcessNumber = Int32.Parse(Console.ReadLine());
                switch (ProcessNumber)
                {
                    case 1:
                        KnowledgeSharingOfUser.UserArticles(id,UserName);
                        break;
                    case 2:
                        KnowledgeSharingOfUser.UserBlogs(id,UserName);
                        break;
                    case 3:
                        KnowledgeSharingOfUser.UserProjectInsights(id,UserName);
                        break;
                    case 4:
                        UserLoginMenu(id, UserName);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice! Please try again.");
                        break;
                }
            }
        }
        public CybageConnectUser(string UserName, string Password)
        {
            Console.WriteLine($"Hi \"{UserName}\" WelCome to Cybage Connect!");
            //bool IsloggedIn = true;
            int id = UserLogin.GetIdOfUser(UserName);
            UserLoginMenu(id, UserName);

        }
        public static void UserLoginMenu(int id, string UserName)
        {
            while (true)
            {
                Console.WriteLine("For Personal Information Press 1");
                Console.WriteLine("For NetWorking Press 2");
                Console.WriteLine("For KnowledgeSharing Press 3");
                Console.WriteLine("For Logout press 4");
                Console.WriteLine("Enter the Choice to perform : ");
                int ProcessNumber = Int32.Parse(Console.ReadLine());
                switch (ProcessNumber)
                {
                    case 1:
                        PersonalInformation(id, UserName);
                        break;
                    case 2:
                        NetWorking(id,UserName);
                        break;
                    case 3:
                        KnowledgeSharing(id,UserName);
                        break;
                    case 4:
                        Program.CybageConnectMainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice! Please try again.");
                        break;
                }
            }
        }
    }
}

