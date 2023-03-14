using Hotel_Management_System.Models;

namespace Hotel_Mgt_System.Repository.Interface
{
    public interface ICustomerDetails
    {
        Task CreateNewCustomer(CustomerDetails customerDetails);   
        Task<IEnumerable<CustomerDetails>> GetAllCustomers(bool trackChanges);
        Task<CustomerDetails> GetCustomerAsync(int id, bool trackChanges);
        Task DeleteCustomer(int id);
    }
}
