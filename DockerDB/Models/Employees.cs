using System;

namespace DockerDB.Models
{
    public partial class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}
