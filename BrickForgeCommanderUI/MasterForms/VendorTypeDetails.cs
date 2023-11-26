using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace BrickForgeCommanderUI.MasterForms
{
    public partial class frmVendorTypeDetails : Form
    {
        #region CUR Operation
        private Stack<string> vendorTypeIdUndoStack = new Stack<string>();
        private Stack<string> vendorTypeIdRedoStack = new Stack<string>();

        private Stack<string> vendorTypeNameUndoStack = new Stack<string>();
        private Stack<string> vendorTypeNameRedoStack = new Stack<string>();

        private void UpdateUndoRedoButtons()
        {
            btnUndo.Enabled = vendorTypeIdUndoStack.Count > 0 || vendorTypeNameUndoStack.Count > 0;
            btnRedo.Enabled = vendorTypeIdRedoStack.Count > 0 || vendorTypeNameRedoStack.Count > 0;
        }

        private void SaveTextToUndoStack(TextBox textBox, Stack<string> undoStack, Stack<string> redoStack)
        {
            undoStack.Push(textBox.Text);
            redoStack.Clear();
            UpdateUndoRedoButtons();
        }

        private void UndoTextBox(TextBox textBox, Stack<string> undoStack, Stack<string> redoStack)
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(textBox.Text);
                textBox.Text = undoStack.Pop();
                UpdateUndoRedoButtons();
            }
        }

        private void RedoTextBox(TextBox textBox, Stack<string> undoStack, Stack<string> redoStack)
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(textBox.Text);
                textBox.Text = redoStack.Pop();
                UpdateUndoRedoButtons();
            }
        }

        #endregion

        #region CUR Click Events
        private void txtVendorTypeId_TextChanged(object sender, EventArgs e)
        {
            SaveTextToUndoStack(txtVendorTypeId, vendorTypeIdUndoStack, vendorTypeIdRedoStack);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SaveTextToUndoStack(txtVendorTypeId, vendorTypeIdUndoStack, vendorTypeIdRedoStack);
            SaveTextToUndoStack(txtVendorTypeName, vendorTypeNameUndoStack, vendorTypeNameRedoStack);

            txtVendorTypeId.Clear();
            txtVendorTypeName.Clear();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            UndoTextBox(txtVendorTypeId, vendorTypeIdUndoStack, vendorTypeIdRedoStack);
            UndoTextBox(txtVendorTypeName, vendorTypeNameUndoStack, vendorTypeNameRedoStack);
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            RedoTextBox(txtVendorTypeId, vendorTypeIdUndoStack, vendorTypeIdRedoStack);
            RedoTextBox(txtVendorTypeName, vendorTypeNameUndoStack, vendorTypeNameRedoStack);
        }

        private void txtVendorTypeName_TextChanged(object sender, EventArgs e)
        {
            SaveTextToUndoStack(txtVendorTypeName, vendorTypeNameUndoStack, vendorTypeNameRedoStack);
        }

        #endregion

        public frmVendorTypeDetails()
        {
            InitializeComponent();
            this.CenterToParent();
            this.Load += frmVendorTypeDetails_Load;
        }

        private void frmVendorTypeDetails_Load(object sender, EventArgs e)
        {
            int radius = 50; // Adjust the radius as needed
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            this.Region = new Region(path);
        }


        #region Buttons Click Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

    }
}
