using CybageConnect;
using CybageConnectViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnectModels
{
    public class LoginOfUser
    {
        public static CybageConnectValidation validate;
        public static void Login()
        {
            validate = new CybageConnectValidation();
            bool status = false;
            string _UserName = "";
            while (status != true)
            {
                Console.WriteLine("Enter your UserName: ");
                string Name = Console.ReadLine();
                try
                {
                    status = validate.CheckForEmptyData(Name);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                _UserName = Name;
            }
            status = false;
            string _Userpassword = "";
            while (status != true)
            {
                Console.WriteLine("Enter your Password: ");
                string Password = Console.ReadLine();
                try
                {
                    status = validate.CheckForEmptyData(Password);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                _Userpassword = Password;
            }
            int NumberOfUser =UserLogin.FindUser(_UserName,_Userpassword);
            if (NumberOfUser == 0)
            {
                Console.WriteLine("Please provide the \"CORRECT CREDENTIALS\"");
                Login();
            }
            else
            {
                    CybageConnectUser cybageConnectUser = new CybageConnectUser(_UserName,_Userpassword);
            }
        }
    }
}
