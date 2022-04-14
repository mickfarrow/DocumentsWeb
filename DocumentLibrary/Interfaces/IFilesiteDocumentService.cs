using DocumentService.Dto;
using System.Collections.Generic;
using System.IO;

namespace DocumentService.Interfaces
{
    public interface IFilesiteDocumentService
    {
        List<IDocumentFolder> GetDocumentFolders(string clientCode, string folderName);
        List<IDocument> GetDocuments(string clientCode, string folderName);
        List<IDocument> GetDocumentsByClientCode(string clientCode);
        Stream GetDocument(string clientCode, int documentId);
    }
}