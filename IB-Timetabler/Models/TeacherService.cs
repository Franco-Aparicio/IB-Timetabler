using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IB_Timetabler.Models {
    
    public class TeacherService {
        
        private readonly IBTimetablerContext _ibTimetablerContext;

        public TeacherService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<Teacher>> GetAllTeachersAsync() {
            return await _ibTimetablerContext.Teachers.ToListAsync();
        }
        
        public async Task<bool> InsertTeacherAsync(Teacher teacher) {
            await _ibTimetablerContext.Teachers.AddAsync(teacher);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
        
        public async Task<Teacher> GetTeacherAsync(long id) {
            return await _ibTimetablerContext.Teachers.FirstOrDefaultAsync(x=>x.Id.Equals(id));
        }
        
        public async Task<bool> UpdateTeacherAsync(Teacher teacher) {
            _ibTimetablerContext.Teachers.Update(teacher);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
        
        public async Task<bool> DeleteTeacherAsync(Teacher teacher) {
            _ibTimetablerContext.Remove(teacher);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
    }
}