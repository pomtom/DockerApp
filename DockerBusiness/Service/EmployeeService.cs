using System;
using System.Collections.Generic;
using System.Text;
using DockerDB.Models;
using DockerDB.Repository;

namespace DockerBusiness.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }
        public IEnumerable<Employees> GetAllEmployee()
        {
            return _employeeRepository.GetAllEmployee();
        }
    }
}
