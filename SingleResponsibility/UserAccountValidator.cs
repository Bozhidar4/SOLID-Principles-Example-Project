namespace SingleResponsibility
{
    public class UserAccountValidator
    {
        public static bool Validate(UserAccount userAccount)
        {
            bool isValid;
            if (string.IsNullOrWhiteSpace(userAccount.FirstName))
            {
                StandardMessages.DisplayValidationError("First name");
                UserAccountDataCapture.CaptureFirstName();
                isValid = string.IsNullOrWhiteSpace(userAccount.FirstName) ? false : true;
            }
            if (string.IsNullOrWhiteSpace(userAccount.LastName))
            {
                StandardMessages.DisplayValidationError("Last name");
                UserAccountDataCapture.CaptureLastName();
                isValid = string.IsNullOrWhiteSpace(userAccount.LastName) ? false : true;
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
