using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-K6U80KT\\BMK;database=DenemeApiDb; integrated security=true;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
