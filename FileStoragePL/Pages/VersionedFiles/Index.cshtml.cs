using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FileStorageDAL.Models;
using FileStorageBL.Facades;

namespace FileStoragePL.Pages.VersionedFiles
{
    [RequireAdmin]
    public class IndexModel : PageModel
    {
        private readonly VersionedFileFacade _versionedFilesFacade;

        public IndexModel(VersionedFileFacade versionedFilesFacade)
        {
            _versionedFilesFacade = versionedFilesFacade;
        }

        public IList<VersionedFile> VersionedFile { get;set; }

        public async Task OnGetAsync()
        {
            VersionedFile = await _versionedFilesFacade.GetAllVersionedFilesAsync();
        }
    }
}
