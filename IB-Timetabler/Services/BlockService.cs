using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    public class BlockService {

        private readonly IBTimetablerContext _ibTimetablerContext;

        public BlockService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<Block>> GetAllBlocksAsync() {
            return await _ibTimetablerContext.Blocks.ToListAsync();
        }
        
        public async Task<long> GetNextId() {
            try {
                return await _ibTimetablerContext.Blocks.Select(x => x.Id).OrderBy(x => x).LastAsync() + 1;
            }
            catch (InvalidOperationException) {
                return 1;
            }
        }
        
        public async Task InsertBlockAsync(Block block) {
            await _ibTimetablerContext.Blocks.AddAsync(block);
            await _ibTimetablerContext.SaveChangesAsync();
        }
        
        public async Task DeleteBlockAsync(Block block) {
            _ibTimetablerContext.Remove(block);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}