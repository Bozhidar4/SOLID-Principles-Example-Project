namespace OpenClosePrinciple
{
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1).ToLower()}{person.LastName.ToLower()}@test.com";

            output.IsManager = true;

            return output;
        }
    }
}
