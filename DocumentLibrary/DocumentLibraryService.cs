using DocumentService.Dto;
using DocumentService.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace DocumentService
{
    public class DocumentLibraryService : IDocumentLibraryService
    {
        private readonly IDocStoreDocumentService _docStoreDocumentService;
        private readonly IFilesiteDocumentService _filesiteDocumentService;
        private readonly IExecutedDocumentService _executedDocumentService;

        public DocumentLibraryService(IDocStoreDocumentService docStoreDocumentService, 
                                        IExecutedDocumentService executedDocumentService,
                                        IFilesiteDocumentService filesiteDocumentService)

        {
            _docStoreDocumentService = docStoreDocumentService;
            _executedDocumentService = executedDocumentService;
            _filesiteDocumentService = filesiteDocumentService;
        }

        public IDocument CopyDocument(IDocument document, DocumentFolder destinationFolder)
        {
            throw new System.NotImplementedException();
        }

        public Stream GetDocument(IDocument document)
        {
            throw new System.NotImplementedException();
        }

        public DocumentLibrary GetDocumentLibrary(string clientCode)
        {
            DocumentLibrary library = new DocumentLibrary();

            library.Documents = new List<IDocument>();
            
            //Some entities do not show all types so filter here

            //Calls out up the stack to Documents table
            library.Documents.AddRange(_docStoreDocumentService.GetDocumentsByClientCode(clientCode));
            //Calls out up the stack to Internal Api Filesite
            library.Documents.AddRange(_filesiteDocumentService.GetDocumentsByClientCode(clientCode));
            //Calls out up the stack to Documents table
            library.Documents.AddRange(_executedDocumentService.GetDocumentsByClientCode(clientCode));

            return library;
        }

        public IDocument MoveDocument(IDocument document, DocumentFolder destinationFolder)
        {
            throw new System.NotImplementedException();
        }
    }
}
