using System;
using System.Collections.Generic;

namespace DockerDB.Models
{
    public partial class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public byte[] Photo { get; set; }
        public int? DepartmentId { get; set; }
        public int? ProductsId { get; set; }

        public Departments Department { get; set; }
        public Products Products { get; set; }
    }
}
