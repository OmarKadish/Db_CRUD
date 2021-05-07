using System.Collections.Generic;
using FackDataBaseCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace FackDataBaseCRUD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}