using DocumentService.Dto;
using System.Collections.Generic;
using System.IO;

namespace DocumentService.Interfaces
{
    public interface IDocumentLibraryService
    {
        DocumentLibrary GetDocumentLibrary(string clientCode);
        IDocument CopyDocument(IDocument document, DocumentFolder destinationFolder);
        IDocument MoveDocument(IDocument document, DocumentFolder destinationFolder);
        Stream GetDocument(IDocument document);
    }
}