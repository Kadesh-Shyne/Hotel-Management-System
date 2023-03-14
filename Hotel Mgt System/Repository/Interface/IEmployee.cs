using Hotel_Management_System.Models;

namespace Hotel_Mgt_System.Repository.Interface
{
    public interface IEmployee
    {      
        Task<Employee> GetEmployeeById(int id);
        Task<IEnumerable<Employee>> GetAllEmployee(Employee employee);
        Task DeleteEmployee(Employee employee);
        Task UpdateNewEmployee(Employee employee);  

    }
}
