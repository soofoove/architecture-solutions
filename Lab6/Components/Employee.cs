using Lab6.Visitors;

namespace Lab6.Components
{
    public class Employee : IVisitable
    {
        public string JobName { get; private set; }

        public string SalaryInfo { get; private set; }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitEmployee(this);
        }

        public Employee(string jobName, string salaryInfo)
        {
            JobName = jobName;
            SalaryInfo = salaryInfo;
        }
    }
}
