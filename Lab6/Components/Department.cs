using Lab6.Visitors;

namespace Lab6.Components
{
    public class Department : IVisitable
    {
        public string Name { get; private set; }

        public List<Employee> Employees { get; private set; }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitDepartment(this);
        }

        public Department(string name, List<Employee> employees)
        {
            Name = name;
            Employees = employees;
        }
    }
}
