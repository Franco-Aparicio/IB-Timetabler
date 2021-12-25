using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IB_Timetabler.Models {
    
    public class RoomIdlessonIdService {

        private readonly IBTimetablerContext _ibTimetablerContext;

        public RoomIdlessonIdService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<RoomIdlessonId>> GetAllRoomIdlessonIdsAsync() {
            return await _ibTimetablerContext.RoomIdlessonIds.ToListAsync();
        }
        
        public async Task<bool> InsertRoomIdlessonIdAsync(RoomIdlessonId roomIdlessonId) {
            await _ibTimetablerContext.RoomIdlessonIds.AddAsync(roomIdlessonId);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
        
        public async Task<bool> DeleteRoomIdlessonIdsAsync(IEnumerable<RoomIdlessonId> roomIdlessonIds) {
            _ibTimetablerContext.RemoveRange(roomIdlessonIds);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
    }
}