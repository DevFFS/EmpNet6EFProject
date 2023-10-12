using Microsoft.AspNetCore.Mvc;
using WebApiCoreWithEF.Context;
using WebApiCoreWithEF.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiCoreWithEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private CompanyContext _companyContext;       

            public EmployeeController(CompanyContext companyContext)
        {
            _companyContext = companyContext;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()

        {
            return _companyContext.Employees;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id) 
        {
            return _companyContext.Employees.FirstOrDefault(s => s.EmployeeId == id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee value)
            {
                _companyContext.Employees.Add(value);
                _companyContext.SaveChanges();
            }
        

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee Value)
        { 
            var employee = _companyContext.Employees.FirstOrDefault( s => s.EmployeeId == id);
            if (employee != null)
            {

                _companyContext.Entry<Employee>(employee).CurrentValues.SetValues(Value);
                _companyContext.SaveChanges();
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var student =_companyContext.Employees.FirstOrDefault(s=> s.EmployeeId ==id);
            if (student != null)
            {
                _companyContext.Employees.Remove(student);
                _companyContext.SaveChanges();
            }
        }
    }
}
