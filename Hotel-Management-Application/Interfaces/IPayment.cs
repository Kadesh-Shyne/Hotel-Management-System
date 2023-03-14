using Hotel_Mgt_System.Models;

namespace Hotel_Mgt_System.Repository.Interface
{
    public interface IPayment
    {
        Task CreatePayment(Payment payment);
        Task <IEnumerable<Payment>>GetAllPayment(bool trackChanges);
        Task<Payment> GetPaymentAsync(int id, bool trackChanges);
        Task UpdatePayment(Payment payment);
        Task DeletePayment(int id);
    }
}
