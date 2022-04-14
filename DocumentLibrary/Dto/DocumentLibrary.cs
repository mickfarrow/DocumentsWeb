using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentService.Dto
{
    public class DocumentLibrary : IDocumentLibrary
    {
        public DocumentLibrary()
        {
            Documents = new List<IDocument>();
        }
        public List<IDocument> Documents { get; set; }
    }
}
