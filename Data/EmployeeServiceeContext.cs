using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeServicee.Models;

namespace EmployeeServicee.Data
{
    public class EmployeeServiceeContext : DbContext
    {
        public EmployeeServiceeContext (DbContextOptions<EmployeeServiceeContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeServicee.Models.Employee> Employee { get; set; }
    }
}
