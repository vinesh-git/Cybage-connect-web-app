using CybageConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybageConnectModels
{
    public class RegistrationOfUser
    {
        public static CybageConnectValidation validate;
        public static void Registration()
        {
            validate = new CybageConnectValidation();
            bool status = false;
            string _FullName = "";
            while (status != true)
            {
                Console.WriteLine("Enter your FullName: ");
                string Name = Console.ReadLine();
                try
                {
                    status = validate.CheckForEmptyData(Name);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                _FullName = Name;
            }
            status = false;
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
            Console.WriteLine("Enter your Email: ");
            string _Email = Console.ReadLine();
            status = false;
            long _MobileNumber = 0;
            while (status != true)
            {
                Console.WriteLine("Enter your MobileNumber: ");
                long Number = long.Parse(Console.ReadLine());
                try
                {
                    status = validate.CheckForMobileNumber(Number);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                _MobileNumber = Number;
            }
            UserRegister.addUsertoDb(_FullName, _UserName,_Userpassword, _Email,_MobileNumber);
            LoginOfUser.Login();
        }
    }
}
