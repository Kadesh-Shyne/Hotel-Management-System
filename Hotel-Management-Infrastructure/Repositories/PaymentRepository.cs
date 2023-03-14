using Hotel_Mgt_System.Data;
using Hotel_Mgt_System.Models;
using Hotel_Mgt_System.Repository.Interface;

namespace Hotel_Mgt_System.Repository
{
    public class PaymentRepository: IPayment
    {
        private ApplicationDbContext _context;
        public PaymentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreatePayment(Payment payment)
        {
             await _context.AddAsync(payment);
        }

        public async Task DeletePayment(int id)
        {
            await DeletePayment(id);
        }

        public async Task<IEnumerable<Payment>> GetAllPayment(Payment payment)
        {
            return await GetAllPayment(payment); 
        }

        public Task<Payment> GetPaymentById(int id)
        {
            if (id == 0)
                return null;
            return GetPaymentById(id);
        }

        public async Task UpdatePayment(Payment payment)
        {
            await _context.AddAsync(payment);
        }
    }
}
