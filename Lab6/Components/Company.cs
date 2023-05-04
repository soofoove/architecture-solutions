using Lab6.Visitors;

namespace Lab6.Components
{
    public class Company : IVisitable
    {
        public string Name { get; private set; }

        public List<Department> Departaments { get; private set; }

        public string Accept(IVisitor visitor)
        {
            return visitor.VisitCompany(this);
        }

        public Company(string name, List<Department> departaments)
        {
            Name = name;
            Departaments = departaments;
        }
    }
}
