using DockerDB.Models;
using System.Collections.Generic;
using System.Linq;

namespace DockerDB.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private e2eContext db = new e2eContext();

        public IEnumerable<Employees> GetAllEmployee()
        {
            return db.Employees.ToList();
        }

        public void AddEmployee(Employees employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        public Employees GetEmployeeById(int id)
        {
            return db.Employees.FirstOrDefault(a => a.Id == id);
        }

        public void UpdateEmployee(int id, Employees employee)
        {
            Employees emp = GetEmployeeById(id);
            emp.Date = employee.Date;
            emp.Name = employee.Name;
            emp.Photo = employee.Photo;
            emp.Email = employee.Email;
            db.Entry(emp).CurrentValues.SetValues(emp);
            db.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            Employees emp = GetEmployeeById(id);
            db.Employees.Remove(emp);
        }


    }
}
