using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickForgeCommanderUI.Controls.FunctionControls
{
    public partial class BFC_UndoRedo : UserControl
    {
        public BFC_UndoRedo()
        {
            InitializeComponent();
            UpdateUndoRedoButtons();
        }

        public void WireUpButtonClickEvents(EventHandler undoClickHandler, EventHandler redoClickHandler)
        {
            btnUndo.Click += undoClickHandler;
            btnRedo.Click += redoClickHandler;
        }

        private List<TextBox> textBoxes = new List<TextBox>();

        public List<TextBox> TextBoxes => textBoxes;

        private void SaveTextToUndoStack(TextBox textBox)
        {
            var undoStack = GetUndoStack(textBox);
            undoStack.Push(textBox.Text);
            GetRedoStack(textBox).Clear();
            UpdateUndoRedoButtons();
        }

        private void UndoTextBox(TextBox textBox)
        {
            var undoStack = GetUndoStack(textBox);
            var redoStack = GetRedoStack(textBox);

            if (undoStack.Count > 0)
            {
                redoStack.Push(textBox.Text);
                textBox.Text = undoStack.Pop();
                UpdateUndoRedoButtons();
            }
        }

        private void RedoTextBox(TextBox textBox)
        {
            var undoStack = GetUndoStack(textBox);
            var redoStack = GetRedoStack(textBox);

            if (redoStack.Count > 0)
            {
                undoStack.Push(textBox.Text);
                textBox.Text = redoStack.Pop();
                UpdateUndoRedoButtons();
            }
        }

        private Stack<string> GetUndoStack(TextBox textBox)
        {
            return textBox.Tag as Stack<string>;
        }

        private Stack<string> GetRedoStack(TextBox textBox)
        {
            return textBox.Tag as Stack<string>;
        }

        private void UpdateUndoRedoButtons()
        {
            bool anyUndo = textBoxes.Any(textBox => GetUndoStack(textBox).Count > 0);
            bool anyRedo = textBoxes.Any(textBox => GetRedoStack(textBox).Count > 0);

            btnUndo.Enabled = anyUndo;
            btnRedo.Enabled = anyRedo;
        }

        public void btnUndo_Click(object sender, EventArgs e)
        {
            foreach (var textBox in textBoxes)
            {
                UndoTextBox(textBox);
            }
        }

        public void btnRedo_Click(object sender, EventArgs e)
        {
            foreach (var textBox in textBoxes)
            {
                RedoTextBox(textBox);
            }
        }

        public string TextBoxName
        {
            get { return textBoxes.FirstOrDefault()?.Name; }
            set
            {
                foreach (var textBox in textBoxes)
                {
                    textBox.Name = value;
                }
            }
        }

        public string TextBoxText
        {
            get { return textBoxes.FirstOrDefault()?.Text; }
            set
            {
                foreach (var textBox in textBoxes)
                {
                    textBox.Text = value;
                }
            }
        }
    }
}

