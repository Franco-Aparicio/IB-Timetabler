using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IB_Timetabler.Models {
    
    public class PeriodService {
        
        private readonly IBTimetablerContext _ibTimetablerContext;

        public PeriodService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<Period>> GetAllPeriodsAsync() {
            return await _ibTimetablerContext.Periods.ToListAsync();
        }
        
        public async Task<long> GetNextId() {
            return await _ibTimetablerContext.Periods.Select(x => x.Id).OrderBy(x => x).LastAsync() + 1;
        }
        
        public async Task<bool> InsertPeriodAsync(Period period) {
            await _ibTimetablerContext.Periods.AddAsync(period);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }

        public async Task<Period> GetPeriodAsync(long id) {
            return await _ibTimetablerContext.Periods.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
        
        public async Task<bool> DeletePeriodAsync(Period period) {
            _ibTimetablerContext.Remove(period);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
    }
}