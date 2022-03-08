using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    /// Responsible for interacting with the Rooms table in the database 
    public class RoomService {

        private readonly IBTimetablerContext _ibTimetablerContext;

        /// Sets the database context (needed for dependency injection) 
        public RoomService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        /// Returns a lost of every Room in the Rooms table in the database 
        public async Task<List<Room>> GetAllRoomsAsync() {
            return await _ibTimetablerContext.Rooms.ToListAsync();
        }
        
        /// Tries to get the number corresponding to the next Room Id and returns 1 if no Rooms are in the table 
        public async Task<long> GetNextId() {
            try {
                return await _ibTimetablerContext.Rooms.Select(x => x.Id).OrderBy(x => x).LastAsync() + 1;
            }
            catch (InvalidOperationException) {
                return 1;
            }
        }
        
        /// Adds a new Room to the Rooms table 
        public async Task InsertRoomAsync(Room room) {
            await _ibTimetablerContext.Rooms.AddAsync(room);
            await _ibTimetablerContext.SaveChangesAsync();
        }

        /// Removes a Room from the Rooms table 
        public async Task DeleteRoomAsync(Room room) {
            _ibTimetablerContext.Remove(room);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}