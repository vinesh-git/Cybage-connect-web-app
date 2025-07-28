using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnect
{
    public class UserDal
    {
        private readonly CybageConnectLinqDataContext dataContext;
        public UserDal()
        {
            dataContext = new CybageConnectLinqDataContext();
        }

        public void UpdateUsername(int id,string newUsername)
        {
            UserRegistration user = dataContext.UserRegistrations.FirstOrDefault(u => u.UserId == id);
            if (user != null)
            {
                user.UserName = newUsername;
                dataContext.SubmitChanges();
            }
        }

        public void UpdatePhoneNumber(int id,long newPhoneNumber)
        {
            UserRegistration user = dataContext.UserRegistrations.FirstOrDefault(u => u.UserId == id);
            if (user != null)
            {
                user.MobileNumber = newPhoneNumber;
                dataContext.SubmitChanges();
            }
        }

        public void UpdateEmailAddress(int id,string newEmailAddress)
        {
            UserRegistration user = dataContext.UserRegistrations.FirstOrDefault(u => u.UserId == id);
            if (user != null)
            {
                user.Email = newEmailAddress;
                dataContext.SubmitChanges();
            }
        }
        public List<UserRegistration> SearchUsers(int userId, string SearchedName)
        {

            return dataContext.UserRegistrations.Where(u => u.UserId != userId && u.UserName==SearchedName).ToList();
        }
    }
}
