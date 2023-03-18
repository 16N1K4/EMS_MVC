using EMS_MVC.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace EMS_MVC.Data
{
    public class EMSContext : DbContext
    {
            protected override void OnConfiguring(DbContextOptionsBuilder builder)
            {
                string ConnectionString = "Server = (localdb)\\MSSQLLocalDB; Integrated Security = True;Database = EMS_DB";
                builder.UseSqlServer(ConnectionString).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                base.OnConfiguring(builder);
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Employee>()
                    .HasOne<Department>(emp => emp.Department)
                    .WithMany(dept => dept.Employees)
                    .HasForeignKey(emp => emp.DepartmentID)
                    .OnDelete(DeleteBehavior.Cascade);
                    
                modelBuilder.SeedDept();
                modelBuilder.SeedEmps();
            }

            public DbSet<Employee> Employees { get; set; }
            public DbSet<Department> Departments { get; set; }
        }
}
