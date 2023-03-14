using Hotel_Management_System.Models;

namespace Hotel_Mgt_System.Repository.Interface
{
    public interface ICustomerDetails
    {
        Task CreateNewCustomer(CustomerDetails customerDetails);   
        Task<IEnumerable<CustomerDetails>> GetAllCustomers();
        Task<CustomerDetails> GetCustomerById(int id);
        Task DeleteCustomer(int id);
    }
}
