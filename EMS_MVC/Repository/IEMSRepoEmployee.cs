using EMS_MVC.Models;

namespace EMS_MVC.Repository
{
    public interface IEMSRepoEmployee
    {
        List<Employee> ViewAllEmployees();

        Employee ViewOneEmployee(int id);

        Employee AddEmployee(Employee NewEmployee);

        Employee UpdateEmployee(Employee NewEmployee);

        Employee DeleteEmployee(int id);

        List<Department> FetchDepartmentList();

    }
}
