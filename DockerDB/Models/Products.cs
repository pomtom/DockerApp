using System;
using System.Collections.Generic;

namespace DockerDB.Models
{
    public partial class Products
    {
        public Products()
        {
            Employees = new HashSet<Employees>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }

        public ICollection<Employees> Employees { get; set; }
    }
}
