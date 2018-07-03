using DockerDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DockerDB.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employees> GetAllEmployee();
        void AddEmployee(Employees employee);
    }
}
