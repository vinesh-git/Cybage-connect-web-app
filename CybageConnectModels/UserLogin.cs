using CybageConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnectModels
{
    public class UserLogin
    {
        public static int FindUser(string _UserName, string _Userpassword)
        {
            IEnumerable<UserRegistration> details = SearchLoginUser.SearchForUser(_UserName, _Userpassword);
            return details.Count();
        }
        public static int GetIdOfUser(string UserName)
        {
            int id = SearchLoginUser.SearchForUserId(UserName);
            return id;
        }
        
        public static void GetUserDetails(int id, string UserName)
        {
            UserRegistration user = FindUserForPeronalInformation.FindUser(id);
            
            if (user != null)
            {
                Console.WriteLine($"Profile Information for User {user.FullName}:");
                Console.WriteLine($"Username: {user.UserName}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine($"Phone Number: {user.MobileNumber}");
            }
        }
        public static void Username(int id){
            UserDal userDAL = new UserDal();
            string newUsername = Console.ReadLine();
            userDAL.UpdateUsername(id, newUsername);
        }
        public static void PhoneNumber(int id)
        {
            UserDal userDAL = new UserDal();
            long newPhoneNumber = long.Parse(Console.ReadLine());
            userDAL.UpdatePhoneNumber(id, newPhoneNumber);
        }
        public static void Email(int id)
        {
            UserDal userDAL = new UserDal();
            string newEmailAddress = Console.ReadLine();
            userDAL.UpdateEmailAddress(id, newEmailAddress);
        }
    }
}
