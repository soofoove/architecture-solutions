using Lab6.Components;

namespace Lab6.Visitors
{
    public class SalaryReportVisitor : IVisitor
    {
        public string VisitCompany(Company company)
        {
            var report = company.Name + Environment.NewLine;

            for (var i = 0; i < company.Departaments.Count; i++)
            {
                report += $"{i + 1}. {VisitDepartment(company.Departaments[i])}";
            }

            return report;
        }

        public string VisitDepartment(Department department)
        {
            var report = department.Name + Environment.NewLine;

            for(var i = 0; i < department.Employees.Count; i++)
            {
                report += $"    {i + 1} {VisitEmployee(department.Employees[i])}";
            }

            return report;
        }

        public string VisitEmployee(Employee employee)
        {
            return $"{employee.JobName}: {employee.SalaryInfo}" + Environment.NewLine;
        }
    }
}
