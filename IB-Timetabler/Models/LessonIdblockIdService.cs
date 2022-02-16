using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IB_Timetabler.Models {
    
    public class LessonIdblockIdService {

        private readonly IBTimetablerContext _ibTimetablerContext;

        public LessonIdblockIdService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<LessonIdblockId>> GetAllLessonIdblockIdsAsync() {
            return await _ibTimetablerContext.LessonIdblockIds.ToListAsync();
        }
        
        public async Task InsertLessonIdblockIdAsync(LessonIdblockId lessonIdblockId) {
            await _ibTimetablerContext.LessonIdblockIds.AddAsync(lessonIdblockId);
            await _ibTimetablerContext.SaveChangesAsync();
        }

        public async Task DeleteLessonIdblockIdsAsync(IEnumerable<LessonIdblockId> lessonIdblockIds) {
            _ibTimetablerContext.RemoveRange(lessonIdblockIds);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}