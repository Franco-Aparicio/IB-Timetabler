using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    

    /// Responsible for interacting with the Blocks table in the database 
    public class BlockService {

        private readonly IBTimetablerContext _ibTimetablerContext;

        /// Sets the database context (needed for dependency injection) 
        public BlockService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        /// Returns a lost of every Block in the Blocks table in the database 
        public async Task<List<Block>> GetAllBlocksAsync() {
            return await _ibTimetablerContext.Blocks.ToListAsync();
        }
        
        /// Tries to get the number corresponding to the next Block Id and returns 1 if no Blocks are in the table 
        public async Task<long> GetNextId() {
            try {
                return await _ibTimetablerContext.Blocks.Select(x => x.Id).OrderBy(x => x).LastAsync() + 1;
            }
            catch (InvalidOperationException) {
                return 1;
            }
        }
        
        /// Adds a new Block to the Blocks table 
        public async Task InsertBlockAsync(Block block) {
            await _ibTimetablerContext.Blocks.AddAsync(block);
            await _ibTimetablerContext.SaveChangesAsync();
        }
        
        /// Removes a Block from the Blocks table 
        public async Task DeleteBlockAsync(Block block) {
            _ibTimetablerContext.Remove(block);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}