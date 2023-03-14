using Hotel_Mgt_System.Models;

namespace Hotel_Mgt_System.Repository.Interface
{
    public interface IPayment
    {
        Task CreatePayment(Payment payment);
        Task <IEnumerable<Payment>>GetAllPayment(Payment payment);
        Task<Payment> GetPaymentById(int id);
        Task UpdatePayment(Payment payment);
        Task DeletePayment(int id);
    }
}
