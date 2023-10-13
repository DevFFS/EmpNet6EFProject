using Microsoft.AspNetCore.Mvc;
using WebApiCoreWithEF.Models;

namespace WebApiCoreWithEF.Repositories
{
    public interface ICompanyRepository
    {
        public IEnumerable<Employee> GetEmployee();

        public Employee GetEmployeeById(int id);

        public void PostEmployee(Employee emp);

        public void PutEmployee(int id,Employee emp);

        public void DeleteEmployee(int id);
    }
}
