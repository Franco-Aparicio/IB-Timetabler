using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    /// Responsible for interacting with the Periods table in the database 
    public class PeriodService {
        
        private readonly IBTimetablerContext _ibTimetablerContext;

        /// Sets the database context (needed for dependency injection) 
        public PeriodService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        /// Returns a lost of every Period in the Periods table in the database 
        public async Task<List<Period>> GetAllPeriodsAsync() {
            return await _ibTimetablerContext.Periods.ToListAsync();
        }
        
        /// Tries to get the number corresponding to the next Period Id and returns 1 if no Periods are in the table 
        public async Task<long> GetNextId() {
            try {
                return await _ibTimetablerContext.Periods.Select(x => x.Id).OrderBy(x => x).LastAsync() + 1;
            }
            catch (InvalidOperationException) {
                return 1;
            }
        }
        
        /// Adds a new Period to the Periods table 
        public async Task InsertPeriodAsync(Period period) {
            await _ibTimetablerContext.Periods.AddAsync(period);
            await _ibTimetablerContext.SaveChangesAsync();
        }
        
        /// Removes a Period from the Periods table 
        public async Task DeletePeriodAsync(Period period) {
            _ibTimetablerContext.Remove(period);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}