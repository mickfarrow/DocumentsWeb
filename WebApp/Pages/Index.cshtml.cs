using DocumentService;
using DocumentService.Dto;
using DocumentService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IDocumentLibraryService documentLibraryService)
        {
            _logger = logger;

            var clientCode = "708954";
            DocumentLibrary = documentLibraryService.GetDocumentLibrary(clientCode);
        }
        public DocumentLibrary DocumentLibrary { get; set; }

        public void OnGet()
        {

        }
    }
}
