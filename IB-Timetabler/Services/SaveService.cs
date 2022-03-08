using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    /// Responsible for interacting with the Saves table in the database 
    public class SaveService {
        
        private readonly IBTimetablerContext _ibTimetablerContext;

        /// Sets the database context (needed for dependency injection) 
        public SaveService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        /// Returns a lost of every Save in the Saves table in the database 
        public async Task<List<Save>> GetAllSavesAsync() {
            return await _ibTimetablerContext.Saves.ToListAsync();
        }
        
        /// Tries to get the number corresponding to the next Save Id and returns 1 if no Saves are in the table 
        public async Task<long> GetNextId() {
            try {
                return await _ibTimetablerContext.Saves.Select(x => x.Id).OrderBy(x => x).LastAsync() + 1;
            }
            catch (InvalidOperationException) {
                return 1;
            }
        }
        
        /// Adds a new Save to the Saves table 
        public async Task InsertSaveAsync(Save save) {
            await _ibTimetablerContext.Saves.AddAsync(save);
            await _ibTimetablerContext.SaveChangesAsync();
        }

        /// Updates the details of a Save already in the database 
        public async Task UpdateSaveAsync(Save save) {
            _ibTimetablerContext.Saves.Update(save);
            await _ibTimetablerContext.SaveChangesAsync();
        }
        
        /// Returns a single Save with the given id 
        public async Task<Save> GetSaveAsync(long id) {
            return await _ibTimetablerContext.Saves.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
        
        /// Removes a Save from the Saves table 
        public async Task DeleteSaveAsync(Save save) {
            _ibTimetablerContext.Remove(save);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}