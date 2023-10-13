using WebApiCoreWithEF.Context;
using WebApiCoreWithEF.Models;

namespace WebApiCoreWithEF.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private CompanyContext companyContext;

        public CompanyRepository(CompanyContext companyContext)
        {
            this.companyContext = companyContext;
        }

        public IEnumerable<Employee> GetEmployee()
        {
            return companyContext.Employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return companyContext.Employees.FirstOrDefault(s => s.EmployeeId == id);
        }

        public void PostEmployee(Employee emp)
        {
            companyContext.Employees.Add(emp);
            companyContext.SaveChanges();
        }

        public void PutEmployee(int id,Employee emp)
        {
            var employee = companyContext.Employees.FirstOrDefault(s => s.EmployeeId == id);
            if (employee != null)
            {

                companyContext.Entry<Employee>(employee).CurrentValues.SetValues(emp);
                companyContext.SaveChanges();
            }
        }

        public void DeleteEmployee(int id)
        {
            var employee=companyContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
            if(employee != null)
            {
                companyContext.Employees.Remove(employee);
                companyContext.SaveChanges();
            }


        }
    }
}
