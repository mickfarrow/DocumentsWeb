using DocumentService.Enums;
using DocumentService.Interfaces;

namespace DocumentService.Dto
{
    public class Document : IDocument
    {
        public string ClientCode { get; set; }
        public int Id { get; set; }
        public string DocumentName { get; set; }
        public IDocumentFolder Folder { get; set; }
        public DocumentSource Source { get; set; }
        public DocumentType DocumentType { get; set; }
    }
}
