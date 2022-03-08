using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    /// Responsible for interacting with the SavedLessonIdperiodIds table in the database 
    public class SavedLessonIdperiodIdService {
        
        private readonly IBTimetablerContext _ibTimetablerContext;

        /// Sets the database context (needed for dependency injection) 
        public SavedLessonIdperiodIdService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        /// Returns a lost of every SavedLessonIdperiodId in the SavedLessonIdperiodIds table in the database 
        public async Task<List<SavedLessonIdperiodId>> GetAllSavedLessonIdperiodIdsAsync() {
            return await _ibTimetablerContext.SavedLessonIdperiodIds.ToListAsync();
        }
        
        /// Adds a new SavedLessonIdperiodId to the SavedLessonIdperiodIds table 
        public async Task InsertSavedLessonIdperiodIdAsync(SavedLessonIdperiodId savedLessonIdperiodId) {
            await _ibTimetablerContext.SavedLessonIdperiodIds.AddAsync(savedLessonIdperiodId);
            await _ibTimetablerContext.SaveChangesAsync();
        }
        
        /// Removes a list of SavedLessonIdperiodIds from the SavedLessonIdperiodIds table 
        public async Task DeleteSavedLessonIdperiodIdsAsync(IEnumerable<SavedLessonIdperiodId> savedLessonIdperiodId) {
            _ibTimetablerContext.RemoveRange(savedLessonIdperiodId);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}