using DockerDB.Models;
using System.Collections.Generic;

namespace DockerBusiness.Service
{
    public interface IEmployeeService
    {
        IEnumerable<Employees> GetAllEmployee();
        void AddEmployee(Employees employee);
        Employees GetEmployeeById(int id);
        void UpdateEmployee(int id, Employees employee);
        void DeleteEmployee(int id);
    }
}
