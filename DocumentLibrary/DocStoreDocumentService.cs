using DocumentService.Dto;
using DocumentService.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DocumentService
{
    public sealed class DocStoreDocumentService : IDocStoreDocumentService
    {
        public DocStoreDocumentService()
        {

        }

        public IDocument CopyDocument(IDocument document, DocumentFolder destinationFolder)
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
                    DocumentType = DocumentType.DocStoreDocument
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
                    DocumentType = DocumentType.DocStoreDocument
                }
            };
        }

        public IDocument MoveDocument(IDocument document, DocumentFolder destinationFolder)
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
