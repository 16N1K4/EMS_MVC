using EMS_MVC.Models;

namespace EMS_MVC.Repository
{
    public interface IRepoEmpInMemory
    {
        public List<Employee> ViewAllEmployees();
        public Employee ViewOneEmployee(int id);
        public Employee AddEmployee(Employee NewEmployee);
        public Employee UpdateEmployee(int id, Employee NewEmployee);
        public Employee DeleteEmployee(int id);
    }
}
