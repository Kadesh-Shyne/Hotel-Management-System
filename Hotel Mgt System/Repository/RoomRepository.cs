using Hotel_Management_System.Models;
using Hotel_Mgt_System.Data;
using Hotel_Mgt_System.Repository.Interface;

namespace Hotel_Mgt_System.Repository
{
    public class RoomRepository: IRoom
    {
        private ApplicationDbContext _applicationDbContext;
        public RoomRepository(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }

        public async Task<IEnumerable<Room>> GetAllRoomInfo(Room room)
        {
            return await GetAllRoomInfo(room);
        }

        public async Task<Room> GetRoomInfoById(int id)
        {
            if (id == 0)
                return null;

            return await GetRoomInfoById(id);
        }

        public Task ReportRoomInfo(Room room)
        {
            return ReportRoomInfo(room);
        }

        public Task UpdateRoomInfo(Room room)
        {
            return UpdateRoomInfo(room);
        }
        public async Task DeleteRoomInfo(int id)
        {
            await DeleteRoomInfo(id);
        }
    }
}
