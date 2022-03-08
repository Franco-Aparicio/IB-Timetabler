using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    /// Responsible for interacting with the Lessons table in the database 
    public class LessonService {

        private readonly IBTimetablerContext _ibTimetablerContext;

        /// Sets the database context (needed for dependency injection) 
        public LessonService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        /// Returns a lost of every Lesson in the Lessons table in the database 
        public async Task<List<Lesson>> GetAllLessonsAsync() {
            return await _ibTimetablerContext.Lessons.ToListAsync();
        }

        /// Tries to get the number corresponding to the next Lesson Id and returns 1 if no Lessons are in the table 
        public async Task<long> GetNextId() {
            try {
                return await _ibTimetablerContext.Lessons.Select(x => x.Id).OrderBy(x => x).LastAsync() + 1;
            }
            catch (InvalidOperationException) {
                return 1;
            }
        }
        
        /// Adds a new Lesson to the Lessons table 
        public async Task InsertLessonAsync(Lesson lesson) {
            await _ibTimetablerContext.Lessons.AddAsync(lesson);
            await _ibTimetablerContext.SaveChangesAsync();
        }
        
        /// Returns a single Lesson with the given id 
        public async Task<Lesson> GetLessonAsync(long id) {
            return await _ibTimetablerContext.Lessons.FirstOrDefaultAsync(x=>x.Id.Equals(id));
        }
        
        /// Updates the details of a Lesson already in the database 
        public async Task UpdateLessonAsync(Lesson lesson) {
            _ibTimetablerContext.Lessons.Update(lesson);
            await _ibTimetablerContext.SaveChangesAsync();
        }
        
        /// Removes a Lesson from the Lessons table 
        public async Task DeleteLessonAsync(Lesson lesson) {
            _ibTimetablerContext.Remove(lesson);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}