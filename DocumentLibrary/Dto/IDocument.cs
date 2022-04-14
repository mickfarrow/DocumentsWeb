namespace DocumentService.Dto
{
    public interface IDocument
    {
        public string ClientCode { get; set; }
        int Id { get; set; }
        string DocumentName { get; set; }
        DocumentFolder Folder { get; set; }
        DocumentSource Source { get; set; }
        DocumentType DocumentType { get; set; }
    }
}
