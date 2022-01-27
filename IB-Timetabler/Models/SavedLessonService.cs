using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IB_Timetabler.Models {
    
    public class SavedLessonService {
        
        private readonly IBTimetablerContext _ibTimetablerContext;

        public SavedLessonService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<SavedLesson>> GetAllSavedLessonsAsync() {
            return await _ibTimetablerContext.SavedLessons.ToListAsync();
        }

        public async Task<long> GetNextId() {
            try {
                return await _ibTimetablerContext.SavedLessons.Select(x => x.Id).OrderBy(x => x).LastAsync() + 1;
            }
            catch (InvalidOperationException) {
                return 1;
            }
        }
        
        public async Task<bool> InsertSavedLessonAsync(SavedLesson savedLesson) {
            await _ibTimetablerContext.SavedLessons.AddAsync(savedLesson);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }

        public async Task<SavedLesson> GetSavedLessonAsync(long id) {
            return await _ibTimetablerContext.SavedLessons.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
        
        public async Task<bool> UpdateSavedLessonAsync(SavedLesson savedLesson) {
            _ibTimetablerContext.SavedLessons.Update(savedLesson);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteSavedLessonAsync(SavedLesson savedLesson) {
            _ibTimetablerContext.Remove(savedLesson);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
        
        public async Task<bool> DeleteSavedLessonsAsync(List<SavedLesson> savedLesson) {
            _ibTimetablerContext.RemoveRange(savedLesson);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
    }
}