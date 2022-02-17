using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    public class RoomIdlessonIdService {

        private readonly IBTimetablerContext _ibTimetablerContext;

        public RoomIdlessonIdService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<RoomIdlessonId>> GetAllRoomIdlessonIdsAsync() {
            return await _ibTimetablerContext.RoomIdlessonIds.ToListAsync();
        }
        
        public async Task InsertRoomIdlessonIdAsync(RoomIdlessonId roomIdlessonId) {
            await _ibTimetablerContext.RoomIdlessonIds.AddAsync(roomIdlessonId);
            await _ibTimetablerContext.SaveChangesAsync();
        }
        
        public async Task DeleteRoomIdlessonIdsAsync(IEnumerable<RoomIdlessonId> roomIdlessonIds) {
            _ibTimetablerContext.RemoveRange(roomIdlessonIds);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}