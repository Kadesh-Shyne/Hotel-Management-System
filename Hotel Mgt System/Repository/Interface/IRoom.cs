using Hotel_Management_System.Models;

namespace Hotel_Mgt_System.Repository.Interface
{
    public interface IRoom
    {
        Task ReportRoomInfo(Room room);
        Task<IEnumerable<Room>> GetAllRoomInfo(Room room);
        Task<Room> GetRoomInfoById(int id);
        Task UpdateRoomInfo(Room room);
        Task DeleteRoomInfo(int id);
    }
}
