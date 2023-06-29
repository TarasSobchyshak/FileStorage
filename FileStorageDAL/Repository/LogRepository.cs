using FileStorageDAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FileStorageDAL.Repository
{
    public class LogRepository : Repository<Log>
    {
        public LogRepository(FileStorageContext context) : base(context)
        {
        }

        public override async Task<Log> Get(int id)
        {
            return await _dbSet
                .Include(log => log.User)
                .Include(log => log.File)
                .FirstOrDefaultAsync(item => item.Id == id);
        }

        public override async Task<List<Log>> GetAll()
        {
            return await _dbSet
                .Include(log => log.User)
                .Include(log => log.File)
                .ToListAsync();
        }
    }
}
