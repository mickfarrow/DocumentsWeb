using DocumentService.Dto;
using DocumentService.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DocumentService
{
    public sealed class FilesiteDocumentService : IFilesiteDocumentService
    {
        public FilesiteDocumentService()
        {

        }

        public Stream GetDocument(string clientCode, int documentId)
        {
            throw new NotImplementedException();
        }

        public List<IDocumentFolder> GetDocumentFolders(string clientCode, string folderName)
        {
            throw new NotImplementedException();
        }

        public List<IDocument> GetDocuments(string clientCode, string folderName)
        {
            throw new NotImplementedException();
        }

        public List<IDocument> GetDocumentsByClientCode(string clientCode)
        {
            //InternalApi
            //Get MinuteBooks
            //Get Opinions
            return new List<IDocument>
            {
                new Document
                {
                    ClientCode = clientCode,
                    Id = 354678,
                    DocumentName = "Memorandum and Articles of Association.docx",
                    Source = DocumentSource.Filesite,
                    Folder = new DocumentFolder
                    {
                        Id = 1,
                        FolderName = "Minute Book"
                    },
                    DocumentType = DocumentType.MinuteBook
                },
                new Document
                {
                    ClientCode = clientCode,
                    Id = 454455,
                    DocumentName = "A legal opinion.docx",
                    Source = DocumentSource.Filesite,
                    Folder = new DocumentFolder
                    {
                        Id = 2,
                        FolderName = "Opinions"
                    },
                    DocumentType = DocumentType.Opinion
                }
            };
        }
    }
}
