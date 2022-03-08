using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    /// Responsible for interacting with the RoomIdlessonIds table in the database 
    public class RoomIdlessonIdService {

        private readonly IBTimetablerContext _ibTimetablerContext;

        /// Sets the database context (needed for dependency injection) 
        public RoomIdlessonIdService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        /// Returns a lost of every RoomIdlessonId in the RoomIdlessonIds table in the database 
        public async Task<List<RoomIdlessonId>> GetAllRoomIdlessonIdsAsync() {
            return await _ibTimetablerContext.RoomIdlessonIds.ToListAsync();
        }
        
        /// Adds a new RoomIdlessonId to the RoomIdlessonIds table 
        public async Task InsertRoomIdlessonIdAsync(RoomIdlessonId roomIdlessonId) {
            await _ibTimetablerContext.RoomIdlessonIds.AddAsync(roomIdlessonId);
            await _ibTimetablerContext.SaveChangesAsync();
        }
        
        /// Removes a list of RoomIdlessonIds from the RoomIdlessonIds table 
        public async Task DeleteRoomIdlessonIdsAsync(IEnumerable<RoomIdlessonId> roomIdlessonIds) {
            _ibTimetablerContext.RemoveRange(roomIdlessonIds);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}