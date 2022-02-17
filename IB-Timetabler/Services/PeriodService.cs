using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    public class PeriodService {
        
        private readonly IBTimetablerContext _ibTimetablerContext;

        public PeriodService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<Period>> GetAllPeriodsAsync() {
            return await _ibTimetablerContext.Periods.ToListAsync();
        }
        
        public async Task<long> GetNextId() {
            try {
                return await _ibTimetablerContext.Periods.Select(x => x.Id).OrderBy(x => x).LastAsync() + 1;
            }
            catch (InvalidOperationException) {
                return 1;
            }
        }
        
        public async Task InsertPeriodAsync(Period period) {
            await _ibTimetablerContext.Periods.AddAsync(period);
            await _ibTimetablerContext.SaveChangesAsync();
        }
        
        public async Task DeletePeriodAsync(Period period) {
            _ibTimetablerContext.Remove(period);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}