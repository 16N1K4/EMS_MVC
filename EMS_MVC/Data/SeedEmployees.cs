using EMS_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EMS_MVC.Data
{
    public static class SeedEmployees
    {
        public static void SeedEmps(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee(1, "Minecraft Steve", DateTime.Now, "steve@mojang.com", "09123456789", 1),
                new Employee(2, "Bob Builder", DateTime.Now, "bob@dpwh.gov.ph", "09876543210", 1),
                new Employee(3, "Ilyana Rasputin", DateTime.Now, "magik@limbo.com", "096161963", 2),
                new Employee(4, "Nico Minoru", DateTime.Now, "sistergrimm@aol.com", "09666666666", 2),
                new Employee(5, "Jason Todd", DateTime.Now, "redhood@batman.com", "09101010101", 3)
                );
        }
    }
}
