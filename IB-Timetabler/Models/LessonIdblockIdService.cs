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
            return await _ibTimetablerContext.LessonIdblockIds.Where(x=>x.LessonId.Equals(id))
                .Select(block => block.BlockId).ToListAsync();
        }

        public async Task<bool> DeleteLessonIdblockIdAsync(LessonIdblockId lessonIdblockId) {
            _ibTimetablerContext.Remove(lessonIdblockId);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
    }
}