using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using CybageConnectModels;

namespace CybageConnectViews
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CybageConnectMainMenu();
        }
        public static void CybageConnectMainMenu()
        {
            while (true)
            {
                Console.WriteLine("For Register Press 1");
                Console.WriteLine("For Login Press 2");
                Console.WriteLine("For Exit Press 3");
                Console.WriteLine("Enter the Choice to perform : ");
                int ProcessNumber = Int32.Parse(Console.ReadLine());
                switch (ProcessNumber)
                {
                    case 1:
                        RegistrationOfUser.Registration();
                        break;
                    case 2:
                        LoginOfUser.Login();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice! Please try again.");
                        break;
                }
            }
        }
    }
}
