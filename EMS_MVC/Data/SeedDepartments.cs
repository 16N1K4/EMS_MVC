using EMS_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EMS_MVC.Data
{
    public static class SeedDepartments
    {
        public static void SeedDept(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department(1, "Administration"),
                new Department(2, "Security"),
                new Department(3, "Accounting")
                );
        }
    }
}
