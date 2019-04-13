using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class StandardMessages
    {
        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"{fieldName} is not valid!");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }
    }
}
