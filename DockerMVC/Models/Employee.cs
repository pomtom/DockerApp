using System;

namespace DockerMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public byte[] Photo { get; set; }
    }
}
