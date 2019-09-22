using System;

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
