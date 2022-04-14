namespace DocumentService.Dto
{
    public enum DocumentType
    {
        DocStoreDocument,
        ExecutedDocument,
        MinuteBook,
        Opinion
    }
    public enum DocumentSource
    {
        Mercury,
        Filesite
    }
    public class Document : IDocument
    {
        public string ClientCode { get; set; }
        public int Id { get; set; }
        public string DocumentName { get; set; }
        public DocumentFolder Folder { get; set; }
        public DocumentSource Source { get; set; }
        public DocumentType DocumentType { get; set; }
    }
}
