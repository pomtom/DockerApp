using DockerDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DockerDB.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employees> GetAllEmployee();
        Employees GetEmployeeById(int id);
        void AddEmployee(Employees employee);
        void UpdateEmployee(int id, Employees employee);
        void DeleteEmployee(int id);
    }
}
