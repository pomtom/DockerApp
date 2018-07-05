using DockerDB.Models;
using DockerDB.Repository;
using System.Collections.Generic;

namespace DockerBusiness.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        public void AddEmployee(Employees employee)
        {
            _employeeRepository.AddEmployee(employee);
        }

        public void DeleteEmployee(int id)
        {
            _employeeRepository.DeleteEmployee(id);
        }

        public IEnumerable<Employees> GetAllEmployee()
        {
            return _employeeRepository.GetAllEmployee();
        }

        public Employees GetEmployeeById(int id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }

        public void UpdateEmployee(int id, Employees employee)
        {
            _employeeRepository.UpdateEmployee(id, employee);
        }
    }
}
