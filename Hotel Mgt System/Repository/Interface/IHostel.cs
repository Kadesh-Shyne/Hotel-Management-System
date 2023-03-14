using Hotel_Management_System.Models;

namespace Hotel_Mgt_System.Repository.Interface
{
    public interface IHostel
    {
        Task<IEnumerable<Hostel>> GetAllHotel(Hostel hostel);
        Task<Hostel> GetHostelById(int id);
        Task DeleteHostelInfo(Hostel hostel);
        Task UpdateHostelInfo(Hostel hostel);
    }
}
