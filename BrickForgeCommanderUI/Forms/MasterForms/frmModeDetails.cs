using BrickForgeCommanderUI.Controls.FunctionControls;
using BrickForgeCommanderUI.Misc.Anya_sReport;
using System;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.MasterForms
{
    public partial class frmModeDetails : Form
    {
        BFC_UndoRedo undoRedo;
        public frmModeDetails()
        {
            InitializeComponent();
            undoRedo = new BFC_UndoRedo();

            // undoRedo.TextBoxes.Add(txtId);
            //  undoRedo.TextBoxes.Add(txtName);

            undoRedo.TextBoxName = "CommonName";

            Controls.Add(undoRedo);


            undoRedo.WireUpButtonClickEvents(undoRedoControl_btnUndo_Click, undoRedoControl_btnRedo_Click);

        }


        private void undoRedoControl_btnUndo_Click(object sender, EventArgs e)
        {
            // Handle undo button click
            undoRedo.btnUndo_Click(sender, e);
        }

        private void undoRedoControl_btnRedo_Click(object sender, EventArgs e)
        {
            // Handle redo button click
            undoRedo.btnRedo_Click(sender, e);
        }

        private void frmModeDetails_Load(object sender, EventArgs e)
        {

        }

        private void bfC_TextBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void bfC_Button1_Click(object sender, EventArgs e)
        {
            AnyaReports.Show("Special message", "Custom Caption", AnyaReports.ReportButton.Ok, AnyaReports.Anya.Happy);
        }
    }
}
