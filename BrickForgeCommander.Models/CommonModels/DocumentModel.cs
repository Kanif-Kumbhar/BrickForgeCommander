namespace BrickForgeCommander.Models.CommonModels
{
    public class DocumentModel : IDocumentModel
    {
        public string DocumentName { get; set; }
        public byte[] DocumentContent { get; set; }
    }
}
