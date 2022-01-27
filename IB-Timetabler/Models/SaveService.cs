using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IB_Timetabler.Models {
    
    public class SaveService {
        
        private readonly IBTimetablerContext _ibTimetablerContext;

        public SaveService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<Save>> GetAllSavesAsync() {
            return await _ibTimetablerContext.Saves.ToListAsync();
        }
        
        public async Task<List<long>> GetAllIds() {
            return await _ibTimetablerContext.Saves.Select(x => x.Id).ToListAsync();
        }
        
        public async Task<long> GetNextId() {
            try {
                return await _ibTimetablerContext.Saves.Select(x => x.Id).OrderBy(x => x).LastAsync() + 1;
            }
            catch (InvalidOperationException) {
                return 1;
            }
        }
        
        public async Task<bool> InsertSaveAsync(Save save) {
            await _ibTimetablerContext.Saves.AddAsync(save);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateSaveAsync(Save save) {
            _ibTimetablerContext.Saves.Update(save);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
        
        public async Task<Save> GetSaveAsync(long id) {
            return await _ibTimetablerContext.Saves.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
        
        public async Task<bool> DeleteSaveAsync(Save save) {
            _ibTimetablerContext.Remove(save);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
    }
}