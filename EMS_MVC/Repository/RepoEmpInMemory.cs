using EMS_MVC.Models;

namespace EMS_MVC.Repository
{
    public class RepoEmpInMemory : IRepoEmpInMemory
    {
        static List<Employee> employees = new List<Employee>();

        static RepoEmpInMemory()
        {
            employees.Add(new Employee(1, "Minecraft Steve", DateTime.Now, "steve@mojang.com", "09123456789", 1));
            employees.Add(new Employee(2, "Bob Builder", DateTime.Now, "bob@dpwh.gov.ph", "09876543210", 1));
            employees.Add(new Employee(3, "Ilyana Rasputin", DateTime.Now, "magik@limbo.com", "096161963", 2));
            employees.Add(new Employee(4, "Nico Minoru", DateTime.Now, "sistergrimm@aol.com", "09666666666", 2));
            employees.Add(new Employee(5, "Jason Todd", DateTime.Now, "redhood@batman.com", "09101010101", 3));
        }

        public List<Employee> ViewAllEmployees()
        {
            return employees;
        }

        public Employee ViewOneEmployee(int id)
        {
            return employees.FirstOrDefault(emp => emp.ID == id);
        }

        public Employee AddEmployee(Employee NewEmployee)
        {
            NewEmployee.ID = employees.Max(emp => emp.ID) + 1;
            employees.Add(NewEmployee);

            return NewEmployee;
        }

        public Employee UpdateEmployee(int id, Employee NewEmployee)
        {
            var OldEmployee = employees.FirstOrDefault(emp => emp.ID == id);
            if (OldEmployee != null)
            {
                employees.Remove(OldEmployee);
                employees.Add(NewEmployee);
            }

            return null;
        }

        public Employee DeleteEmployee(int id)
        {
            var OldEmployee = employees.FirstOrDefault(emp => emp.ID == id);
            if (OldEmployee != null)
            {
                employees.Remove(OldEmployee);
            }

            return null;
        }

    }
}
