using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.User_Logins
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> usersList = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "login")
            {
              
                string[] tokens = input.Split(' ');
                var user = tokens[0];
                var password = tokens[2];

                if (!usersList.ContainsKey(user))
                {
                    usersList.Add(user, password);
                }
                else
                {
                    usersList[user] = password;
                }
                

                input = Console.ReadLine();
            }

            string logins = Console.ReadLine();
            int failedLoginsCounter = 0;

            while (true)
            {
                if (logins=="end")
                {
                    break;
                }
                string[] tokens = logins.Split(' ');
                var username = tokens[0];
                var password = tokens[2];

                if (usersList.ContainsKey(username) && usersList.ContainsValue(password))
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }
                else
                {
                    Console.WriteLine($"{username}: login failed");
                    failedLoginsCounter++;
                }

                logins = Console.ReadLine();
            }
            Console.WriteLine($"unsuccessful login attempts: {failedLoginsCounter}");
        }
    }
}
