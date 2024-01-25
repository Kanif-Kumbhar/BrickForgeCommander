using BrickForgeCommander.Models.CommonModels;
using System.Collections.Generic;
using System.Linq;
using BrickForgeCommanderUI.Forms.Misc;
using BrickForgeCommanderUI.Helpers;
using BrickForgeCommanderUI.Interface.CommonInterface;

namespace BrickForgeCommanderUI.Presenters.CommonPresenters
{
    public class DocumentPresenter
    {
        private readonly IDocumentView _view;
        private readonly Dictionary<string, DocumentModel> _documents = new Dictionary<string, DocumentModel>();

        public DocumentPresenter(IDocumentView view)
        {
            _view = view;
            _view.UploadDocument += UploadDocument;
            _view.PreviewDocument += PreviewDocument;
        }

        private void UploadDocument(string documentName, byte[] documentContent)
        {
            // Check if document size is within the limit
            if (documentContent.Length > 200 * 1024)
            {
                _view.ShowError("Document size exceeds 200KB limit.");
                return;
            }

            // Add document to the dictionary
            _documents.Add(documentName,
                new DocumentModel { DocumentName = documentName, DocumentContent = documentContent });

            // Update the DataGridView
            _view.UpdateDataGridView(_documents.Keys.ToList());
        }

        private void PreviewDocument(string documentName)
        {
            if (_documents.TryGetValue(documentName, out var document))
            {
                FormHelper.OpenDialogForm<frmPreviewImage>();
            }
        }
    }
}
