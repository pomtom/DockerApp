using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DockerMVC.Models
{
    public class DockerMVCContext : DbContext
    {
        public DockerMVCContext (DbContextOptions<DockerMVCContext> options)
            : base(options)
        {
        }

        public DbSet<DockerMVC.Models.Employee> Employee { get; set; }
    }
}
