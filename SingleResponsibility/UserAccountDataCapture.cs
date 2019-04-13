using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class UserAccountDataCapture
    {
        static UserAccount output = new UserAccount();

        public static UserAccount CaptureFirstName()
        {
            Console.WriteLine("Please enter your first name...");
            output.FirstName = Console.ReadLine();

            return output;
        }

        public static UserAccount CaptureLastName()
        {
            Console.WriteLine("Please enter your last name...");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
