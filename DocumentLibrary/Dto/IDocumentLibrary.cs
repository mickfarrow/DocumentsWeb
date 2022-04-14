using System.Collections.Generic;

namespace DocumentService.Dto
{
    public interface IDocumentLibrary
    {
        List<IDocument> Documents { get; set; }
    }
}