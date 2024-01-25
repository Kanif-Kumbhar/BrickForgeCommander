namespace BrickForgeCommander.Models.CommonModels
{
    public interface IDocumentModel
    {
        byte[] DocumentContent { get; set; }
        string DocumentName { get; set; }
    }
}