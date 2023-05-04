using Lab6.Components;

namespace Lab6.Visitors
{
    public interface IVisitor
    {
        string VisitEmployee(Employee employee);

        string VisitDepartment(Department department);

        string VisitCompany(Company company);
    }
}
