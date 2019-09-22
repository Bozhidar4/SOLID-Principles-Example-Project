using System;

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
