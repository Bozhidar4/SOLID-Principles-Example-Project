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
