using Hotel_Management_System.Models;

namespace Hotel_Mgt_System.Repository.Interface
{
    public interface IEmployee
    {      
        Task<Employee> GetEmployeeAsync(int id, bool trackChanges);
        Task<IEnumerable<Employee>> GetAllEmployee(bool trackChanges);
        Task DeleteEmployee(Employee employee);
        Task UpdateNewEmployee(Employee employee);  

    }
}
