using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerBusiness.Service;
using DockerDB.Models;
using Microsoft.AspNetCore.Mvc;

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
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Employees value)
        {
            _employeeService.AddEmployee(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
