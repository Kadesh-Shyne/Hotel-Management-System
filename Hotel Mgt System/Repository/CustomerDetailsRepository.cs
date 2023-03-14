using Hotel_Management_System.Models;
using Hotel_Mgt_System.Data;
using Hotel_Mgt_System.Repository.Interface;

namespace Hotel_Mgt_System.Repository
{
    public class CustomerDetailsRepository : ICustomerDetails
    {
        private ApplicationDbContext _applicationDbContext;
        public CustomerDetailsRepository(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }
        public async Task CreateNewCustomer(CustomerDetails customerDetails)
        {
            await _applicationDbContext.AddAsync(customerDetails);  
        }

        public async Task DeleteCustomer(int id)
        {
             await DeleteCustomer(id);
        }

        public Task<IEnumerable<CustomerDetails>> GetAllCustomers()
        {
            return GetAllCustomers();
        }

        public async Task<CustomerDetails> GetCustomerById(int id)
        {
            if (id == 0)
                return null;
            return await GetCustomerById(id);
        }
    }
}
