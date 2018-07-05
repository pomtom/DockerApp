using DockerBusiness.Service;
using DockerDB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DockerApp.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public ValuesController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        [HttpGet]
        public IEnumerable<Employees> Get()
        {
            var employees = _employeeService.GetAllEmployee();
            return employees.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Employees Get(int id)
        {
            return _employeeService.GetEmployeeById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Employees value)
        {
            _employeeService.AddEmployee(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Employees employees)
        {
            _employeeService.UpdateEmployee(id, employees);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeService.DeleteEmployee(id);
        }
    }
}
