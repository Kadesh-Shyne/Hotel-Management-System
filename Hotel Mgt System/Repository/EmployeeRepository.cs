using Hotel_Management_System.Models;
using Hotel_Mgt_System.Data;
using Hotel_Mgt_System.Repository.Interface;


namespace Hotel_Mgt_System.Repository
{
    public class EmployeeRepository : IEmployee
    {
        private ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task DeleteEmployee(Employee employee)
        {
            await DeleteEmployee(employee);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployee(Employee employee)
        {   
            return await GetAllEmployee(employee);
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            if (id == 0)
                return null;
          return  await GetEmployeeById(id);
        }

        public async Task UpdateNewEmployee(Employee employee)
        {
            await _context.SaveChangesAsync();
        }
    }
}
