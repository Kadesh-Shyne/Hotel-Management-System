using Hotel_Management_System.Models;

namespace Hotel_Mgt_System.Repository.Interface
{
    public interface IHostel
    {
        Task<IEnumerable<Hostel>> GetAllHotel(bool trackChanges);
        Task<Hostel> GetHostelAsync(int id, bool trackChanges);
        Task DeleteHostelInfo(Hostel hostel);
        Task UpdateHostelInfo(Hostel hostel);
    }
}
