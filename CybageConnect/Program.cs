using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnect
{
    public class Program
    {
        public static void Main() { }
        public static CybageConnectLinqDataContext context;
        
        public static void RegistrationSuccess(string _FullName, string _UserName, string _Userpassword, string _Email, long _MobileNumber)
        {
            context = new CybageConnectLinqDataContext();
            UserRegistration userRegistration = new UserRegistration()
            {
                FullName = _FullName,
                UserName = _UserName,
                UserPassword = _Userpassword,
                Email = _Email,
                MobileNumber = _MobileNumber
            };
            context.UserRegistrations.InsertOnSubmit(userRegistration);
            context.SubmitChanges();
            Console.WriteLine("Registration Success");
            
        }
    }
}
