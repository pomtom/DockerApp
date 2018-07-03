using DockerDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DockerBusiness.Service
{
    public interface IEmployeeService
    {
        IEnumerable<Employees> GetAllEmployee();
    }
}
