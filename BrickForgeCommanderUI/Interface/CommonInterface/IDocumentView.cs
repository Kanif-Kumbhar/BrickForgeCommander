using System;
using System.Collections.Generic;

namespace BrickForgeCommanderUI.Interface.CommonInterface
{
    public interface IDocumentView
    {
        event Action<string, byte[]> UploadDocument;
        event Action<string> PreviewDocument;

        void ShowError(string message);
        void UpdateDataGridView(List<string> documentNames);
    }

}
