using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    public class TeacherService {
        
        private readonly IBTimetablerContext _ibTimetablerContext;

        public TeacherService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<Teacher>> GetAllTeachersAsync() {
            return await _ibTimetablerContext.Teachers.ToListAsync();
        }
        
        public async Task<long> GetNextId() {
            try {
                return await _ibTimetablerContext.Teachers.Select(x => x.Id).OrderBy(x => x).LastAsync() + 1;
            }
            catch (InvalidOperationException) {
                return 1;
            }
        }
        
        public async Task InsertTeacherAsync(Teacher teacher) {
            await _ibTimetablerContext.Teachers.AddAsync(teacher);
            await _ibTimetablerContext.SaveChangesAsync();
        }
        
        public async Task DeleteTeacherAsync(Teacher teacher) {
            _ibTimetablerContext.Remove(teacher);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}