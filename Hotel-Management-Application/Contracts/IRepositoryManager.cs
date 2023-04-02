

using Hotel_Management_Service.Contract;
using Hotel_Mgt_System.Repository.Interface;

namespace Hotel_Management_Application.Contracts
{
    public interface IRepositoryManager
    {
        IBookings bookings { get; }
        ICustomerDetails customers { get; } 
        IEmployee employee { get; } 
        IHostel hostel { get; } 
        IPayment payment { get; }   
        IRoom room { get; }
        IAuthenticationService AuthenticationService { get; }
        Task SaveAsync();
    }
}
