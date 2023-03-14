using Hotel_Management_System.Models;

namespace Hotel_Mgt_System.Repository.Interface
{
    public interface IRoom
    {
        Task ReportRoomInfo(Room room);
        Task<IEnumerable<Room>> GetAllRoomInfo(bool trackChanges);
        Task<Room> GetRoomAsync(int id, bool trackChanges);
        Task UpdateRoomInfo(Room room);
        Task DeleteRoomInfo(int id);
    }
}
