using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    /// Responsible for interacting with the LessonIdblockIds table in the database 
    public class LessonIdblockIdService {

        private readonly IBTimetablerContext _ibTimetablerContext;

        /// Sets the database context (needed for dependency injection) 
        public LessonIdblockIdService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        /// Returns a lost of every LessonIdblockId in the LessonIdblockIds table in the database 
        public async Task<List<LessonIdblockId>> GetAllLessonIdblockIdsAsync() {
            return await _ibTimetablerContext.LessonIdblockIds.ToListAsync();
        }
        
        /// Adds a new LessonIdblockId to the LessonIdblockIds table 
        public async Task InsertLessonIdblockIdAsync(LessonIdblockId lessonIdblockId) {
            await _ibTimetablerContext.LessonIdblockIds.AddAsync(lessonIdblockId);
            await _ibTimetablerContext.SaveChangesAsync();
        }

        /// Removes a list of LessonIdblockIds from the LessonIdblockIds table 
        public async Task DeleteLessonIdblockIdsAsync(IEnumerable<LessonIdblockId> lessonIdblockIds) {
            _ibTimetablerContext.RemoveRange(lessonIdblockIds);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}