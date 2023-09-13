using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcDepartment.Models;

namespace MvcDepartment.Data
{
    public class MvcDepartmentContext : DbContext
    {
        public MvcDepartmentContext (DbContextOptions<MvcDepartmentContext> options)
            : base(options)
        {
        }

        public DbSet<MvcDepartment.Models.Department> Department { get; set; } = default!;
    }
}
