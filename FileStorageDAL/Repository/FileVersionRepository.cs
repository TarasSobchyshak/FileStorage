using FileStorageDAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FileStorageDAL.Repository
{
    public class FileVersionRepository : Repository<FileVersion>
    {
        public FileVersionRepository(FileStorageContext context) : base(context)
        {
        }

        public override async Task<FileVersion> Get(int id)
        {
            return await _dbSet
                .Include(fileVersion => fileVersion.VersionedFile).ThenInclude(versionedFile => versionedFile.FileVersions)
                .Include(fileVersion => fileVersion.File)
                .FirstOrDefaultAsync(item => item.Id == id);
        }

        public async Task<FileVersion> GetByFileId(int id)
        {
            return await _dbSet
                .Include(fileVersion => fileVersion.VersionedFile).ThenInclude(versionedFile => versionedFile.FileVersions)
                .Include(fileVersion => fileVersion.File)
                .FirstOrDefaultAsync(item => item.File.Id == id);
        }

        public override async Task<List<FileVersion>> GetAll()
        {
            return await _dbSet
                .Include(fileVersion => fileVersion.VersionedFile)
                .Include(fileVersion => fileVersion.File)
                .ToListAsync();
        }
    }
}
