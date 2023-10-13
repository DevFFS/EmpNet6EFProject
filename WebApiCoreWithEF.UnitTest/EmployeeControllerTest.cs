using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebApiCoreWithEF.Controllers;
using WebApiCoreWithEF.Models;
using WebApiCoreWithEF.Repositories;

namespace WebApiCoreWithEF.UnitTest
{
    [TestClass]
    public class EmployeeControllerTest
    {
        [TestMethod]
        public void Get()
        {
            var mockICompanyrepository = new Mock<ICompanyRepository>();
            Employee emp=new Employee() { EmployeeName="farheen",EmployeeId=1,DateOfBirth="20aug1998",PINCode=18373,Gender="F",PermanentAddress="hyd",CurrentAddress="balaji nagar",City="kurnool"};
            List<Employee> employees=new List<Employee>();
            employees.Add(emp);

            mockICompanyrepository.Setup(s => s.GetEmployee()).Returns(employees);
            EmployeeController empController=new EmployeeController(mockICompanyrepository.Object);
            IEnumerable<Employee> returnedData=  empController.Get();
            Assert.IsNotNull(returnedData.Any());

        }
    }
}