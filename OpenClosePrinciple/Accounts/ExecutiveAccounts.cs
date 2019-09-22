namespace OpenClosePrinciple
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress = $"{person.FirstName.Substring(0, 1).ToLower()}{person.LastName.ToLower()}@test.com",

                IsManager = true,
                IsExecutive = true
            };

            return output;
        }
    }
}
