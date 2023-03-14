using Hotel_Management_System.Models;

namespace Hotel_Mgt_System.Repository.Interface
{
    public interface IBookings
    {
      
      
        Task<IEnumerable<Bookings>> GetAllBookings(Bookings bookings);
        Task<Bookings>GetBooksById(int id);
        Task DeleteBook(int id);
        Task UpdateBook(Bookings bookings);
    }
}
