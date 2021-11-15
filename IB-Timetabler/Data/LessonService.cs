using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IB_Timetabler.Data {
    
    public class LessonService {

        private LessonDbContext DbContext;

        public LessonService(LessonDbContext dbContext) {
            DbContext = dbContext;
        }

        public async Task<List<Lesson>> GetLessonAsync() {
            return await DbContext.Lesson.ToListAsync();
        }

        public async Task<Lesson> AddLessonAsync(Lesson lesson) {
            try {
                DbContext.Lesson.Add(lesson);
                await DbContext.SaveChangesAsync();
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            return lesson;
        }
        
        public async Task<Lesson> UpdateLessonAsync(Lesson lesson) {
            try {
                Lesson lessonExist = DbContext.Lesson.FirstOrDefault(x=>x.ID == lesson.ID);
                if (lessonExist != null) {
                    DbContext.Update(lesson);
                    await DbContext.SaveChangesAsync();
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            return lesson;
        }
        
        public async Task<Lesson> DeleteLessonAsync(Lesson lesson) {
            try {
                DbContext.Lesson.Remove(lesson);
                await DbContext.SaveChangesAsync();
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            return lesson;
        }
    }
}