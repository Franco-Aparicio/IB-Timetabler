using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IB_Timetabler.Models {
    
    public class LessonIdblockIdService {

        private readonly IBTimetablerContext _ibTimetablerContext;

        public LessonIdblockIdService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<LessonIdblockId>> GetAllLessonIdblockIdsAsync() {
            return await _ibTimetablerContext.LessonIdblockIds.ToListAsync();
        }
        
        public async Task<bool> InsertLessonIdblockIdAsync(LessonIdblockId lessonIdblockId) {
            await _ibTimetablerContext.LessonIdblockIds.AddAsync(lessonIdblockId);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
        
        public async Task<List<long>> GetBlockIdsAsync(long id) {
            List<LessonIdblockId> blocks = await _ibTimetablerContext.LessonIdblockIds.Where(x=>x.LessonId.Equals(id)).ToListAsync();
            List<long> ids = new List<long>();
            foreach (LessonIdblockId block in blocks) {
                ids.Add(block.BlockId);
            }
            return ids;
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