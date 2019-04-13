using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class AccountGenerator
    {
        public static void CreateAccount(UserAccount userAccount)
        {
            Console.WriteLine($"Your username is {userAccount.FirstName.Substring(0, 1).ToLower()}{userAccount.LastName.ToLower()}");
        }
    }
}
