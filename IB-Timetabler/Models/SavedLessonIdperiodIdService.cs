using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IB_Timetabler.Models {
    
    public class SavedLessonIdperiodIdService {
        
        private readonly IBTimetablerContext _ibTimetablerContext;

        public SavedLessonIdperiodIdService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<SavedLessonIdperiodId>> GetAllSavedLessonIdperiodIdsAsync() {
            return await _ibTimetablerContext.SavedLessonIdperiodIds.ToListAsync();
        }
        
        public async Task InsertSavedLessonIdperiodIdAsync(SavedLessonIdperiodId savedLessonIdperiodId) {
            await _ibTimetablerContext.SavedLessonIdperiodIds.AddAsync(savedLessonIdperiodId);
            await _ibTimetablerContext.SaveChangesAsync();
        }
        
        public async Task DeleteSavedLessonIdperiodIdsAsync(IEnumerable<SavedLessonIdperiodId> savedLessonIdperiodId) {
            _ibTimetablerContext.RemoveRange(savedLessonIdperiodId);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}