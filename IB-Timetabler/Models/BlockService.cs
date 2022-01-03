using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IB_Timetabler.Models {
    
    public class BlockService {

        private readonly IBTimetablerContext _ibTimetablerContext;

        public BlockService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<Block>> GetAllBlocksAsync() {
            return await _ibTimetablerContext.Blocks.ToListAsync();
        }
        
        public async Task<long> GetNextId() {
            return await _ibTimetablerContext.Blocks.Select(x => x.Id).OrderBy(x => x).LastAsync() + 1;
        }
        
        public async Task<bool> InsertBlockAsync(Block block) {
            await _ibTimetablerContext.Blocks.AddAsync(block);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }

        public async Task<Block> GetBlockAsync(long id) {
            return await _ibTimetablerContext.Blocks.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
        
        public async Task<bool> DeleteBlockAsync(Block block) {
            _ibTimetablerContext.Remove(block);
            await _ibTimetablerContext.SaveChangesAsync();
            return true;
        }
    }
}