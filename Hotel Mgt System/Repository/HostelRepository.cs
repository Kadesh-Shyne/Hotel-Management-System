using Hotel_Management_System.Models;
using Hotel_Mgt_System.Data;
using Hotel_Mgt_System.Repository.Interface;

namespace Hotel_Mgt_System.Repository
{
    public class HostelRepository : IHostel
    {
        private ApplicationDbContext _context;
        public HostelRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task DeleteHostelInfo(Hostel hostel)
        {
             await  DeleteHostelInfo(hostel);
        }

        public async Task<IEnumerable<Hostel>> GetAllHotel(Hostel hostel)
        {
            return await GetAllHotel(hostel);
        }

        public async Task<Hostel> GetHostelById(int id)
        {
            if (id == 0)
                return null;
            return await GetHostelById(id);
        }

        public async Task UpdateHostelInfo(Hostel hostel)
        {
            await _context.SaveChangesAsync(); 
        }
    }
}
