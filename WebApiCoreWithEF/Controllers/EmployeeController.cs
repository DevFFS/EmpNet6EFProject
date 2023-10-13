using Microsoft.AspNetCore.Mvc;
using WebApiCoreWithEF.Context;
using WebApiCoreWithEF.Models;
using WebApiCoreWithEF.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiCoreWithEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private ICompanyRepository iCompanyRepository;       

        public EmployeeController(ICompanyRepository iCompanyRepository)
        {
            this.iCompanyRepository = iCompanyRepository;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()

        {
            return iCompanyRepository.GetEmployee();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id) 
        {
            return iCompanyRepository.GetEmployeeById(id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee value)
        {
             iCompanyRepository.PostEmployee(value);
        }
        

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee Value)
        { 
            iCompanyRepository.PutEmployee(id, Value);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            iCompanyRepository.DeleteEmployee(id);
        }
    }
}
