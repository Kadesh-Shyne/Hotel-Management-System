using Hotel_Management_System.Models;
using Hotel_Mgt_System.Data;
using Hotel_Mgt_System.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Mgt_System.Repository
{
    public class BookingsRepository : IBookings
    {
        private BookingsRepository _bookingsRepository;
        public BookingsRepository(BookingsRepository bookingsRepository)
        {
            _bookingsRepository = bookingsRepository;
        }

        public async Task<IEnumerable<Bookings>> GetAllBookings(Bookings bookings)
        {
            return await _bookingsRepository.GetAllBookings(bookings);
        }

        public async Task<Bookings> GetBooksById(int id)
        {
            if (id == 0)
                return null;
            return await _bookingsRepository.GetBooksById(id);
        }

        public async Task DeleteBook(int id)
        {
             await _bookingsRepository.DeleteBook(id);
        }

        public Task UpdateBook(Bookings bookings)
        {
            return _bookingsRepository.UpdateBook(bookings);
        }
    }
}
