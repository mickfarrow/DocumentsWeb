using DocumentService.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DocumentService.Interfaces
{
    public interface IMercuryDocumentService
    {
        List<IDocumentFolder> GetDocumentFolders(string clientCode, int parentId);
        List<IDocument> GetDocuments(string clientCode, int folderId);
        List<IDocument> GetDocumentsByClientCode(string clientCode);
        IDocument CopyDocument(IDocument document, IDocumentFolder destinationFolder);
        IDocument MoveDocument(IDocument document, IDocumentFolder destinationFolder);
        Stream GetDocument(string clientCode, int documentId);
        bool Save(IDocument document);
        bool Upload(IDocument document, Stream stream);
    }
}
