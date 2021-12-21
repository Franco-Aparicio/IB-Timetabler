using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IB_Timetabler.Models {
    
    public class LessonService {

        private readonly IBTimetablerContext _ibTimetablerContext;

        public LessonService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<Lesson>> GetAllLessonsAsync() {
            return await _ibTimetablerContext.Lessons.ToListAsync();
        }
        
        public async Task<bool> InsertLessonAsync(Lesson lesson) {
            await _ibTimetablerContext.Lessons.AddAsync(lesson);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
        
        public async Task<Lesson> GetLessonAsync(long id) {
            return await _ibTimetablerContext.Lessons.FirstOrDefaultAsync(x=>x.Id.Equals(id));
        }
        
        public async Task<bool> UpdateLessonAsync(Lesson lesson) {
            _ibTimetablerContext.Lessons.Update(lesson);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
        
        public async Task<bool> DeleteLessonAsync(Lesson lesson) {
            _ibTimetablerContext.Remove(lesson);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
    }
}