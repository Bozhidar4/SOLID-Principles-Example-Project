using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            UserAccount userAccount = UserAccountDataCapture.CaptureFirstName();
            userAccount = UserAccountDataCapture.CaptureLastName();

            bool isUserAccountValid = UserAccountValidator.Validate(userAccount);

            if (!isUserAccountValid)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.CreateAccount(userAccount);
            StandardMessages.EndApplication();
        }
    }
}
