using System.Collections.Generic;

namespace DocumentService.Interfaces
{
    public interface IDocumentLibrary
    {
        List<IDocument> Documents { get; set; }
    }
}