using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    /// Responsible for interacting with the SavedLessons table in the database 
    public class SavedLessonService {
        
        private readonly IBTimetablerContext _ibTimetablerContext;

        /// Sets the database context (needed for dependency injection) 
        public SavedLessonService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        /// Returns a lost of every SavedLesson in the SavedLessons table in the database 
        public async Task<List<SavedLesson>> GetAllSavedLessonsAsync() {
            return await _ibTimetablerContext.SavedLessons.ToListAsync();
        }

        /// Tries to get the number corresponding to the next SavedLesson Id and returns 1 if no SavedLessons are in the table 
        public async Task<long> GetNextId() {
            try {
                return await _ibTimetablerContext.SavedLessons.Select(x => x.Id).OrderBy(x => x).LastAsync() + 1;
            }
            catch (InvalidOperationException) {
                return 1;
            }
        }
        
        /// Adds a new SavedLesson to the SavedLessons table 
        public async Task InsertSavedLessonAsync(SavedLesson savedLesson) {
            await _ibTimetablerContext.SavedLessons.AddAsync(savedLesson);
            await _ibTimetablerContext.SaveChangesAsync();
        }

        /// Returns a single SavedLesson with the given id 
        public async Task<SavedLesson> GetSavedLessonAsync(long id) {
            return await _ibTimetablerContext.SavedLessons.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
        
        /// Updates the details of a SavedLesson already in the database 
        public async Task UpdateSavedLessonAsync(SavedLesson savedLesson) {
            _ibTimetablerContext.SavedLessons.Update(savedLesson);
            await _ibTimetablerContext.SaveChangesAsync();
        }

        /// Removes a SavedLesson from the SavedLessons table 
        public async Task DeleteSavedLessonAsync(SavedLesson savedLesson) {
            _ibTimetablerContext.Remove(savedLesson);
            await _ibTimetablerContext.SaveChangesAsync();
        }
        
        /// Removes a list of SavedLessons from the SavedLessons table 
        public async Task DeleteSavedLessonsAsync(IEnumerable<SavedLesson> savedLesson) {
            _ibTimetablerContext.RemoveRange(savedLesson);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}