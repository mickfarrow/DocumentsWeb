using DocumentService.Dto;
using DocumentService.Enums;
using DocumentService.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace DocumentService
{
    public sealed class ExecutedDocumentService : IExecutedDocumentService
    {
        public ExecutedDocumentService()
        {

        }

        public IDocument CopyDocument(IDocument document, IDocumentFolder destinationFolder)
        {
            throw new NotImplementedException();
        }

        public Stream GetDocument(string clientCode, int documentId)
        {
            throw new NotImplementedException();
        }

        public List<IDocumentFolder> GetDocumentFolders(string clientCode, int parentId)
        {
            throw new NotImplementedException();
        }

        public List<IDocument> GetDocuments(string clientCode, int folderId)
        {
            throw new NotImplementedException();
        }

        public List<IDocument> GetDocumentsByClientCode(string clientCode)
        {
            //Hardcoded
            return new List<IDocument>
            {
                new Document
                {
                    ClientCode = clientCode,
                    Id = 456,
                    DocumentName = "MyDoc.docx",
                    Source = DocumentSource.Mercury,
                    Folder = new DocumentFolder
                    {
                        Id = 1,
                        FolderName = "Word"
                    },
                    DocumentType = DocumentType.ExecutedDocument
                },
                new Document
                {
                    ClientCode = clientCode,
                    Id = 7654,
                    DocumentName = "MyDoc.xlsx",
                    Source = DocumentSource.Mercury,
                    Folder = new DocumentFolder
                    {
                        Id = 2,
                        FolderName = "Excel"
                    },
                    DocumentType = DocumentType.ExecutedDocument
                }
            };
        }

        public IDocument MoveDocument(IDocument document, IDocumentFolder destinationFolder)
        {
            throw new NotImplementedException();
        }

        public bool Save(IDocument document)
        {
            throw new NotImplementedException();
        }

        public bool Upload(IDocument document, Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}
