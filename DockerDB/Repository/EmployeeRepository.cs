using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DockerDB.Models;

namespace DockerDB.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private e2eContext db = new e2eContext();

        public IEnumerable<Employees> GetAllEmployee()
        {
            return db.Employees.ToList();
        }
    }
}
