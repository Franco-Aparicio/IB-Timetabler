using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IB_Timetabler.Models {
    
    public class SavedLessonService {
        
        private readonly IBTimetablerContext _ibTimetablerContext;

        public SavedLessonService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<SavedLesson>> GetAllSavedLessonsAsync() {
            return await _ibTimetablerContext.SavedLessons.ToListAsync();
        }

        public async Task<bool> InsertSavedLessonAsync(SavedLesson savedLesson) {
            await _ibTimetablerContext.SavedLessons.AddAsync(savedLesson);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }

        public async Task<SavedLesson> GetSavedLessonAsync(long id) {
            return await _ibTimetablerContext.SavedLessons.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
        
        public async Task<bool> DeleteSavedLessonAsync(SavedLesson savedLesson) {
            _ibTimetablerContext.Remove(savedLesson);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
    }
}