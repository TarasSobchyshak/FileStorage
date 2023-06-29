using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FileStorageDAL.Models;
using FileStorageBL.Facades;

namespace FileStoragePL.Pages.FileVersions
{
    [RequireAdmin]
    public class IndexModel : PageModel
    {
        private readonly FileVersionFacade _fileVersionFacade;

        public IndexModel(FileVersionFacade fileVersionFacade)
        {
            _fileVersionFacade = fileVersionFacade;
        }

        public IList<FileVersion> FileVersion { get;set; }

        public async Task OnGetAsync()
        {
            FileVersion = await _fileVersionFacade.GetAllFileVersionsAsync();
        }
    }
}
