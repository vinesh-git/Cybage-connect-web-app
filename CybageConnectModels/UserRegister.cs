using CybageConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnectModels
{

    public class UserRegister
    {
        public static void Main() { }
        public static void addUsertoDb(string _FullName,string _UserName,string _Userpassword,string _Email,long _MobileNumber)
        {
            Program.RegistrationSuccess(_FullName, _UserName, _Userpassword, _Email,_MobileNumber);
        }
    }
}
