using ParkView.Data;

namespace ParkView.Models.Domain
{
    public class RoomRepo : IRoom
    {
        private readonly ParkViewDbContext _context;



        public RoomRepo(ParkViewDbContext context)
        {
            _context = context;
        }



        public Room GetRoomById(int id)
        {
            return _context.Room.FirstOrDefault(h => h.RoomId == id);
        }
    }
}
