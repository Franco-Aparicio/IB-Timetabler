using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    /// Responsible for interacting with the Teachers table in the database 
    public class TeacherService {
        
        private readonly IBTimetablerContext _ibTimetablerContext;

        /// Sets the database context (needed for dependency injection) 
        public TeacherService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        /// Returns a lost of every Teacher in the Teachers table in the database 
        public async Task<List<Teacher>> GetAllTeachersAsync() {
            return await _ibTimetablerContext.Teachers.ToListAsync();
        }
        
        /// Tries to get the number corresponding to the next Teacher Id and returns 1 if no Teachers are in the table 
        public async Task<long> GetNextId() {
            try {
                return await _ibTimetablerContext.Teachers.Select(x => x.Id).OrderBy(x => x).LastAsync() + 1;
            }
            catch (InvalidOperationException) {
                return 1;
            }
        }
        
        /// Adds a new Teacher to the Teachers table 
        public async Task InsertTeacherAsync(Teacher teacher) {
            await _ibTimetablerContext.Teachers.AddAsync(teacher);
            await _ibTimetablerContext.SaveChangesAsync();
        }
        
        /// Removes a Teacher from the Teachers table 
        public async Task DeleteTeacherAsync(Teacher teacher) {
            _ibTimetablerContext.Remove(teacher);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}