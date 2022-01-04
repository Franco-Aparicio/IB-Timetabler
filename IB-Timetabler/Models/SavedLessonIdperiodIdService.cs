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
        
        public async Task<bool> InsertSavedLessonIdperiodIdAsync(SavedLessonIdperiodId savedLessonIdperiodId) {
            await _ibTimetablerContext.SavedLessonIdperiodIds.AddAsync(savedLessonIdperiodId);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }

        public async Task<SavedLessonIdperiodId> GetSavedLessonIdperiodIdAsync(long lessonId, long periodId) {
            return await _ibTimetablerContext.SavedLessonIdperiodIds.FirstOrDefaultAsync(x =>
                x.SavedLessonId.Equals(lessonId) && x.PeriodId.Equals(periodId));
        }
        
        public async Task<bool> DeleteSavedLessonIdperiodIdsAsync(IEnumerable<SavedLessonIdperiodId> savedLessonIdperiodId) {
            _ibTimetablerContext.RemoveRange(savedLessonIdperiodId);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
    }
}