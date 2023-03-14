using Hotel_Management_System.Models;

namespace Hotel_Mgt_System.Repository.Interface
{
    public interface IBookings
    {
      
      
        Task<IEnumerable<Bookings>> GetAllBookings(bool trackChanges);
        Task<Bookings>GetBooksAsync(int id, bool trackChanges);
        Task DeleteBook(int id);
        Task UpdateBook(Bookings bookings);
    }
}
