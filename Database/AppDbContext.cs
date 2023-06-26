using FirstApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstApp.Database
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payroll>? Payroll { get; set; }

    }
}
