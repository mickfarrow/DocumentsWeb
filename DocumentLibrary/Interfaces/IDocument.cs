using DocumentService.Enums;

namespace DocumentService.Interfaces
{
    public interface IDocument
    {
        public string ClientCode { get; set; }
        int Id { get; set; }
        string DocumentName { get; set; }
        IDocumentFolder Folder { get; set; }
        DocumentSource Source { get; set; }
        DocumentType DocumentType { get; set; }
    }
}
