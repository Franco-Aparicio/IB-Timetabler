using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IB_Timetabler.Models {
    
    public class RoomService {

        private readonly IBTimetablerContext _ibTimetablerContext;

        public RoomService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<Room>> GetAllRoomsAsync() {
            return await _ibTimetablerContext.Rooms.ToListAsync();
        }
        
        public async Task<long> GetNextId() {
            return await _ibTimetablerContext.Rooms.Select(x => x.Id).OrderBy(x => x).LastAsync() + 1;
        }
        
        public async Task<bool> InsertRoomAsync(Room room) {
            await _ibTimetablerContext.Rooms.AddAsync(room);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
        
        public async Task<Room> GetRoomAsync(long id) {
            return await _ibTimetablerContext.Rooms.FirstOrDefaultAsync(x=>x.Id.Equals(id));
        }

        public async Task<bool> DeleteRoomAsync(Room room) {
            _ibTimetablerContext.Remove(room);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
    }
}